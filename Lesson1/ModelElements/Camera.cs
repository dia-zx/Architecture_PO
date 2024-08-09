using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.ModelElements
{
    internal class Camera
    {
        public Point3D Location {  get; set; }
        public Angle3D Angle { get; set; }

        public void Rotate(Angle3D angle)
        {
            Console.WriteLine($"Camera Rotate({angle})");
        }
        public void Move(Point3D point)
        {
            Console.WriteLine($"Camera Move({point})");
        }
    }
}
