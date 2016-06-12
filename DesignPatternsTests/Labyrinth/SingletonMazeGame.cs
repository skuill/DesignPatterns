using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Labyrinth;

namespace DesignPatternsTests.Labyrinth
{
    [TestClass]
    public class SingletonMazeGame
    {
        [TestMethod]
        public void CreateMazeFactorySingleton()
        {
            MazeFactory.MazeFactoryType = typeof(EnchantedMazeFactory);
            MazeFactory mazeFactory1 = MazeFactory.Instance;
            MazeFactory.MazeFactoryType = typeof(BombedMazeFactory);
            MazeFactory mazeFactory2 = MazeFactory.Instance;

            // AreEqual - Check equal type and value
            Assert.AreEqual(mazeFactory1, mazeFactory2);
            // AreSame - Check references indicated the same object in memory.
            Assert.AreSame(mazeFactory1, mazeFactory2);
        }
    }
}
