using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public AbstractProductA ProductA { get { return _productA; } }
        public AbstractProductB ProductB { get { return _productB; } }

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }
}
