using System.Collections.Generic;

namespace Game
{
    public class Level
    {
        private readonly string name;
        public readonly Rocket rocket;
        public readonly List<Ufo> opponents;
        

        public Level(string name, Rocket rocket, List<Ufo> opponents)
        {
            this.name = name;
            this.rocket = rocket;
            this.opponents = opponents;
        }
    }
}