
namespace DesignPatterns.Labyrinth
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int roomNo = int.MinValue) : base(roomNo) { }

        protected RoomWithABomb(RoomWithABomb room) : base(room) { }

        public override object Clone()
        {
            return new RoomWithABomb(this);
        }
    }
}
