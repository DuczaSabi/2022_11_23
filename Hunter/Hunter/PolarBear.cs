using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class PolarBear: Animal
    {
        const double polarBearFactor = 2.4;
        public override double GetPrice() { return base.GetPrice() * polarBearFactor; }
        public override string GetType() { return "Jegesmedve" + base.GetType(); }
    }
}