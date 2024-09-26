using Lesson6.Core.DataBaseAccess;
using Lesson6.Core.Model3D.Entity;
using Lesson6.Core.Model3D.Point3D;
using Lesson6.Core.Model3D.Texture;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.BusinessLogicalLayer
{
    internal class BusinessLogicalLayer : IBusinessLogicalLayer
    {
        public BusinessLogicalLayer(IDataBaseAccess dataBaseAccess)
        {
            _dataBaseAccess = dataBaseAccess;
        }
        private IDataBaseAccess _dataBaseAccess;

        public ReadOnlyCollection<Point3D> GetAllPoints() => _dataBaseAccess.GetPoints();

        public ReadOnlyCollection<Texture> GetAllTextures() => _dataBaseAccess.GetTextures();

        public ReadOnlyCollection<Model3D.Model3D> GetAllModel3Ds() => _dataBaseAccess.GetModel3Ds();

        public void RenderAllModels()
        {
            foreach (var model in GetAllModel3Ds())
            {
                RenderModel(model);
            }
        }

        public void RenderModel(Model3D.Model3D model)
        {
            Console.WriteLine($"Rendering model: [{model}]");
        }

        public LinkedList<IEntity> GetAll() => _dataBaseAccess.GetAll();
    }
}
