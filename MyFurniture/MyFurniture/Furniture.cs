using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    abstract class Furniture
    {
        static double basePrice = 25000;
        static uint idCounter = 0;
        protected uint id;

        protected void IdNovel() { id = ++idCounter; }

        public uint GetId() { return id; }

        public virtual double GetPrice() { return basePrice; }

        public virtual string Print() { return "tulajdonságai: "; }
    }
}