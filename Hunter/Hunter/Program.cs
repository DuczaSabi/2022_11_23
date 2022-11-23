using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allatok = new Animal[3];

            allatok[0] = new PolarBear();
            allatok[1] = new Squirrel();
            allatok[2] = new Rabbit();

            Console.WriteLine(allatok[0].GetType() + " " + allatok[0].GetPrice());
            Console.WriteLine(allatok[1].GetType() + " " + allatok[1].GetPrice());
            Console.WriteLine(allatok[2].GetType() + " " + allatok[2].GetPrice());

            Console.ReadKey();
        }
    }
}