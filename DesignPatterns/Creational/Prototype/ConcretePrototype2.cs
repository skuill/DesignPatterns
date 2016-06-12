
namespace DesignPatterns.Creational.Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string prototypeInfo) : base(prototypeInfo) { }

        protected ConcretePrototype2(ConcretePrototype2 proto2) : base(proto2) { }

        // Simple way: shallow Copy 
        //public override object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        // True way: deep Copy with protected constructor
        public override object Clone()
        {
            return new ConcretePrototype2(this);
        }
    }
}
