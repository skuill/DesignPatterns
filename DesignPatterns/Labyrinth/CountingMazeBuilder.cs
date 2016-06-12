
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Builder pattern
    /// </summary>
    public class CountingMazeBuilder : MazeBuilder
    {
        private int _roomsCount;
        private int _doorsCount;

        public CountingMazeBuilder()
        {
            _roomsCount = _doorsCount = 0;
        }

        public override void BuilRoom(int roomNo)
        {
            _roomsCount++;
        }

        public override void BuildDoor(int roomNo1, int roomNo2)
        {
            _doorsCount++;
        }

        public override void BuildMaze() { }

        public override Maze GetMaze()
        {
            return null;
        }

        public void GetCounts(ref int roomsCount, ref int doorsCount)
        {
            roomsCount = _roomsCount;
            doorsCount = _doorsCount;
        }
    }
}
