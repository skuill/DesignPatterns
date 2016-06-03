
namespace DesignPatterns.Labyrinth
{
    public class Room : MapSite
    {
        private int _roomNumber;
        private MapSite[] _sides = new MapSite[4];

        public Room(int roomNo)
        {
        }

        public MapSite GetSide(Direction direction)
        {
            return null;
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
        }

        public override void Enter()
        {

        }
    }
}
