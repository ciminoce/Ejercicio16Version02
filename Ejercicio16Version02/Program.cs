using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16Version02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Ingrese un número entero:");
            var unNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(-1, unNumero) == 1 ? $"{unNumero} es par" : $"{unNumero} es impar");
            Console.ReadLine();

        }
    }
}
