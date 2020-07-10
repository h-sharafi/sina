using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Persistence;

namespace Web.Middleware
{
    public class RouteMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly IErrorLogsService _errorLogsService;
        //private readonly ILoggingEventsService _loggingEventsService;
        //private readonly IUserAccessor _userAccessor;

        public RouteMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, DataContext db)
        {
            var request = context.Request;
            var path = context.Request.Path.Value;
            string controller = string.Empty;
            string action = string.Empty;
            try
            {



                if (path.ToLower().Contains("managment"))
                {
                    var result = path.Split('/');
                    if (result.Length == 2)
                    {
                        controller = "Home";
                        action = "Inedx";
                    }
                    else if (result.Length == 3)
                    {
                        controller = path.Split('/')[2];
                        action = "Inedx";
                    }
                    else if (result.Length > 3)
                    {
                        controller = path.Split('/')[2];
                        action = path.Split('/')[3];
                    }
                }
                else
                {
                    if (path == "/" || path == "/favicon.ico") controller = "Home";
                    var result = path.Split('/');
                    if (result.Length == 1)
                    {
                        controller = "Home";
                        action = "Inedx";
                    }
                    else if (result.Length == 2)
                    {
                        controller = path.Split('/')[1];
                        action = "Inedx";
                    }
                    else if (result.Length > 2)
                    {
                        controller = path.Split('/')[1];
                        action = path.Split('/')[2];
                    }
                }


            }
            catch (Exception)
            {
                controller = "Home";
            }

            var method = context.Request.Method;
            var user = context.User.Identity.IsAuthenticated;
            var QueryString = context.Request.QueryString;
            //try
            {
                await _next(context);
            }
        }
    }
}