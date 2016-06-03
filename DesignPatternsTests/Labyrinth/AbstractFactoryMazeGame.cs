using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Labyrinth;

namespace DesignPatternsTests.Labyrinth
{
    [TestClass]
    public class AbstractFactoryMazeGame
    {
        [TestMethod]
        public void CreateBombedMazeGameAbstractFactory()
        {
            MazeGame game = new MazeGame();
            // Create bombed factory
            MazeFactory factory = new BombedMazeFactory();
            // Create enchanted factory
            //LabyrinthTest.MazeFactory factory = new LabyrinthTest.EnchantedMazeFactory();

            // Create maze with bombed or enchanted room
            Maze abstractFactoryMaze = game.CreateMazeAbstractFactory(factory);
            Assert.IsNotNull(abstractFactoryMaze.RoomNo(1) as RoomWithABomb);
            Assert.IsNotNull(abstractFactoryMaze.RoomNo(2) as RoomWithABomb);

            Room r1 = abstractFactoryMaze.RoomNo(1);

            Assert.IsNotNull(r1.GetSide(Direction.North) as BombedWall);
        }
    }
}
