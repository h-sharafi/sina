using System.Collections.Generic;
using Domain.ViewModels.Public;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VestaEShop.Web.Areas.Management.Controllers
{
    [Area("Managment")]
    [Authorize(Roles = "Administrator")]
    public partial class ManagementController : Controller
    {
        public void Success(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Success, message, dismissable);
        }

        public void Information(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Information, message, dismissable);
        }

        public void Warning(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Warning, message, dismissable);
        }

        public void Danger(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Danger, message, dismissable);
        }

        private void AddAlert(string alertStyle, string message, bool dismissable)
        {
            var alerts = TempData.Keys.Contains(Alert.TempDataKey)
                ? JsonConvert.DeserializeObject<List<Alert>>((string)TempData[Alert.TempDataKey])
                : new List<Alert>();
                
            alerts.Add(new Alert
            {
                AlertStyle = alertStyle,
                Message = message,
                Dismissable = dismissable
            });

            TempData[Alert.TempDataKey] = JsonConvert.SerializeObject(alerts);
        }
    }
}