using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diffrence_Write_and_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {            
            Diffrence();

            Console.ReadKey();
        }
        public static void Diffrence()
        {
            Console.Write("Hello "); //Вывод Hello World с помощью метода Write()
            Console.Write("World ");
            Console.Write("!!!");

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Hello World !!!");//Вывод Hello World с помощью метода WriteLine()

        }

    }
}
