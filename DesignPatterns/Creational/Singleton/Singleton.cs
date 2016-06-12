using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        protected Singleton() { }

        private static Singleton _instance;
        
        public static Singleton Instance
        {
            get
            {
                // Use lazy initialization
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
