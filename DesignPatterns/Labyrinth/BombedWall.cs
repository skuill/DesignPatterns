
namespace DesignPatterns.Labyrinth
{
    public class BombedWall : Wall
    {
        private bool _hasBombed;

        public BombedWall(bool hasBombed = false)
        {
            _hasBombed = hasBombed;
        }

        protected BombedWall(BombedWall wall) : base(wall)
        {
            _hasBombed = wall._hasBombed;
        }

        public override object Clone()
        {
            return new BombedWall(this);
        }
    }
}
