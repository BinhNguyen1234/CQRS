using MassTransit.RetryPolicies.ExceptionFilters;

namespace CQRS.Middleware
{
    public class HandleGlobalException
    {
        private readonly RequestDelegate _next;

        public HandleGlobalException(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                //TODO: finish this
                await HandleExceptionFilter(httpContext, e);
            }
        }

        private async Task HandleExceptionFilter(HttpContext httpContext, Exception exception) 
        {
            httpContext.Response.StatusCode = 500;
            await httpContext.Response.WriteAsync("Error");
        }
    }
}
