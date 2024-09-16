using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.ModelElements
{
    internal class Scene
    {
        public Scene() { Id = _id++; }
        private static int _id = 0;
        public int Id { get; }

        public List<PoligonalModel> Models { get; set; } = [];
        public List<Flash> Flashes { get; set; } = [];
        public List<Camera> Cameras { get; set; } = [];

        public int method1(int a)
        {
            Console.WriteLine($"Scene::method1({a})");
            return a++;
        }
        public int method2(int a)
        {
            Console.WriteLine($"Scene::method2({a})");
            return a += 10;
        }
    }
}
