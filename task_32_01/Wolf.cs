using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    internal class Wolf : Animal
    {
        public Wolf() : base("Волк") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Волк тоже не справился
        }

    }
}
