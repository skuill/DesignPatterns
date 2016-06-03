using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder1 : Builder
    {
        Product _product;

        public ConcreteBuilder1()
        {
            _product = new Product();
        }

        public override void BuildPartA()
        {
            _product.AddPart("Hello");            
        }

        public override void BuildPartB()
        {
            _product.AddPart("World");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
