using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TihiFeladat
{
    class Program: Turtle
    {
        static void Main(string[] args)
        {
            Food[] etet = new Food[11];
            etet[0] = new Salad();
            etet[1] = new Crab(10);
            etet[2] = new Crab(10);
            etet[3] = new Crab(10);
            etet[4] = new Crab(10);
            etet[5] = new Crab(10);
            etet[6] = new Crab(10);
            etet[7] = new Crab(10);
            etet[8] = new Crab(10);
            etet[9] = new Crab(10);
            etet[10] = new Crab(10);



            Turtle Tihi = new Turtle();
            for (int i = 0; i < etet.Length; i++)
            {
                Tihi.Eat(etet[i]);
                Console.WriteLine("FedLevel: " + Tihi.GetFedLevel());
                Console.WriteLine("Happiness: " + Tihi.GetHappiness());
            }
            

            Console.WriteLine();
            Console.ReadKey();

            

            Console.ReadKey();
        }
    }
}