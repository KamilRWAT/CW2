using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Zwierze
    {
        public string Nazwa { get; set; }
        public string Gatunek { get; set; }
        public int Wiek { get; set; }
        public double Waga { get; set; }

        public virtual void DajGlos ()
        {
            MessageBox.Show("Zwierze wydaje dźwięk");
        }
    }
}
