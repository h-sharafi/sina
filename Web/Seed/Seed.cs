using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VestaEShop.Web.Areas.Management.Controllers;
using Web.Controllers;

namespace API
{
    public static class Seed
    {
        public static async Task SeedData(DataContext context)
        {


            IEnumerable<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies()
                // Ignore assemblies which their name start with following names:
                .Where(a => !a.FullName.StartsWith("mscorlib")
                            && !a.FullName.StartsWith("System")
                            && !a.FullName.StartsWith("Microsoft")
                            && !a.FullName.StartsWith("WebDev")
                            && !a.FullName.StartsWith("SMDiagnostics")
                            && !a.FullName.StartsWith("Anonymously")
                            && !a.FullName.StartsWith("Antlr3")
                            && !a.FullName.StartsWith("EntityFramework")
                            && !a.FullName.StartsWith("Newtonsoft")
                            && !a.FullName.StartsWith("Owin")
                            && !a.FullName.StartsWith("WebGrease")
                            && !a.FullName.StartsWith("App_")
                            && !a.FullName.StartsWith("Kendo"));
            var existActionKey = new List<string>();
            foreach (Assembly assembly in assemblies)
            {
                // http://stackoverflow.com/questions/1423733/how-to-tell-if-a-net-assembly-is-dynamic
                if (!(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                    && assembly.ManifestModule.GetType().Namespace != "System.Reflection.Emit")
                {
                    Type[] types = assembly.GetTypes().Where(t => t.BaseType == typeof(ManagementController)).ToArray();

                    foreach (var type in types)
                    {
                        bool controllerHasAuthorizeAttribute =
                            type.CustomAttributes.Any(c => c.AttributeType.Name == "AuthorizeAttribute");

                        bool classHasIgnorePermissionCheck =
                            type.CustomAttributes.Any(c => c.AttributeType.Name == "IgnorePermissionCheckAttribute");
                        if (classHasIgnorePermissionCheck) // if the class has this attribute, that means it's marked to ignore permission check
                        {
                            continue;
                        }

                        string controllerNameLocalized = null;
                        var classTitle = type.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "TitleAttribute");
                        if (classTitle != null)
                        {
                            controllerNameLocalized = classTitle.ConstructorArguments[0].Value.ToString();
                        }

                        string controllerKey = null;
                        var controllerKeyAttribue = type.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "KeyAttribute");
                        if (controllerKeyAttribue != null)
                            controllerKey = controllerKeyAttribue.ConstructorArguments[0].Value.ToString();
                        else
                            continue;

                        string controllerIcon = null;
                        var controllerIconAttribue = type.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "IconAttribute");
                        if (controllerIconAttribue != null)
                            controllerIcon = controllerIconAttribue.ConstructorArguments[0].Value.ToString();

                        bool dontSideBarShow = type.CustomAttributes.Any(c => c.AttributeType.Name == "DontSideBarShowAttribute");



                        ControllerData controllerData = new ControllerData()
                        {
                            CreationTime = DateTime.Now,
                            ControllerNamespace = type.Namespace,
                            ControllerName = type.Name.Replace("Controller", ""),
                            RequiresAuthorization = controllerHasAuthorizeAttribute,
                            ControllerNameLocalized = controllerNameLocalized,
                            Key = controllerKey,
                            ControllerIcon = controllerIcon,
                            DisplaySort = 0,
                            TotalSeen = 0,
                            IsDontSideBarShow = dontSideBarShow
                        };

                        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
                        List<string> actions = new List<string>();
                        foreach (MethodInfo methodInfo in methods)
                        {
                            // Check if method has IgnorePermissionCheck attribute
                            bool methodHasIgnorePermissionCheck = methodInfo.CustomAttributes
                                    .Any(c => c.AttributeType.Name == "IgnorePermissionCheckAttribute");
                            if (methodHasIgnorePermissionCheck)
                            {
                                continue;
                            }
                            string avtionKey = null;
                            var actionKeyAttribue = methodInfo.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "KeyAttribute");
                            if (actionKeyAttribue != null)
                                avtionKey = actionKeyAttribue.ConstructorArguments[0].Value.ToString();
                            else
                                continue;
                            // Check if method has ChildActionOnlyAttribute
                            bool methodHasChildActionOnlyAttribute = methodInfo.CustomAttributes
                                .Any(c => c.AttributeType.Name == "ChildActionOnlyAttribute");
                            if (methodHasChildActionOnlyAttribute)
                            {
                                continue;
                            }

                            // Check for other attributes important to us
                            bool isAllowAnonymous = methodInfo.CustomAttributes.Any(c => c.AttributeType.Name == "AllowAnonymousAttribute");
                            var httpPostAttribute = methodInfo.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "HttpPostAttribute");
                            var actionNameAttribute = methodInfo.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "ActionNameAttribute");
                            bool actionRequiresAuthorization = methodInfo.CustomAttributes.Any(c => c.AttributeType.Name == "AuthorizeAttribute");
                            dontSideBarShow = methodInfo.CustomAttributes.Any(c => c.AttributeType.Name == "DontSideBarShowAttribute");

                            bool isHttpPost = httpPostAttribute != null;


                            // ActionNameAttribute could rename an action, if it's used, then use new name of action
                            string actionName = null;
                            if (actionNameAttribute != null)
                            {
                                actionName = actionNameAttribute.ConstructorArguments[0].Value.ToString();
                            }


                            string actionNameLocalized = null;
                            var actionTitle = methodInfo.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "TitleAttribute");
                            if (actionTitle != null) // if the class has this attribute, that means it's marked to ignore permission check
                            {
                                actionNameLocalized = actionTitle.ConstructorArguments[0].Value.ToString();
                            }

                            string actionIcon = null;
                            var displayIcon = methodInfo.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "IconAttribute");
                            if (displayIcon != null) // if the class has this attribute, that means it's marked to ignore permission check
                            {
                                actionIcon = displayIcon.ConstructorArguments[0].Value.ToString();
                            }

                            string actionUrl = null;
                            var existActionUrl = methodInfo.CustomAttributes.FirstOrDefault(c => c.AttributeType.Name == "UrlAttribute");
                            if (existActionUrl != null)
                            {
                                actionUrl = existActionUrl.ConstructorArguments[0].Value.ToString();
                            }

                            existActionKey.Add(avtionKey);
                            // Gather only methods with ActionResult return types:
                            //if (methodInfo.ReturnType.Name == "ActionResult")
                            //{
                            actions.Add(methodInfo.Name);
                            //if (!controllerData.ActionsList.Any(cd => cd.ActionName == (actionName ?? methodInfo.Name)))
                            {
                                if (controllerData.ActionsList == null)
                                    controllerData.ActionsList = new List<ActionData>();
                                controllerData.ActionsList.Add(new ActionData()
                                {
                                    CreationTime = DateTime.Now,
                                    ActionName = actionName ?? methodInfo.Name,
                                    ActionNameLocalized = actionNameLocalized,
                                    ActionIcon = actionIcon,
                                    AllowAnonymous = isAllowAnonymous,
                                    RequiresHttpPost = isHttpPost,
                                    RequiresAuthorization = actionRequiresAuthorization,
                                    Url = actionUrl,
                                    Key = avtionKey,
                                    DisplaySort = 0,
                                    TotalSeen = 1,
                                    IsDontSideBarShow = dontSideBarShow
                                });
                            }
                            //}
                        }
                        var dbController = await context.ControllerDatas.FirstOrDefaultAsync(c => c.Key == controllerData.Key);
                        if (dbController == null)
                        {
                            context.ControllerDatas.Add(controllerData);

                        }
                        else
                        {
                            // controller
                            dbController.ControllerName = controllerData.ControllerName;
                            dbController.ControllerNameLocalized = controllerData.ControllerNameLocalized;
                            dbController.ControllerNamespace = controllerData.ControllerNamespace;
                            dbController.ControllerName = controllerData.ControllerName;
                            dbController.RequiresAuthorization = controllerData.RequiresAuthorization;
                            dbController.IsDontSideBarShow = controllerData.IsDontSideBarShow;

                            context.ControllerDatas.Update(dbController);

                            // Actions 

                            foreach (ActionData action in controllerData.ActionsList)
                            {
                                var dbAction = await context.ActionDatas.FirstOrDefaultAsync(a => a.Key == action.Key);
                                if (dbAction == null)
                                {
                                    // add  Action
                                    action.ControllerDataId = dbController.Id;
                                    action.CreationTime = DateTime.Now;
                                    context.ActionDatas.Add(action);
                                }
                                else
                                {
                                    dbAction.ActionIcon = action.ActionIcon;
                                    dbAction.ActionName = action.ActionName;
                                    dbAction.ActionNameLocalized = action.ActionNameLocalized;
                                    dbAction.AllowAnonymous = action.AllowAnonymous;
                                    dbAction.RequiresAuthorization = action.RequiresAuthorization;
                                    dbAction.RequiresHttpPost = action.RequiresHttpPost;
                                    dbAction.IsDontSideBarShow = action.IsDontSideBarShow;

                                    context.ActionDatas.Update(dbAction);
                                }
                            }
                            // حذف اکشن های اضافی
                            // foreach (var dbaction in await context.ActionDatas.ToListAsync())
                            //     if (!controllerData.ActionsList.Any(a => a.Key == dbaction.Key))
                            //         context.ActionDatas.Remove(dbaction);
                        }
                        await context.SaveChangesAsync();
                    }
                }
            }
            // حذف اکشن های اضافه 
            var notUseActions = await context.ActionDatas.Where(ac => !existActionKey.Contains(ac.Key)).ToListAsync();
            notUseActions.ForEach(ac =>
            {
                context.Remove(ac);
            });
            await context.SaveChangesAsync();
        }
    }
}
