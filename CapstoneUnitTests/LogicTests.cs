using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneUnitTests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void TestHash_success()
        {
            // create expected string, sha1 hash of 'hashtest'
            const string Expected = "09EAD097096895457E676D5C776AC455B4593DD0";

            var result = Backend_Logic.Utils.GetSha1("hashtest");

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void TestHash_fail()
        {
            // create expected string, sha1 hash of 'hashtest'
            const string Expected = "09EAD097096895457E676D5C776AC455B4593DD0";

            var result = Backend_Logic.Utils.GetSha1("nothashtest");

            Assert.AreNotEqual(Expected, result);
        }
    }
}
