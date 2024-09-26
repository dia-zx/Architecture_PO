using Lesson5.DateBase.DataBaseAccess.DataBaseProvider;
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
    internal class DataBaseAccess : IDataBaseAccess, IDataBaseProvider
    {
        public DataBaseAccess(IDataBaseProvider dataBaseProvider)
        {
            _dataBaseProvider = dataBaseProvider;
        }
        private IDataBaseProvider _dataBaseProvider;

        public ReadOnlyCollection<Texture> GetTextures()
        {
            return new ReadOnlyCollection<Texture>(_dataBaseProvider.GetAll().Where(x => x is Texture).Cast<Texture>().ToList());
        }

        public ReadOnlyCollection<Point3D> GetPoints()
        {
            return new ReadOnlyCollection<Point3D>(_dataBaseProvider.GetAll().Where(x => x is Point3D).Cast<Point3D>().ToList());
        }
        public ReadOnlyCollection<Model3D.Model3D> GetModel3Ds()
        {
            return new ReadOnlyCollection<Model3D.Model3D>(_dataBaseProvider.GetAll().Where(x => x is Model3D.Model3D).Cast<Model3D.Model3D>().ToList());
        }

        public void Add(IEntity entity) => _dataBaseProvider.GetAll().AddLast(entity);

        public bool Remove(IEntity entity) => _dataBaseProvider.GetAll().Remove(entity);

        public LinkedList<IEntity> GetAll() => _dataBaseProvider.GetAll();

        public void Load() => _dataBaseProvider.Load();

        public void Save() => _dataBaseProvider.Save();

        public bool Remove(int id)
        {            
            for(var node = _dataBaseProvider.GetAll().First; ; node = node.Next)
            {
                if(node.Value.Id == id)
                {
                     _dataBaseProvider.GetAll().Remove(node);
                    return true;
                }
                if (node == _dataBaseProvider.GetAll().Last) return false;
            }
        }

        LinkedList<IEntity> IDataBaseAccess.GetAll() => _dataBaseProvider.GetAll();
    }
}
