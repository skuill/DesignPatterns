using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Singleton;

namespace DesignPatternsTests.Creational
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void CreateSingleton()
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            // AreEqual - Check equal type and value
            Assert.AreEqual(s1, s2);
            // AreSame - Check references indicated the same object in memory.
            Assert.AreSame(s1, s2);
        }
    }
}
