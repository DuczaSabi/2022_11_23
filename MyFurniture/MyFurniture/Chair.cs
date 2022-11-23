using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Chair: Furniture
    {
        const double chairFactor = 1.2;
        int labszam;

        public Chair(int labszam) { this.labszam = labszam; IdNovel(); }

        public override double GetPrice() { return base.GetPrice() * chairFactor; }

        public override string Print() { return "Szék " + base.Print() + "Lábszám: " + labszam + "; Ár: " + GetPrice(); }
    }
}