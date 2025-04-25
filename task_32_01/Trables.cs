using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    public abstract class Trables
    {
        public string Name { get; }
        protected Trables(string name) 
        {
            Name = name;
        }
        public abstract void trables(Kolobok kolobok);

    }
}
