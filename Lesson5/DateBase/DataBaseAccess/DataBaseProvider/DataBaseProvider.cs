using Lesson5.Model3D.Entity;
using Lesson5.ProjectSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.DateBase.DataBaseAccess.DataBaseProvider
{
    internal class DataBaseProvider : IDataBaseProvider
    {
        public DataBaseProvider(IProjectSettings projectSettings) {
            _projectSettings = projectSettings;
            Load();
        }
        private readonly IProjectSettings _projectSettings;
        private LinkedList<IEntity> _dataList = [];
        public LinkedList<IEntity> GetAll() => _dataList;

        public void Load()
        {
            if (_projectSettings.Path == string.Empty) return;
            if (_projectSettings.Path == null) return;
            _dataList.Clear();
            Console.WriteLine($"...База данных {_GetDBPath()} загружена.");
        }

        public void Save()
        {
            if (_projectSettings.Path == string.Empty) 
                throw new Exception("Не указано расположение проекта!");
            Console.WriteLine($"...База данных {_GetDBPath()} сохранена.");
        }

        private string _GetDBPath()
        {
            string? _path = System.IO.Path.GetDirectoryName(_projectSettings.Path);
            return Path.Combine(_path, "database.dat");
        }
    }
}
