using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScriptSanitizer.Tests
{
    [TestClass]
    public class ScriptSantizeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ScriptSantizer.Sanitize("");
        }
    }
}
