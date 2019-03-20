﻿using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace LanguageMentor.Web.Api.Configurations.ExceptionHandlerConfigurations
{
    public class PassthroughExceptionHandler : IExceptionHandler
    {
        public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            var info = ExceptionDispatchInfo.Capture(context.Exception);
            info.Throw();
            return Task.CompletedTask;
        }
    }
}