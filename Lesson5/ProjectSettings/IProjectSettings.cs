using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.ProjectSettings
{
    internal interface IProjectSettings
    {
        public string Path { get; set; }
        public void Load();
        public void Save();
        public int Settings1 { get; set; }
        public string Settings2 { get; set; }
    }
}
