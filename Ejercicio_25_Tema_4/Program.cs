using System;

namespace Ejercicio_25_Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = 0;
            bool continuar = false;
            
            Console.Clear();
            System.Console.Write("Introduzca un número: ");
            do
            {
                try
                {
                    anio = int.Parse(Console.ReadLine());
                    continuar = true;
                }
                catch (FormatException)
                {
                    System.Console.Write("Introduzca un número: ");
                }
                catch (OverflowException)
                {
                    System.Console.Write("Introduzca un número más pequeño: ");
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Error genérico");
                }

            }while(continuar == false);

            if(anio % 4 == 0 || anio % 100 == 0 && anio % 400 == 0)
            {
                System.Console.WriteLine("El año " + anio + " es bisiesto");
            } 
            else
            {
                System.Console.WriteLine("El año " + anio + " no es bisiesto");
            }

        }
    }
}
