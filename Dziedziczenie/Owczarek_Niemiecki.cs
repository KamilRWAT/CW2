using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Owczarek_Niemiecki : Pies
    {
        public Owczarek_Niemiecki ()
        {
            Nazwa = "Czarek";
            Gatunek = "Pies";
            Wiek = 2;
            Waga = 10;
            KolorSiersci = "Czarny";
        }
        public string KolorSiersci { get; set; }
        public override void DajGlos()
        {
            base.DajGlos(); // base. wywoluje metode z klasy po
                            // ktorej dziedziczy (Pies)
        }
    }
}
