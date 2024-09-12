using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.ProjectSettings
{
    internal interface IProvider
    {
        public Stream Open(string path);
        public void Close();
        public Stream Save(string path);
    }
}
