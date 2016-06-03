using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Labyrinth
{
    public class Spell
    {
        private string _spellText;

        public Spell(string spellText = "")
        {
            _spellText = spellText;
        }

        public string CastSpell()
        {
            return _spellText;
        }
    }
}
