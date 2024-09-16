using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.ProjectSettings
{
    internal class ProjectSettings : IProjectSettings
    {
        public ProjectSettings(IProjectSettingsProvider provider)
        {
            _provider = provider; // сдесь используем файловое хранилище, однако можно подключить другое...
        }
        private IProjectSettingsProvider _provider;
        public string Path { get; set; } = string.Empty;
        public int Settings1 { get; set; }
        public string Settings2 { get; set; } = string.Empty;

        public void Load()
        {
            if (Path == string.Empty)
                throw new ArgumentException("Path не должен быть пустым!");
            var stream = _provider.Open(Path);
            using (BinaryReader reader = new(stream))
            {
                Settings1 = reader.ReadInt32();
                Settings2 = reader.ReadString();
            }
            stream.Close();
        }

        public void Save()
        {
            if (Path == string.Empty)
                throw new ArgumentException("Path не должен быть пустым!");
            var stream = _provider.Save(Path);
            using (BinaryWriter writer = new(stream))
            {
                writer.Write(Settings1);
                writer.Write(Settings2);

            }
            stream.Close();

        }

        public override string ToString() => $"Settings1: {Settings1}, Settings2: {Settings2}";

    }
}
