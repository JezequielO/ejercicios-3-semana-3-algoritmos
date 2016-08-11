using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_semana_3_algoritmos
{
    class Program
    {
        static void Main(string[] args);
  
            public class comparacion_de_palabras
{
public static void Main()
{
float numero1;
float numero2;
Console.WriteLine("Escribe el primer valor");
numero1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Escribe el segundo valor");
numero2 = Convert.ToInt16(Console.ReadLine());
if (numero1 == numero2 )
Console.WriteLine("ambas son iguales");
if (numero1.CompareTo(numero2 ) > 0)
Console.WriteLine("el numero {0} es mayor que {1} ", numero1, numero2 );
else
Console.WriteLine("el numero {0} es menor que {1}", numero1, numero2);
Console.ReadLine();
}
}
    }

}
