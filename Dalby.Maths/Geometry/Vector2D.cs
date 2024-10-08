﻿namespace Dalby.Maths.Geometry
{
    public record Vector2D(double X, double Y)
    {
        public double Dot(Vector2D other) => X * other.X + Y * other.Y;
        public double Cross(Vector2D other) => X * other.Y - Y * other.X;
        public double Abs() => Math.Sqrt(X * X + Y * Y);

        public static Vector2D operator +(Vector2D a, Vector2D b) => new(a.X + b.X, a.Y + b.Y);
        public static Vector2D operator -(Vector2D a, Vector2D b) => new(a.X - b.X, a.Y - b.Y);
        public static Vector2D operator *(Vector2D a, double factor) => new(a.X * factor, a.Y * factor);

    }
}