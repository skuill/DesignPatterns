using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Labyrinth
{
    public class BombedWall : Wall
    {
        private bool _hasBombed;

        public BombedWall(bool hasBombed = false)
        {
            _hasBombed = hasBombed;
        }
    }
}
