using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.ProjectSettings.FileProvider
{
    internal class FileProvider : IProvider, IDisposable
    {
        private Stream _stream = null;

        public void Close()
        {
            _stream?.Close();
            _stream = null;
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }


        public Stream Open(string path)
        {
            Close();
            _stream = File.Open(path, FileMode.Open);
            return _stream;
        }

        public Stream Save(string path)
        {
            Close();
            _stream = File.Open(path, FileMode.Create);
            return _stream;
        }
    }
}
