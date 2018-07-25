using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_el_procentaje_de_cada_inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las 3 cantidades a invertir");
            string a = Console.ReadLine();
            decimal inv1 = decimal.Parse(a);
            string b = Console.ReadLine();
            decimal inv2 = decimal.Parse(b);
            string c = Console.ReadLine();
           decimal inv3 = decimal.Parse(c);

            decimal valort = inv1 + inv2 + inv3;

            Console.WriteLine("El porcentaje de invercion del primer inversor es: {0}%", (inv1 * 100) / valort);
            Console.WriteLine("El porcentaje de invercion del segundo inversor es: {0}%", (inv2 * 100) / valort);
            Console.WriteLine("El porcentaje de invercion del tercer inversor es: {0}%", (inv3 * 100) / valort);

            Console.ReadKey();
        }
    }
}
