using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Model3D.Point3D
{
    internal class Point3D : Entity.Entity
    {
        public Point3D(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString() => $"Point3D Id: {Id}, XYZ: ({X}, {Y}, {Z})";


    }
}
