using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script_Sanitize_CSharp
{
    public class SantizerOptions
    {
        public bool loop = true;
        public bool replaceEndTagsAfter = true;
        public string replacementText = "";

        public string[] tags = { "script" };
        public string[] attributes = { "onmouseover" };

    }
}
