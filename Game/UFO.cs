namespace Game
{
    public class Ufo
    {
        public readonly Vector Location;
        public readonly int HealthPoint;
        
        public bool IsDeath => HealthPoint == 0;
        
        public Ufo(Vector location, int healthPoint)
        {
            Location = location;
            HealthPoint = healthPoint;
        }
        
        
    }
}