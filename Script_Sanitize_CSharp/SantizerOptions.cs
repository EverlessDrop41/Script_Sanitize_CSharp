using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptSanitizer
{
    public class SantizerOptions
    {
        public static SantizerOptions Default = new SantizerOptions();
        public bool loop = true;
        public bool replaceEndTagsAfter = true;
        public string replacementText = "";

        public string[] tags = { "script" };
        public string[] attributes = { "onmouseover" };

    }
}
