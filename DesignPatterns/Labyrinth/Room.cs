using System.Collections.Generic;

namespace DesignPatterns.Labyrinth
{
    public class Room : MapSite
    {
        private int _roomNumber;
        private Dictionary<Direction, MapSite> _sides;

        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
        }

        public Room(int roomNo)
        {
            _roomNumber = roomNo;
            _sides = new Dictionary<Direction, MapSite>();
        }

        public MapSite GetSide(Direction direction)
        {
            if (_sides.ContainsKey(direction))
            {
                return _sides[direction];
            }
            else
            {
                return null;
            }
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            if (!_sides.ContainsKey(direction))
            {
                _sides.Add(direction, mapSite);
            }
            else
            {
                _sides[direction] = mapSite;
            }
        }

        public override void Enter()
        {

        }
    }
}
