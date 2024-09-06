using Lesson5.Model3D.Entity;
using Lesson5.Model3D.Point3D;
using Lesson5.Model3D.Texture;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.DateBase.DataBaseAccess
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
