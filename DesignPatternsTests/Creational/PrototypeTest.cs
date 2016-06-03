using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Prototype;

namespace DesignPatternsTests.Creational
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void CreatePrototype1()
        {
            Prototype proto1 = new ConcretePrototype1("Prototype 1");
            Prototype proto1Copy = proto1.Clone();

            Assert.IsInstanceOfType(proto1Copy, typeof(ConcretePrototype1));
            Assert.AreEqual(proto1.PrototypeInfo, proto1Copy.PrototypeInfo);
        }
    }
}
