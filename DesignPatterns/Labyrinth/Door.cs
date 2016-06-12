
namespace DesignPatterns.Labyrinth
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen;

        public Door() { }

        public void Initialize(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        protected Door(Door door)
        {
            _isOpen = door._isOpen;
            if (door._room1 != null)
            {
                _room1 = (Room)door._room1.Clone();
            }
            if (door._room2 != null)
            {
                _room2 = (Room)door._room2.Clone();
            }
        }

        public override void Enter() { }

        public Room OtherSideFrom(Room room)
        {
            return _room1 == room ? _room2 : _room2 == room ? _room1 : null;
        }

        public override object Clone()
        {
            return new Door(this);
        }
    }
}
