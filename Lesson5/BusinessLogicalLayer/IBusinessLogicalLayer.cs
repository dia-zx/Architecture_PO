using Lesson5.Model3D;
using Lesson5.Model3D.Entity;
using Lesson5.Model3D.Point3D;
using Lesson5.Model3D.Texture;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.BusinessLogicalLayer
{
    internal interface IBusinessLogicalLayer
    {
        public ReadOnlyCollection<Texture> GetAllTextures();
        public ReadOnlyCollection<Point3D> GetAllPoints();
        public ReadOnlyCollection<Model3D.Model3D> GetAllModel3Ds();
        public LinkedList<IEntity> GetAll();

        public void RenderModel(Model3D.Model3D model);

        public void RenderAllModels();
    }
}
