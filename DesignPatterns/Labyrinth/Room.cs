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
            // It's bad, but okay for example
            set
            {
                _roomNumber = value;
            }
        }

        public Room(int roomNo = int.MinValue)
        {
            _roomNumber = roomNo;
            _sides = new Dictionary<Direction, MapSite>();
        }

        protected Room(Room room)
        {
            _roomNumber = room._roomNumber;
            _sides = new Dictionary<Direction, MapSite>();
            if (room._sides != null)
            {
                foreach (var side in room._sides)
                {
                    _sides.Add(side.Key, (MapSite)side.Value.Clone());
                }
            }
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

        public override void Enter() { }

        public override object Clone()
        {
            return new Room(this);
        }
    }
}
