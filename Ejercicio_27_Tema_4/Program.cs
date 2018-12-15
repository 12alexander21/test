using System;

namespace Ejercicio_27_Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;

            do //Controlará todo el main junto con la última función llamada
            {
                double sueldo = 0;
                bool correcto = false;
                
                Console.Clear();
                System.Console.WriteLine(@"
   ---Aumento de sueldo---");
                Console.Write("Introduzca un sueldo: ");

                do  //Controlará el try-catch
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

                aumento(ref sueldo); //Va a la función aumento para aumentar el sueldo

                System.Console.WriteLine("\nNuevo sueldo = {0}",sueldo); //Muestra el nuevo sueldo

                pregunta(out continuar); //Función que nos permite introducir o no un nuevo sueldo
                
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
            bool seguir = false;    //Nos permitira continuar si la letra introducida es S o N
                                    //Si no el bucle continuará
            System.Console.Write("¿Desea continuar S/N? ");
                do
                {
                    continuar = Console.ReadLine().ToUpper(); 
                                    
                    switch (continuar)
                    {
                        case "S":
                        case "N":   //Si la letra introducida es S o N la variable sera true y podremos continuar
                            seguir = true;
                            break;
                        default:    //Si no, la variable seguirá siendo false hasta que se introduzca uno de los dos caracteres permitidos
                            System.Console.Write("Introduzca S ó N: ");
                            break;
                    }
                }while(seguir == false);
        }
    }
}
