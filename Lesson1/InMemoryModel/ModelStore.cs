using Lesson1.ModelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.InMemoryModel
{
    internal class ModelStore : IModelChanger
    {
        public List<PoligonalModel> Models { get; set; } = [];
        public List<Scene> Scenes { get; set; } = [];
        public List<Flash> Flashes { get; set; } = [];
        public List<Camera> Cameras { get; set; } = [];

        private List<IModelChangeObserver> changeObservers = [];
        public void AddChangeObserver(IModelChangeObserver changeObserver) => changeObservers.Add(changeObserver);

        public Scene GetScena(int n)
        {
            Console.WriteLine($"ModelStore::GetScena({n})");
            return Scenes[n];
        }
        public void NotifyChange(IModelChanger modelChanger)
        {

        }

    }
}
