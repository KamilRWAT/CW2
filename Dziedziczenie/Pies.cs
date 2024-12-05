using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Pies : Zwierze
    {
        public string Rasa { get; set; }
        public override string DajGlos()
        {
            return "HauHau";
        }
    }
}
