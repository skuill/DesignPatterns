using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Labyrinth;

namespace DesignPatternsTests.Labyrinth
{
    [TestClass]
    public class SimpleMazeGame
    {
        [TestMethod]
        public void CreateMazeGameSimple()
        {
            MazeGame game = new MazeGame();
            Maze simpleMaze = game.CreateMazeSimple();

            Assert.IsNotNull(simpleMaze.RoomNo(1));
            Assert.IsNotNull(simpleMaze.RoomNo(2));
            Assert.IsNull(simpleMaze.RoomNo(4));

            Room r1 = simpleMaze.RoomNo(1);
            Room r2 = simpleMaze.RoomNo(2);

            Assert.IsNotNull(r1.GetSide(Direction.East) as Door);
            Assert.IsNotNull(r2.GetSide(Direction.West) as Door);            
        }
    }
}
