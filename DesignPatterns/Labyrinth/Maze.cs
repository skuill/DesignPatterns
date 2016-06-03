using System.Linq;
using System.Collections.Generic;

namespace DesignPatterns.Labyrinth
{
    public class Maze
    {
        private List<Room> rooms;

        public Maze()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room RoomNo(int roomNo)
        {
            return rooms.Where(x => x.RoomNumber == roomNo).FirstOrDefault();
        }
    }
}
