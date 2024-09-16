using Lesson5.Model3D.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Model3D.Texture
{
    internal class Texture : Entity.Entity
    {
        public Texture(int color, uint width, uint height)
        {
            Color = color; Width = width; Height = height;
        }
        public int Color { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }

        public override string ToString() => $"Texture ID: {Id}, Color: {Color}, W х H: {Width} x {Height}";
    }
}
