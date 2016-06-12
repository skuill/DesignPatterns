
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Factory Method pattern
    /// </summary>
    public class EnchantedMazeGame : MazeGame
    {
        public EnchantedMazeGame() { }

        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, new Spell("Builder KABOOM"));
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }
    }
}
