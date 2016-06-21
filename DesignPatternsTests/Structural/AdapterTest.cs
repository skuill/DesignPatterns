using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Adapter;

namespace DesignPatternsTests.Structural
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestAdapterRequest()
        {
            // Create adapter
            Target target = new Adapter();
            // Take a request
            string result = target.Request();

            Assert.AreEqual(result, "Adaptee specific request");
        }
    }
}
