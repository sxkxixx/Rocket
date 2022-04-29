namespace Game
{
    public class Asteroid
    {
        public readonly Vector Position;
        public static readonly int HealthPoint = 20;

        public Asteroid(Vector location)
        {
            Position = location;
        }
    }
}