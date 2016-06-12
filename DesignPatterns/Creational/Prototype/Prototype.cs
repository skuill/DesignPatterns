using System;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Prototype : ICloneable 
    {
        private string _prototypeInfo;

        public string PrototypeInfo
        {
            get { return _prototypeInfo; }
        }

        public Prototype(string prototypeInfo)
        {
            _prototypeInfo = prototypeInfo;
        }

        protected Prototype(Prototype proto)
        {
            _prototypeInfo = proto._prototypeInfo;
        }

        public abstract object Clone();
    }
}
