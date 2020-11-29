using Microsoft.AspNetCore.Builder;

namespace RequestResponseLoggerMiddleware
{
    public static class CustomMiddlewareExtensions
    {
        public static void UseRequestResponseLogging(this IApplicationBuilder app) => app.UseMiddleware<RequestResponseLoggerMiddleware>();
    }
}
