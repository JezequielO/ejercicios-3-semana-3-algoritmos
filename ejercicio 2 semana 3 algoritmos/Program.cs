using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParoImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " es par");
            }
            else
            {
                Console.WriteLine(a + " es impar");
            }
            Console.ReadLine();
        }
    }
}
