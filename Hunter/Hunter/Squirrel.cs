using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class Squirrel: Animal
    {
        const double squirrelFactor = 1.2;
        public override double GetPrice() { return base.GetPrice() * squirrelFactor; }
        public override string GetType() { return "Mókus" + base.GetType(); }
    }
}