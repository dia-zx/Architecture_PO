using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.WipingStations
{
    public abstract class WipingStation
    {
        protected WipingStation(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
    }
}
