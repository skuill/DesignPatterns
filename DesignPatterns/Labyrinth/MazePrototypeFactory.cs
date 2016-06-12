
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Prototype pattern
    /// </summary>
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public MazePrototypeFactory(Maze maze, Room room, Wall wall, Door door) 
        {
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
            _prototypeDoor = door;
        }

        public virtual Maze MakeMaze()
        {
            return (Maze)_prototypeMaze.Clone();
        }

        public virtual Room MakeRoom(int roomNo)
        {
            Room room = (Room)_prototypeRoom.Clone();
            room.RoomNumber = roomNo; // Not good
            return room;
        }
        public virtual Wall MakeWall()
        {
            return (Wall)_prototypeWall.Clone();
        }
        public virtual Door MakeDoor(Room room1, Room room2)
        {
            Door door = (Door)_prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
