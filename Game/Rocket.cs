namespace Game
{
    public class Rocket
    {
        public readonly Vector Location;
        public readonly int HealthPoint;

        public bool IsDeath => HealthPoint == 0;

        public Rocket(Vector location, int healthPoint)
        {
            Location = location;
            HealthPoint = healthPoint;
        }
    }
}