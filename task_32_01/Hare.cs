using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    internal class Hare : Animal
    {
        public Hare() : base("Заяц") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Заяц не смог съесть Колобка
        }
    }
}
