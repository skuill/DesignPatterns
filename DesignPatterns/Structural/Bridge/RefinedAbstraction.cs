
namespace DesignPatterns.Structural.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public override string Operation()
        {
            return _imp.OperationImp();
        }
    }
}
