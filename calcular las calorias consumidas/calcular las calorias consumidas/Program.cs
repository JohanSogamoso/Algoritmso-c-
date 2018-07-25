using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_las_calorias_consumidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese:");
            Console.WriteLine("1 si realizo la actividad de domir");
            Console.WriteLine("2 si realizo la actividad de estar sentado en reposo");
            string a = Console.ReadLine();
            int option = int.Parse(a);

            if(option == 1)
            {
                Console.WriteLine("Ingresa los minutos empleados en la actividad de dormir");
                string b = Console.ReadLine();
                int min = int.Parse(b);

                Console.WriteLine("Las calorias quemadas durante esta actividad fue de {0} Kcal", 1.08 * min);
            }
            else
            {
                Console.WriteLine("Ingrese los minutos empleados en la actividad de estar sentado en reposo");
                string c = Console.ReadLine();
                int min = int.Parse(c);

                Console.WriteLine("Las calorias quemadas durante esta actividad fue de {0} Kcal", 1.66 * min);
            }
            Console.ReadKey();
        }
    }
}
