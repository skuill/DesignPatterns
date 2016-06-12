
namespace DesignPatterns.Creational.Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string prototypeInfo) : base(prototypeInfo) { }

        protected ConcretePrototype1(ConcretePrototype1 proto1) : base(proto1) { }

        // Simple way: shallow Copy 
        //public override object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        // True way: deep Copy with protected constructor
        public override object Clone()
        {
            return new ConcretePrototype1(this);
        }
    }
}
