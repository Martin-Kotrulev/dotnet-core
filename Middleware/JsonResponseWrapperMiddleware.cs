using Microsoft.AspNetCore.Http;

namespace vega.Middleware
{
    public class JsonResponseWrapper
    {
        private readonly RequestDelegate _next;
    }
}