using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] butorok = new Furniture[3];

            butorok[0] = new Chair(1);
            butorok[1] = new Table(100);
            butorok[2] = new Bed(300, 250);

            for (int i = 0; i < butorok.Length; i++)
            {
                Console.WriteLine(butorok[i].GetId() + ": " + butorok[i].Print() + "\n");
            }
            Console.ReadKey();
        }
    }
}