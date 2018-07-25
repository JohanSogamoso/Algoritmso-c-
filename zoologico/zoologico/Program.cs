using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese:");
            Console.WriteLine("1 si desea estudiar Chimpances");
            Console.WriteLine("2 si desea estudiar Elefantes");
            Console.WriteLine("3 si desea estudiar Jirafas");
            string a = Console.ReadLine();
            int option = int.Parse(a);

            int menor = 0;
            int igual = 0;
            int mayor = 0;

            if (option == 1)
            {
                for (int i = 1; i <= 8; i++)
                {
                    Console.WriteLine("Ingrese la edad del Chimpance " +i);
                    string b = Console.ReadLine();
                    int edad = int.Parse(b);
                    if (edad <= 1)
                    {
                        menor = menor + 1;
                    }
                    else
                    {
                        if (edad <= 3)
                        {
                            igual = igual + 1;
                        }
                        else
                        {
                            mayor = mayor + 1;
                        }
                    }
                }
                int procentaje1 = menor * 100 / 8;
                int procentaje2 = igual * 100 / 8;
                int procentaje3 = mayor * 100 / 8;
                Console.WriteLine("El procentaje de Chimpances menores de un ano es: {0}%", procentaje1);
                Console.WriteLine("El procentaje de Chimpances menores de 3 ano es: {0}%", procentaje2);
                Console.WriteLine("El procentaje de Chimpances mas de 3 ano es: {0}%", procentaje3);
            }
            else
            {
                if (option == 2)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.WriteLine("Ingrese la edad del Elefante " +i);
                        string c = Console.ReadLine();
                        int edad = int.Parse(c);
                        if (edad <= 1)
                        {
                            menor = menor + 1;
                        }
                        else
                        {
                            if (edad <= 3)
                            {
                                igual = igual + 1;
                            }
                            else
                            {
                                mayor = mayor + 1;
                            }
                        }
                    }
                    int procentaje1 = menor * 100 / 4;
                    int procentaje2 = igual * 100 / 4;
                    int procentaje3 = mayor * 100 / 4;
                    Console.WriteLine("El procentaje de Elfantes menores de un ano es: {0}%", procentaje1);
                    Console.WriteLine("El procentaje de Elfantes menores de 3 ano es: {0}%", procentaje2);
                    Console.WriteLine("El procentaje de Elfantes mas de 3 ano es: {0}%", procentaje3);
                }
                else
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("Ingrese la edad del Jirafas " +i);
                        string d = Console.ReadLine();
                        int edad = int.Parse(d);
                        if (edad <= 1)
                        {
                            menor = menor + 1;
                        }
                        else
                        {
                            if (edad <= 3)
                            {
                                igual = igual + 1;
                            }
                            else
                            {
                                mayor = mayor + 1;
                            }
                        }
                    }
                    int procentaje1 = menor * 100 / 3;
                    int procentaje2 = igual * 100 / 3;
                    int procentaje3 = mayor * 100 / 3;
                    Console.WriteLine("El procentaje de Jirafas menores de 3 ano es: {0}%", procentaje2);
                    Console.WriteLine("El procentaje de Jirafas mas de 3 ano es: {0}%", procentaje3);
                }
            }

            Console.ReadKey();
        }
    }
}
