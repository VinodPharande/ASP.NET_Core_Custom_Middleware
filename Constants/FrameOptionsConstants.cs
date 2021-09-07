using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Custom_Middleware.Constants
{
    /// <summary>
    /// X-Frame-Options-related constants.
    /// </summary>
    public static class FrameOptionsConstants
    {
        /// <summary>
        /// The header value for X-Frame-Options
        /// </summary>
        public static readonly string Header = "X-Frame-Options";

        /// <summary>
        /// The page cannot be displayed in a frame, regardless of the site attempting to do so.
        /// </summary>
        public static readonly string Deny = "DENY";

        /// <summary>
        /// The page can only be displayed in a frame on the same origin as the page itself.
        /// </summary>
        public static readonly string SameOrigin = "SAMEORIGIN";

        /// <summary>
        /// The page can only be displayed in a frame on the specified origin. {0} specifies the format string
        /// </summary>
        public static readonly string AllowFromUri = "ALLOW-FROM {0}";

        ///// <summary>
        ///// Cache-Control - Cache-Control
        ///// </summary>
        //public static readonly string CacheControl = "no-store";

        ///// <summary>
        ///// Content-Security-Policy - Content-Security-Policy
        ///// </summary>
        //public static readonly string ContentSecurityPolicy = "default-src 'self'";

        ///// <summary>
        ///// Strict-Transport-Security - Strict-Transport-Security
        ///// </summary>
        //public static readonly string StrictTransportSecurity = "max-age=31536000";

        ///// <summary>
        ///// X-Content-Type-Options - X-Content-Type-Options
        ///// </summary>
        //public static readonly string XContentTypeOptions = "nosniff";

        ///// <summary>
        ///// X-Frame-Options - X-Frame-Options
        ///// </summary>
        //public static readonly string XFrameOptions = "DENY";

    }
}
