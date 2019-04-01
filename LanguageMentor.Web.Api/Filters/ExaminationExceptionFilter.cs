using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace LanguageMentor.Web.Api.Filters
{
    public class ExaminationExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is Exception)
            {
                context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}