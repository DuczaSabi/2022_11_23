using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Bed: Furniture
    {
        const double bedFactor = 2.4;
        int hosszusag;
        int szelesseg;

        public Bed(int hosszusag, int szelesseg)
        {
            this.hosszusag = hosszusag;
            this.szelesseg = szelesseg;
            IdNovel();
        }

        public override double GetPrice() { return base.GetPrice() * bedFactor; }

        public override string Print() { return "Ágy " + base.Print() + "Hossz: " + hosszusag + "; szélesség: " + szelesseg + "; Ár: " + GetPrice(); }
    }
}