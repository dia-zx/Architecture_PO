using Lesson6.Core.Model3D.Entity;
using Lesson6.Core.Model3D.Point3D;
using Lesson6.Core.Model3D.Texture;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.DataBaseAccess
{
    internal interface IDataBaseAccess
    {
        public ReadOnlyCollection<Texture> GetTextures();
        public ReadOnlyCollection<Point3D> GetPoints();
        public ReadOnlyCollection<Model3D.Model3D> GetModel3Ds();
        public LinkedList<IEntity> GetAll();
        public void Add(IEntity entity);
        public bool Remove(IEntity entity);
        public bool Remove(int id);
    }
}
