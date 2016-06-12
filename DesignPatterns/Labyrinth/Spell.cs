
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
