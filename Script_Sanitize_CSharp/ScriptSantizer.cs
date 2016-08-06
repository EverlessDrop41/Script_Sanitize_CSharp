using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Sanitize_CSharp
{
    public static class ScriptSantizer
    {
        /// <summary>
        /// Removes dangerous tags and attributes from html to prevent against xss. 
        /// Creates a default options parameter
        /// </summary>
        /// <param name="html">The content to be sanitzed</param>
        /// <returns>Sanitized html</returns>
        public static string Sanitize(string html)
        {
            return Sanitize(html, new SantizerOptions());
        }

        /// <summary>
        /// Removes dangerous tags and attributes from html to prevent against xss
        /// </summary>
        /// <param name="html">The content to be sanitzed</param>
        /// <param name="options">The sanitization options</param>
        /// <returns>Sanitized html</returns>
        public static string Sanitize(string html, SantizerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
