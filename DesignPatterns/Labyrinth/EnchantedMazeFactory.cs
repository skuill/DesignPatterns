using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Abstract Factory pattern
    /// </summary>
    public class EnchantedMazeFactory : MazeFactory
    {
        public EnchantedMazeFactory() { }

        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, new Spell("Abra Kadabra"));            
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2, true);
        }
    }
}
