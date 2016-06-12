using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Labyrinth;

namespace DesignPatternsTests.Labyrinth
{
    [TestClass]
    public class PrototypeMazeGame
    {
        [TestMethod]
        public void CreateBombedMazeGamePrototype()
        {
            MazeGame game = new MazeGame();
            MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(new Maze(), new RoomWithABomb(), new BombedWall(), new Door());
            Maze maze = game.CreateMazePrototype(bombedMazeFactory);
            Assert.IsNotNull(maze.RoomNo(1) as RoomWithABomb);
            Assert.IsInstanceOfType(maze.RoomNo(1).GetSide(Direction.North), typeof(BombedWall));
            Assert.IsNotInstanceOfType(maze.RoomNo(2), typeof(EnchantedRoom));
        }
    }
}
