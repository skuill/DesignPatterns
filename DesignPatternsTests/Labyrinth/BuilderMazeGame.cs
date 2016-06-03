using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Labyrinth;

namespace DesignPatternsTests.Labyrinth
{
    [TestClass]
    public class BuilderMazeGame
    {
        [TestMethod]
        public void CreateStandartMazeGameBuilder()
        {
            MazeGame game = new MazeGame();
            MazeBuilder builder;
            Maze maze;

            // Configure standard maze builder
            builder = new StandardMazeBuilder();
            maze = game.CreateMazeBuilder(builder);

            Assert.IsNotNull(maze.RoomNo(1));
            Assert.IsNotNull(maze.RoomNo(2));
        }

        [TestMethod]
        public void CreateCountingMazeGameBuilder()
        {
            MazeGame game = new MazeGame();
            MazeBuilder builder = new CountingMazeBuilder();
            int roomsCount = 0, doorsCount = 0;

            Maze maze = game.CreateMazeBuilder(builder);
            ((CountingMazeBuilder)builder).GetCounts(ref roomsCount, ref doorsCount);

            Assert.AreEqual(roomsCount, 2);
            Assert.AreEqual(doorsCount, 1);
        }
    }
}
