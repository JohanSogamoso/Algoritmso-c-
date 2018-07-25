using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_presupuesto_de_un_hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el presupuesto anual del hospital");
            string a = Console.ReadLine();
            double presupuesto = double.Parse(a);

            Console.WriteLine("El presupuesto para el area de Ginecologia es: ${0}", presupuesto * 0.4);
            Console.WriteLine("El presupuesto para el area de Traumatologia es: ${0}", presupuesto * 0.3);
            Console.WriteLine("El presupuesto para el area de Pediatria es: ${0}", presupuesto * 0.3);

            Console.ReadKey();
        }
    }
}
