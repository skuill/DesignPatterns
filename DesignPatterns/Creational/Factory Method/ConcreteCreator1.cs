using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    public class ConcreteCreator1 : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
