using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Script_Sanitize_CSharp
{
    public static class SanitizerUtils
    {
        public static Regex GenerateRegexForTag(string tag)
        {
            var a = "<" + tag + "\\b[^<]*(?:(?!<\\/" + tag + ">)<[^<]*)*<\\/" + tag + "\\s*>";
            return new Regex(a, RegexOptions.Multiline & RegexOptions.IgnoreCase);
        }

        public static Regex GenerateRegexForEndTag(string tag)
        {
            var a = "<\\/" + tag + "\\s*>";
            return new Regex(a, RegexOptions.Multiline & RegexOptions.IgnoreCase);
        }

        public static Regex GenerateRegexAttribute(string attribute)
        {
            var a = attribute + "=(\"|\')[^\"\']*(\"|\')";
            return new Regex(a, RegexOptions.Multiline & RegexOptions.IgnoreCase);
        }
    }
}
