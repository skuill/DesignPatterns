using System;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatterns.Labyrinth
{
    public class Maze : ICloneable
    {
        private List<Room> rooms;

        public Maze()
        {
            rooms = new List<Room>();
        }

        protected Maze(Maze maze)
        {
            rooms = new List<Room>();
            foreach (var room in maze.rooms)
            {
                rooms.Add((Room)room.Clone());
            }
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room RoomNo(int roomNo)
        {
            return rooms.Where(x => x.RoomNumber == roomNo).FirstOrDefault();
        }

        public object Clone()
        {
            return new Maze(this);
        }
    }
}
