using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_el_devaluo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del automovil y terreno");
            string a = Console.ReadLine();
            double costo = double.Parse(a);

            double devaluo = (costo * 0.1)*3;
            double valorizacion = (costo * 0.3)*3;

            if(devaluo < (valorizacion / 2))
            {
                Console.WriteLine("Comprar el automovil");
            }
            else
            {
                Console.WriteLine("No comprar el automovil");
            }

            Console.ReadKey();
        }
    }
}
