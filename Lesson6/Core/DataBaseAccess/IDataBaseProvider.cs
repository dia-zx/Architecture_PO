using Lesson6.Core.Model3D.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.DataBaseAccess
{
    internal interface IDataBaseProvider
    {
        public LinkedList<IEntity> GetAll();
        public void Load();
        public void Save();
    }
}
