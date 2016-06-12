
namespace DesignPatterns.Creational.Factory_Method
{
    public class ConcreteCreator2 : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
