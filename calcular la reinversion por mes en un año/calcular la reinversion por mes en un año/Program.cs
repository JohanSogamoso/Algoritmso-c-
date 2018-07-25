using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_la_reinversion_por_mes_en_un_año
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad a invertir");
            string a = Console.ReadLine();
            double inversion = double.Parse(a);

            for(int i = 1; i <= 12; i++)
            {
                double ganancia = inversion * 0.02;
                inversion = inversion + ganancia;
            }

            Console.WriteLine("La ganancia total al invertir por mes durante un ano es: ${0}", inversion);
            Console.ReadKey();
        }
    }
}
