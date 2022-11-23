using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TihiFeladat
{
    class Salad: Food
    {
        int Tapertek = 10;

        public override int value() { return base.value() + Tapertek; }
    }
}