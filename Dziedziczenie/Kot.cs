using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Kot : Zwierze
    {
        public override void DajGlos()
        {
            Console.WriteLine("MiauMiau");
        }
    }
}
