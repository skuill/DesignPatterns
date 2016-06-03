using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Product
    {
        List<object> _parts;

        public Product()
        {
            _parts = new List<object>();
        }

        public void AddPart(object part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            return string.Join(" ", _parts.ToArray());
        }
    }
}
