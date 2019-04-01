using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace LanguageMentor.Web.Api.Configurations.ExceptionHandlerConfigurations
{
    public class LanguageMentorExceptionHandler : IExceptionHandler
    {
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            context.Result = new ResponseMessageResult(new HttpResponseMessage
            {
                Content = new StringContent("An unexpected error occurred"),
                StatusCode = HttpStatusCode.InternalServerError
            });

            return Task.FromResult(0);
        }
    }
}