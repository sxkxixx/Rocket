namespace Game
{
    public class Chest
    {
        private readonly Vector position;
        public readonly int Bullets = 2;

        public Chest(Asteroid asteroid)
        {
            position = asteroid.Position;
        }
    }
}