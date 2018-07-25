using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_la_colegiatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese:");
            Console.WriteLine("1 si el alumno es de profesional");
            Console.WriteLine("2 si el alumno es de preparatoria");
            string a = Console.ReadLine();
            int option = int.Parse(a);

            int suma = 0;

            if (option == 1)
            {
                for (int i = 1; i <= 11; i++)
                {
                    Console.WriteLine("ingrese la nota " + i);
                    string b = Console.ReadLine();
                    int nota = int.Parse(b);
                    suma = suma + nota;
                }
                int promedio = suma / 11;
                double descuento1 = 300 * 0.20;
                if (promedio >= 95)
                {
                    Console.WriteLine("El alumno de profecional debe pagar de colegiatura ${0}",(300 * 11) - descuento1);
                }
                else
                {
                    Console.WriteLine("El alumno de profecional debe pagar de colegiatura ${0}",300 * 11);
                }
            }
            else
            {
                for (int i = 1; i <= 11; i++)
                {
                    Console.WriteLine("Ingrese la nota "+i );
                    string c = Console.ReadLine();
                   int nota = int.Parse(c);
                    suma = suma + nota;
                }
                int promedio = suma / 11;
                Console.WriteLine("Ingrese cuantas notas perdio");
                string d = Console.ReadLine();
                int notasperdidas = int.Parse(d);
                double descuento1 = 180 * 0.25;
                double descuento2 = 180 * 0.1;
                if (promedio >= 95)
                {
                    Console.WriteLine("El alumno de preparatoria debe pagar de colegiatura ${0} y podra cursar 55 unidades",180 * 11 - descuento1);
                }
                else
                {
                    if (promedio >= 90)
                    {
                        Console.WriteLine("El alumno de preparatoria debe pagar de colegiatura ${0} y podra cursar 50 unidades",180 * 10 - descuento2);
                    }
                    else
                    {
                        if (promedio >= 70)
                        {
                            Console.WriteLine("El alumno de preparatoria debe pagar de colegiatura ${0} y podra cursar 50 unidades", 180 * 10);
                        }
                        else
                        {
                            if (notasperdidas <= 3)
                            {
                                Console.WriteLine("El alumno de preparatoria debe pagar de colegiatura ${0} y podra cursar 45 unidades", 180 * 9);
                            }
                            else
                            {
                                Console.WriteLine("El alumno de preparatoria debe pagar de colegiatura ${0} y podra cursar 40 unidades", 180 * 8);
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
