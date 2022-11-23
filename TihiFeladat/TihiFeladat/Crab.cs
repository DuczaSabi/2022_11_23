using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TihiFeladat
{
    class Crab: Food
    {
        int Meret;
        int AlapTapertek = 10;
        int Tapertek {
            set {
                if (value >= 1 && value <= 10)
                    Meret = value;
                else
                    Meret = 1;
            }
        }
        public Crab(int Meret)
        {
            this.Meret = Meret;
        }

        public override int value() { return base.value() + (Meret * AlapTapertek); }
    }
}