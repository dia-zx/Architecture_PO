using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Model3D.Entity
{
    internal abstract class Entity : IEntity
    {
        static int _nextId = 0;
        public Entity()
        {
            Id = _nextId++;
        }
        public int Id { get; }
        public string Name { get; set; }
    }
}
