using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Prototype
    {
        private string _prototypeInfo;

        public string PrototypeInfo { get { return _prototypeInfo; } }

        public Prototype(string prototypeInfo)
        {
            _prototypeInfo = prototypeInfo;
        }

        public abstract Prototype Clone();
    }
}
