namespace Game
{
    public class Ufo
    {
        public readonly Vector Position;
        public readonly Vector Velocity;
        public readonly double Direction;
        public readonly int HealthPoint = 50;
        private readonly int Bullet = int.MaxValue;
        
        public bool IsDeath => HealthPoint == 0;

        public Ufo(Vector position, Vector velocity, double direction)
        {
            Position = position;
            Velocity = velocity;
            Direction = direction;
        }
    }
}