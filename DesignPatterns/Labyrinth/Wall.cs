
namespace DesignPatterns.Labyrinth
{
    public class Wall : MapSite
    {
        public Wall() { }

        protected Wall(Wall wall) { }

        public override void Enter() { }

        public override object Clone()
        {
            return new Wall(this);
        }
    }
}
