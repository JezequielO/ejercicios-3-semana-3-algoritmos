using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTATURA
{ class Program
{ static void Main(string[] args)
{ 
    int num; 
    string linea; 
    Console.Write("INGRESE SU ALTURA EN CENTIMETROS:"); 
    linea = Console.ReadLine();
    num = int.Parse(linea); 
    if (num < 150) 
    { 
        Console.Write("ES DE ALTURA BAJA");
    }
    else
    {
        Console.Write("ES DE ALTURA PROMEDIO"); 
    }
    if (num > 170) 
    { 
        Console.Write("ES DE UNA ALTURA MAYOR A LA PROMEDIO");
    }
    Console.ReadKey(); 
}
}
}
