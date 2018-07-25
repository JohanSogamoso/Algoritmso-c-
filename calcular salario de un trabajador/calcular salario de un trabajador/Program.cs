using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_salario_de_un_trabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese horas trabajadas en la semana:");
            string a = Console.ReadLine();
            int hora = int.Parse(a);

            int salario = 40 * 16;
            int extra = (hora - 40) * 20;

            if(hora <= 40)
            {
                Console.WriteLine("Su salario semanal es: ${0}", hora * 16);
            }
            else
            {
                Console.WriteLine("Su salario semanal es: ${0}", salario + extra);
            }
            Console.ReadKey();
        }
    }
}
