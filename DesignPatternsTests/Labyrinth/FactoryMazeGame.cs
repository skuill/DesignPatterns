using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Labyrinth;

namespace DesignPatternsTests.Labyrinth
{
    [TestClass]
    public class FactoryMazeGame
    {
        [TestMethod]
        public void CreateBombedMazeGameFactory()
        {
            MazeGame game = new BombedMazeGame();
            Maze maze = game.CreateMazeFactoryMethod();

            Assert.IsNotNull(maze.RoomNo(1) as RoomWithABomb);
            Assert.IsNotInstanceOfType(maze.RoomNo(2), typeof(EnchantedRoom));
        }
    }
}
