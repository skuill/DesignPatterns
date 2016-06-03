
namespace DesignPatterns.Labyrinth
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2; 
        }

        public override void Enter()
        {

        }

        public Room OtherSideFrom(Room room)
        {
            return _room1 == room ? _room2 : _room2 == room ? _room1 : null;
        }
    }
}
