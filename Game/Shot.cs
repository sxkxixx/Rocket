using System.Data.Common;

namespace Game
{
    public class RocketShot
    {
        public readonly Vector Location;
        public readonly int Power;

        public RocketShot(Vector location, int power)
        {
            Location = location;
            Power = power;
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