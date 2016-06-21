using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Bridge;

namespace DesignPatternsTests.Structural
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void CallBridgeConcreteImplementor()
        {
            Abstraction abstraction = new RefinedAbstraction();
            
            // Set implementation
            abstraction.Imp = new ConcreteImplementorA();
            // Call operation
            string result = abstraction.Operation();

            Assert.AreEqual(result, "ConcreteImplementorA");
        }
    }
}
