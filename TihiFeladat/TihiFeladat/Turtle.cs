using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TihiFeladat
{
    class Turtle
    {
        int fedLevel;
        int happiness;

        public void Eat(Food food) {
            fedLevel = fedLevel + food.value();
            if (fedLevel <= 500 && happiness <= 1000) {
                happiness = happiness + (food.value() * 2);
            }
            else if (fedLevel > 500 && happiness >= 0) {
                happiness = happiness - (food.value() * 2);
            }
            else {
                Console.WriteLine("Tihi tele van!");
                return;
            }
        }

        public int GetHappiness() { return happiness; }
        public int GetFedLevel() { return fedLevel; }
    }
}