
namespace DesignPatterns.Labyrinth
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public override void Enter() { }

        public EnchantedRoom(int roomNo, Spell spell) : base(roomNo)
        {
            _spell = spell;
        }
    }
}
