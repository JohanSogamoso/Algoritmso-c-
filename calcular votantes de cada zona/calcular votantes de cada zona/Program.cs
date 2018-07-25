using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_votantes_de_cada_zona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero votantes");
            string a = Console.ReadLine();
            int votantes = int.Parse(a);

            int norte = 0;
            int centro = 0;
            int sur = 0;

            for(int i = 1; i <= votantes; i++)
            {
                Console.WriteLine("Ingrese:");
                Console.WriteLine("1 si eres de la zona norte");
                Console.WriteLine("2 si eres de la zona centro");
                Console.WriteLine("3 si eres de la zona sur");
                string b = Console.ReadLine();
                int option = int.Parse(b);
                if (option == 1)
                {
                    norte = norte + 1;
                }
                else
                {
                    if (option == 2)
                    {
                        centro = centro + 1;
                    }
                    else
                    {
                        sur = sur + 1;
                    }
                }
            }

            if (norte > centro && norte > sur)
            {
                Console.WriteLine("El numero de votantes de la zona norte fue de {0} personas", norte);
                Console.WriteLine("El numero de votantes de la zona centro fue de {0} personas", centro);
                Console.WriteLine("El numero de votantes de la zona sur fue de {0} personas", sur);
                Console.WriteLine("Con mayor participacion de la zona norte");
            }
            else
            {
                if (centro > norte && centro > sur)
                {
                    Console.WriteLine("El numero de votantes de la zona norte fue de {0} personas", norte);
                    Console.WriteLine("El numero de votantes de la zona centro fue de {0} personas", centro);
                    Console.WriteLine("El numero de votantes de la zona sur fue de {0} personas", sur);
                    Console.WriteLine("Con mayor participacion de la zona centro");
                }
                else
                {
                    if (sur > norte && sur > centro)
                    {
                        Console.WriteLine("El numero de votantes de la zona norte fue de {0} personas", norte);
                        Console.WriteLine("El numero de votantes de la zona centro fue de {0} personas", centro);
                        Console.WriteLine("El numero de votantes de la zona sur fue de {0} personas", sur);
                        Console.WriteLine("Con mayor participacion de la zona sur");
                    }
                   
                }
            }

            Console.ReadKey();
        }
    }

}
