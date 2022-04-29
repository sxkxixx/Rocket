using System;

namespace Game
{
    public class Vector
    {
        public readonly double X;
        public readonly double Y;

        public double Length => Math.Sqrt(X * X + Y * Y);
        public double Angle => Math.Atan2(Y, X);

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
        
        protected bool Equals(Vector other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector)obj);
        }
        
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        public static Vector operator *(Vector a, double k)
        {
            return new Vector(a.X * k, a.Y * k);
        }

        public static Vector operator /(Vector a, double k)
        {
            return new Vector(a.X / k, a.Y / k);
        }

        public static Vector operator *(double k, Vector a)
        {
            return a * k;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
    }
}