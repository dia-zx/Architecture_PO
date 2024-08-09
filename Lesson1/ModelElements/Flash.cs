
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.ModelElements
{
    internal class Flash
    {
        public Point3D Location { get; set; }
        public Angle3D Angle { get; set; }
        public Color Color { get; set; }
        public float Power { get; set; }

        public void Rotate(Angle3D angle)
        {
            Console.WriteLine($"Flash Rotate({angle})");
        }
        public void Move(Point3D point)
        {
            Console.WriteLine($"Flash Move({point})");
        }
    }
}
