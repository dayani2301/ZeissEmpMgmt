using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;

namespace ZeissEmpMgmt.Filter
{
    public class LogActionFilterAttribute : ActionFilterAttribute, IActionFilter
    {

        private const string ResponseTimeKey = "ResponseTimeKey";
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Items[ResponseTimeKey] = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Stopwatch stopwatch = (Stopwatch)filterContext.HttpContext.Items[ResponseTimeKey];

            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
