using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton _instance = null;
        private Singleton() => _instance = this;
        public static Singleton Instance {
            get {
                if (_instance == null) new Singleton();
                    return _instance; 
            }
        }
    }
}
