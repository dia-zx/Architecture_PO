using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.ModelElements
{
    internal class Texture
    {
        public Texture() { }
        public Texture(int width, int height, string path)
        {
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public string Path { get; set; }
    }
}
