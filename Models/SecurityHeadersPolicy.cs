using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Custom_Middleware.Models
{
    /// <summary>
    /// Building the SecurityHeaderMiddleware
    /// So now we know how to create and edit a piece of middleware, lets create one for ourselves! You can find a sample project containing the middleware on GitHub 
    /// but the key classes are discussed below, elided for brevity. 
    /// Refer https://github.com/andrewlock/blog-examples/tree/master/adding-default-security-headers
    /// First we have a SecurityHeadersPolicy object, which is a simple class containing a list of the headers to add and remove:
    /// </summary>
    public class SecurityHeadersPolicy
    {
        public IDictionary<string, string> SetHeaders { get; }
         = new Dictionary<string, string>();

        public ISet<string> RemoveHeaders { get; }
            = new HashSet<string>();
    }
}
