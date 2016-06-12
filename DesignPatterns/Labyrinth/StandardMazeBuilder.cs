
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Builder pattern
    /// </summary>
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override void BuilRoom(int roomNo)
        {
            if (_currentMaze.RoomNo(roomNo) == null)
            {
                Room room = new Room(roomNo);
                _currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public override void BuildDoor(int roomNo1, int roomNo2)
        {
            Room room1 = _currentMaze.RoomNo(roomNo1);
            Room room2 = _currentMaze.RoomNo(roomNo2);
            Door door = new Door();
            door.Initialize(room1, room2);

            room1.SetSide(CommonWall(room1, room2), door);
            room2.SetSide(CommonWall(room2, room1), door);
        }

        // TO DO: return true Direction for each room
        private Direction CommonWall(Room room1, Room room2)
        {
            return Direction.East;
        }

        public override Maze GetMaze()
        {
            return _currentMaze;
        }
    }
}
