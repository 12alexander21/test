using System;

namespace Ejercicio_27_Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo = 0;
            bool correcto = false;
            char continuar;

            Console.Clear();
            Console.Write("Introduzca un sueldo: ");

            do
            {
                try
                {
                    sueldo = int.Parse(Console.ReadLine());
                    correcto = true;
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
                if (sueldo < 0)
                {
                    System.Console.Write("Introduzca un número mayor o igual que 0: ");
                    correcto = false;
                }

            }while(correcto == false);

            aumento(ref sueldo);

            System.Console.WriteLine("\nNuevo sueldo = {0}",sueldo);

            System.Console.Write("¿Desea continuar S/N? ");
            continuar = char.Parse(Console.ReadKey);
            switch (continuar)
            {
                case 's':
                case 'S':
                    break;
                case 'n':
                case 'N':
                    System.Environment(0);
                    break;
            }

        }

        static void aumento(ref int sueldo)
        {
            if(sueldo >= 0 && sueldo <= 900)
            {
                sueldo *= 1.2;
            }
            else if(sueldo >= 901 && sueldo <= 15000)
            {
                sueldo *= 1.1;    
            }
            else if(sueldo >= 15001 && sueldo <= 20000)
            {
                sueldo *= 1.05;
            }
            else if(sueldo > 20000)
            {
                sueldo = sueldo;
            }
        }
    }
}
