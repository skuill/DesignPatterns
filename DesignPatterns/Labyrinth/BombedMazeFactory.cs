
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Abstract Factory pattern
    /// </summary>
    public class BombedMazeFactory : MazeFactory
    {
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
