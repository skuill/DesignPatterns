
namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public AbstractProductA ProductA
        {
            get { return _productA; }
        }
        public AbstractProductB ProductB
        {
            get { return _productB; }
        }

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }
}
