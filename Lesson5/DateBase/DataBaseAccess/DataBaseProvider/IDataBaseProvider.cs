using Lesson5.Model3D.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.DateBase.DataBaseAccess.DataBaseProvider
{
    internal interface IDataBaseProvider
    {
        public LinkedList<IEntity> GetAll();
        public void Load();
        public void Save();
    }
}
