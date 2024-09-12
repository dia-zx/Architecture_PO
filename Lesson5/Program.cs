using Lesson5.ProjectSettings;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.UI ui = new();
            ui.Init();
            ui.Start();
        }
    }
}
