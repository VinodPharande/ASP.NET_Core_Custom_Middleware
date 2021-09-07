using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Custom_Middleware.Constants
{
    /// <summary>
    /// X-Content-Type-Options-related constants.
    /// </summary>
    public static class ContentTypeOptionsConstants
    {
        /// <summary>
        /// Header value for X-Content-Type-Options
        /// </summary>
        public static readonly string Header = "X-Content-Type-Options";

        /// <summary>
        /// Disables content sniffing
        /// </summary>
        public static readonly string NoSniff = "nosniff";

    }
}
