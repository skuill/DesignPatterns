using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Labyrinth
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public override void Enter()
        {

        }

        public EnchantedRoom(int roomNo, Spell spell) : base(roomNo)
        {
            _spell = spell;
        }
    }
}
