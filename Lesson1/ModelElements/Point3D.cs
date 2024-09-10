namespace Lesson1.ModelElements
{
    public readonly struct Point3D
    {
        public Point3D(double X, double Y, double Z)
        {
            this.X = X; this.Y = Y; this.Z = Z;
        }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
    }
}