using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhPract.core.math
{
    public class Vector
    {
        private const float TOL = 0.001f;

        public float X;
        public float Y;

        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public void Normalize()
        {
            float m = (float)Math.Sqrt(X * X + Y * Y);
            if (m <= TOL) m = 1;
            X /= m;
            Y /= m;

            if (Math.Abs(X) < TOL) X = 0.0f;
            if (Math.Abs(Y) < TOL) Y = 0.0f;
        }

        public void Reverse()
        {
            X = -X;
            Y = -Y;
        }

        public static Vector operator +(Vector u, Vector v)
        {
            return new Vector(u.X + v.X, u.Y + v.Y);
        }

        public static Vector operator -(Vector u, Vector v)
        {
            return new Vector(u.X - v.X, u.Y - v.Y);
        }

        public static Vector operator *(Vector u, float s)
        {
            return new Vector(u.X * s, u.Y * s);
        }

        public static Vector operator *(float s, Vector u)
        {
            return new Vector(u.X * s, u.Y * s);
        }

        public static Vector operator /(Vector u, float s)
        {
            return new Vector(u.X / s, u.Y / s);
        }

        public static float operator ^(Vector u, Vector v)
        {
            return u.X * v.Y - u.Y * v.X;
        }

        public static float operator *(Vector u, Vector v)
        {
            return u.X * v.X + u.Y * v.Y;
        }
    }
}
