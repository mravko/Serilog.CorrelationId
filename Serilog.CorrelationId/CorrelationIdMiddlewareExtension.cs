using Microsoft.AspNetCore.Builder;

namespace Serilog.CorrelationId
{
    public static class CorrelationIdMiddlewareExtension
    {
        /// <summary>
        /// Middleware that sets X-Correlation-ID.
        /// If it is present in request headers as X-Correlation-ID it will be taken from there
        /// Otherwise, it is auto-generated.
        /// </summary>
        /// <param name="builder"></param>
        public static void UseCorrelationId(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<CorrelationIdMiddleware>();
        }
    }
}


