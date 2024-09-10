using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Model3D.Entity
{
    internal interface IEntity
    {
        public int Id { get; }
        public string Name { get; set; }
    }
}
