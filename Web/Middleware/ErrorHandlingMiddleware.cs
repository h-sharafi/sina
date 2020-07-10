using System;
using System.Net;
using System.Threading.Tasks;
using Application.Errors;
using Application.Service;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Persistence;

namespace Web.Middleware
{
    public class ErrorHandlingMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        //private readonly IErrorLogsService _errorLogsService;
        //private readonly ILoggingEventsService _loggingEventsService;
        //private readonly IuserService _userService;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger
           /* ,IErrorLogsService errorLogsService, ILoggingEventsService loggingEventsService, IuserService userService*/)
        {
            _logger = logger;
            //_errorLogsService = errorLogsService;
            //_loggingEventsService = loggingEventsService;
            //_userService = userService;
            _next = next;
        }

        public async Task Invoke(HttpContext context, DataContext db, IUserService userService, ILoggingEventServie loggingEventServie)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, _logger, db, userService, loggingEventServie);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex, ILogger<ErrorHandlingMiddleware> logger, DataContext db
            , IUserService userService, ILoggingEventServie loggingEventServie)
        {
            object errors = null;
            string typeOfError = string.Empty;
            switch (ex)
            {
                // چون این خطاها را خودمان تعریف کرده ایم پس خطاهای ناخواسته سیستم نمی باشند
                case RestException re:
                    logger.LogError(ex, "REST ERROR");
                    typeOfError = "REST ERROR";
                    errors = re.Errors;
                    context.Response.StatusCode = (int)re.Code;
                    break;
                //خطاهایی که خودمان تعریف نکردیم (خطاهای سیستم)
                case Exception e:
                    logger.LogError(ex, "SERVER ERROR");
                    typeOfError = "SERVER ERROR";
                    errors = string.IsNullOrWhiteSpace(e.Message) ? "Error" : e.Message + e.StackTrace;
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            context.Response.ContentType = "application/json";
            if (errors != null)
            {
                var result = JsonConvert.SerializeObject(new
                {
                    context.Response.StatusCode,
                    errors,
                    typeOfError
                });
                var curentUserId = await userService.CurentUserId();
                await loggingEventServie.Create(new LoggingEvent
                {
                    LogType = LogType.error,
                    DateTime = DateTime.Now,
                    AppUserId = curentUserId,
                    Result = result
                });
                await context.Response.WriteAsync(result);
            }
        }
    }
}