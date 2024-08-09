namespace Lesson1.ModelElements
{
    public struct Angle3D
    {
        public Angle3D(double aX, double aY, double aZ)
        {
            this.AngleX = aX; this.AngleY = aY; this.AngleZ = aZ;
        }
        public double AngleX { get; }
        public double AngleY { get; }
        public double AngleZ { get; }
    }
}