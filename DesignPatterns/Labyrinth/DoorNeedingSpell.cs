using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Labyrinth
{
    public class DoorNeedingSpell : Door
    {
        private bool _hasSpell; 

        public DoorNeedingSpell(Room r1, Room r2, bool hasSpell = false)
        {
            Initialize(r1, r2);
            _hasSpell = hasSpell;
        }
    }
}
