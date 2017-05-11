using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using ClassLibrary1;
using WebApi.StructureMap;

namespace WebApplicationStructureMap
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SomeFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //actionContext.

            var l = actionContext.GetService<ILogger>();
            l.W("OnActionExecuting");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var s = actionExecutedContext.GetService<ISingle>();

            int c = s.Calc();

            var l = actionExecutedContext.GetService<ILogger>();
            l.W("OnActionExecuted");

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}