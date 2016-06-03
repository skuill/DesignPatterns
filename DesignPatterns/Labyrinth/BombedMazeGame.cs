using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Factory Method pattern
    /// </summary>
    public class BombedMazeGame : MazeGame
    {
        public BombedMazeGame() { }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }
    }
}
