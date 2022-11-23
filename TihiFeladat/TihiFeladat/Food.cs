using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TihiFeladat
{
    abstract class Food
    {
        int Tapertek = 0;
        public virtual int value() { return Tapertek; }
    }
}