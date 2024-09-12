using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.ProjectSettings
{
    internal interface IProjectSettingsProvider
    {
        public Stream Open(string path);
        public void Close();
        public Stream Save(string path);
    }
}
