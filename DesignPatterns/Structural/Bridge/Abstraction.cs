
namespace DesignPatterns.Structural.Bridge
{
    public class Abstraction
    {
        protected Implementor _imp;

        public Implementor Imp
        {
            set { _imp = value; }
        }

        public virtual string Operation()
        {
            return _imp.OperationImp();
        }
    }
}
