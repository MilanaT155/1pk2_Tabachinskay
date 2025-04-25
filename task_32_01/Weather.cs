using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    internal class Weather : Trables
    {
        public Weather(): base("дождь") { }
        public  override void trables(Kolobok kolobok) 
        {
            kolobok.RollBack();
        }
    }
}
