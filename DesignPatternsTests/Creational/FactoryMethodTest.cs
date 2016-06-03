using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Factory_Method;

namespace DesignPatternsTests.Creational
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void CreateProductWithFactoryMethodCreator1()
        {
            // Create concrete creator 1
            Creator creator = new ConcreteCreator1();
            // Create concrete creator 2
            //FactoryMethodTest.Creator creator = new FactoryMethodTest.ConcreteCreator2();

            // Build product (1, 2) using concrete creator (1, 2)
            Product product = creator.FactoryMethod();

            Assert.IsNotNull(product as ConcreteProduct1);
        }
    }
}
