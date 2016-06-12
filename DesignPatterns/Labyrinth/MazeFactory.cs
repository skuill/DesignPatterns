
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Abstract Factory and Singleton pattern
    /// </summary>
    public class MazeFactory
    {
        // For example only. Instead of this use environment variables or another solution
        private static System.Type _mazeFactoryType;

        public static System.Type MazeFactoryType
        {
            set
            {
                if (_mazeFactoryType == null)
                {
                    _mazeFactoryType = value;
                }
            }
        }

        private static MazeFactory _instance;
        // Singleton pattern
        public static MazeFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    if (typeof(BombedMazeFactory) == _mazeFactoryType)
                    {
                        _instance = new BombedMazeFactory();
                    }
                    else if (typeof(EnchantedMazeFactory) == _mazeFactoryType)
                    {
                        _instance = new EnchantedMazeFactory();
                    }
                    else
                    {
                        _instance = new MazeFactory();
                    }
                }
                return _instance;
            }
        }

        protected MazeFactory() { }        

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            Door door = new Door();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
