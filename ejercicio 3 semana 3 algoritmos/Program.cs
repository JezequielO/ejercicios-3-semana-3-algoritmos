using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_semana_3_algoritmos
{
    class Program
    {
        class positive_negativo
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ingrese un numero");
                int a = Convert.ToInt16(Console.ReadLine());
                if (a >= 0)
                {
                    Console.WriteLine(a + " es positivo");
                }
                else
                {
                    Console.WriteLine(a + " es negativo");
                }
                Console.ReadLine();
            }
        }
    }
}
