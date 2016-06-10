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

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.X - vec2.X, vec1.Y - vec2.Y);
        }

        public static Vector operator *(Vector vec1, float s)
        {
            return new Vector(vec1.X * s, vec1.Y * s);
        }

        public static Vector operator /(Vector vec1, float s)
        {
            return new Vector(vec1.X / s, vec1.Y / s);
        }
    }
}
