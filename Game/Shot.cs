using System.Data.Common;

namespace Game
{
    public class RocketShot
    {
        public readonly Vector Position;
        public readonly double MovingDirection;
        public readonly int Power;

        public RocketShot(Vector position, int power, double movingDirection)
        {
            Position = position;
            Power = power;
            MovingDirection = movingDirection;
        }
    }

    public class UfoShot
    {
        public readonly Vector Location;
        public readonly int Power;

        public UfoShot(Vector location, int power)
        {
            Location = location;
            Power = power;
        }

    }
}