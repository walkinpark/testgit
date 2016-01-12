using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace $rootnamespace$
{
    // You may need to install the Microsoft.AspNet.Http.Abstractions package into your project
    public class $safeitemname$
    {
        private readonly RequestDelegate _next;

        public $safeitemname$(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class $safeitemname$Extensions
    {
        public static IApplicationBuilder Use$safeitemname$(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<$safeitemname$>();
        }
    }
}
