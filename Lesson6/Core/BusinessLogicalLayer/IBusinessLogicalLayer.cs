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
