using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ASP.NET_Core_Custom_Middleware.Models;

namespace ASP.NET_Core_Custom_Middleware.Models
{
    /// <summary>
    /// A middleware class is just a standard class, it does not implement an interface as such, but it must conform to a certain shape in order to be successfully called at runtime:
    /// So this class will be passed a RequestDelegate in the constructor, which is a pointer to the next piece of middleware in the pipeline. When a request is made to the server, 
    /// the first piece of middleware registered in Startup.cs is called using Invoke and passed the context. When a piece of middleware finishes processing, it then directly invokes 
    /// the next piece of middleware in the chain until a response is returned. 
    /// It is worth noting that you are free to pass additional services and objects required to process the request in to the constructor of your middleware class - 
    /// these will be automatically found and instantiated using dependency injection.
    /// </summary>
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
        }
    }

    /// <summary>
    /// Registering the middleware in Startup
    /// The current standard approach to registering middleware in Startup is to create an extension method on IApplicationBuilder that registers the correct class. 
    /// If you have additional configuration required to create the middleware, it is suggested to create an overload which takes a Builder object or configuration class. 
    /// Note that it is no longer considered best practice to create an extension method which takes a delegate.
    /// Refer: https://devblogs.microsoft.com/aspnet/notes-from-the-asp-net-community-standup-april-26-2016/
    /// </summary>
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app, SecurityHeadersBuilder builder)
        {
            //In the Invoke method, the headers we have registered are set on the output, and the headers we wish to remove are removed.
            //It's important to note here that we are overwriting the header values in the response with the values we provide,
            //so if a header has already been set in a previous piece of middleware, it will have our new value. It is also worth noting that
            //we cannot remove headers which have not yet been added to the response. This means that the IIS header modification discussed at the beginning of the post has the last word!
            //So next we have the extension method to register our middleware:
            SecurityHeadersPolicy policy = builder.Build();
            return app.UseMiddleware<CustomMiddleware>();
        }
    }

}
