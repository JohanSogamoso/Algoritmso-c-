using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allar_el_numero_menor_con_numero_limite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el limite de numeros para allar el menor");
            string a = Console.ReadLine();
            int limt = int.Parse(a);

            Console.WriteLine("Ingresa un numero");
            string b = Console.ReadLine();
            int num = int.Parse(b);

            for(int i = 2; i <= limt; i++)
            {
                string c = Console.ReadLine();
                int menor = int.Parse(c);
                if(menor < num)
                {
                    num = menor;
                }
            }

            Console.WriteLine("El numero menor es: {0}", num);
            Console.ReadKey();
        }
    }
}
