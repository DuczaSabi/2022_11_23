using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Table: Furniture
    {
        const double tableFactor = 0.3;
        int magassag;

        public Table(int magassag) { this.magassag = magassag; IdNovel(); }

        public override double GetPrice() { return base.GetPrice() * tableFactor; }

        public override string Print() { return "Asztal " + base.Print() + "Magasság: " + magassag + "; Ár: " + GetPrice(); }
    }
}