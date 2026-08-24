using NegoCity.Application.Exceptions;

namespace NegoCity.API.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(
             HttpContext context,
             Exception exception)
        {
            var statusCode = exception switch
            {
                BusinessAlreadyExistsException =>
                    StatusCodes.Status409Conflict, 
               _ => StatusCodes.Status500InternalServerError
            };

            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsJsonAsync(new
            {
                statusCode,
                message = exception.Message
            });
        }
    }
}