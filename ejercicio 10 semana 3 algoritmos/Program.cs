using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_semana_3_algoritmos
{
    class Program
    {
        class ejercicio
        {
            static void Main(string[] args)
            {
                string letra;
                Console.WriteLine("INGRESE UNA LITERAL:");
                letra = Console.ReadLine();
                if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
                {
                    Console.WriteLine("El rendimiento esperado: Es una vocal");
                }
                else
                {
                    Console.WriteLine("El rendimiento esperado: !!No es vocal¡¡");
                }
                Console.ReadKey();
            }
        }
    }
}
