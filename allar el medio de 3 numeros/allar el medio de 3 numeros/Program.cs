using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allar_el_medio_de_3_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero");
            string a = Console.ReadLine();
            int num1 = int.Parse(a);
            string b = Console.ReadLine();
            int num2 = int.Parse(b);
            string c = Console.ReadLine();
            int num3 = int.Parse(c);

            if((num1 < num2 && num1 > num3) || (num1 > num2 && num1 < num3))
            {
                Console.WriteLine("El numero medio es: {0}", num1);
            }
            else
            {
                if((num2 < num1 && num2 > num3) || (num2 > num1 && num2 < num3))
                {
                    Console.WriteLine("El numero medio es: {0}", num2);
                }
                else
                {
                    if((num3 < num1 && num3 > num2) || (num3 > num1 && num3 < num2))
                    {
                        Console.WriteLine("El numero medio es: {0}", num3);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
