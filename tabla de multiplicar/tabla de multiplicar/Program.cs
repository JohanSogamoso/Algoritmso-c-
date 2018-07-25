using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la tabla");
            string a = Console.ReadLine();
            int num = int.Parse(a);

            for(int i = 0; i <= 10; i++)
            {
                int resultado = i * num;
                Console.WriteLine("tabla " + num);
                Console.WriteLine("{0} por {1} es igual a {2}", i, num, resultado);
            }

            Console.ReadKey();
        }
    }
}
