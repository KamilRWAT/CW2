using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Pies : Zwierze
    {
        public override void DajGlos()
        {
            MessageBox.Show("HauHau");
        }
    }
}
