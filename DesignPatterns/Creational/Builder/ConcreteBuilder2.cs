
namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder2 : Builder
    {
        Product _product;

        public ConcreteBuilder2()
        {
            _product = new Product();
        }

        public override void BuildPartA()
        {
            _product.AddPart("Goodbye");
        }

        public override void BuildPartB()
        {
            _product.AddPart("Sweety");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
