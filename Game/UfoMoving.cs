using System;

namespace Game
{
    public class UfoMoving
    {
        public static Turn Rotate(Ufo opponent, Rocket rocket)
        {
            var rocketPosition = rocket.Position;
            var distance = rocketPosition - opponent.Position;
            var angle = distance.Angle - (opponent.Velocity.Angle + opponent.Direction) / 2;
            if (Math.Abs(angle) > Math.PI / 8)
                angle = distance.Angle - rocket.Direction;
            if (angle < - Math.PI / 100)
                return Turn.Left;
            if (angle > Math.PI / 100)
                return Turn.Right;
            return Turn.None;
        }
    }
}