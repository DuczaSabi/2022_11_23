using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class Rabbit: Animal
    {
        const double rabbitFactor = 0.3;
        public override double GetPrice() { return base.GetPrice() * rabbitFactor; }
        public override string GetType() { return "Nyúl" + base.GetType(); }
    }
}