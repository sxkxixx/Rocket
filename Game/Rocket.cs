namespace Game
{
    public class Rocket
    {
        public readonly Vector Position;
        private readonly Vector velocity;
        public readonly double Direction;
        private readonly int HealthPoint = 100;
        private readonly int bullet;
        
        public bool IsDeath => HealthPoint == 0;

        public Rocket(Vector position, Vector velocity, double direction, int bullet)
        {
            Position = position;
            this.velocity = velocity;
            Direction = direction;
            this.bullet = bullet;
        }
    }
}