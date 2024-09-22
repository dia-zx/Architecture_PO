using Lesson5.Model3D.Entity;
using Lesson5.Model3D.Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Model3D
{
    internal class Model3D : Entity.Entity
    {
        public Model3D() { }
        public List<Point3D.Point3D> Points { get; set; } = [];
        public List<Texture.Texture> Textures { get; set; } = [];

        public override string ToString() => $"Model3D Id: {Id}, Name: {Name}, Poits: {Points.Count}, Textures: {Textures.Count}";

    }
}
