using System;

namespace Ejercicio_27_Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;

            do
            {
                double sueldo = 0;
                bool correcto = false;
                
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

                pregunta(out continuar);
                
            }while(continuar != "N");    

        }

        static void aumento(ref double sueldo)
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
                System.Console.WriteLine("El sueldo introducido es muy grande como para recibir un aumento");
            }
        }

        static void pregunta(out string continuar)
        {
            bool seguir = false;
            System.Console.Write("¿Desea continuar S/N? ");
                do
                {
                    continuar = Console.ReadLine().ToUpper(); 
                                    
                    switch (continuar)
                    {
                        case "N":
                            System.Console.WriteLine("Adios");
                            seguir = true;
                            break;
                        case "S":
                            seguir = true;
                            break;
                        default:
                            System.Console.Write("Introduzca S ó N: ");
                            break;
                    }
                }while(seguir == false);
        }
    }
}
