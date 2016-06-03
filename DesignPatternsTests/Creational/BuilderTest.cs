using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Builder;

namespace DesignPatternsTests.Creational
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void CreateProductWithBuilder1()
        {
            // Create concrete builder No 1
            Builder builder = new ConcreteBuilder1();
            // Create concrete builder No 2
            //BuilderTest.Builder builder = new BuilderTest.ConcreteBuilder2();

            // Configure Director with builder
            Director director = new Director(builder);

            // Construct Product from Director
            director.Construct();

            // Get result
            Product product = builder.GetResult();
            Assert.AreEqual(product.ToString(), "Hello World");
        }
    }
}
