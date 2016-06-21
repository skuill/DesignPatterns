
namespace DesignPatterns.Structural.Adapter
{
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override string Request()
        {
            return _adaptee.SpecificRequest();
        }
    }
}
