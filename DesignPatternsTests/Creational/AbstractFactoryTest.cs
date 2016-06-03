using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatternsTests.Creational
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void CreateClientWithAbstractFactory1()
        {
            // Create factory No 1
            AbstractFactory factory = new ConcreteFactory1();
            // Create factory No 2
            //AbstractFactoryTest.AbstractFactory factory = new AbstractFactoryTest.ConcreteFactory2();

            // Build Client
            Client client = new Client(factory);
            
            Assert.IsNotNull(client.ProductA as ProductA1);
        }
    }
}
