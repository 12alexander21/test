using System;
using System.Threading;

namespace Examen_Ev1_AlejandroPlateroRebollo
{
    class Program
    {
        static void Main()
        {
            menu_principal();
        }
        /*################################### Menú principal ######################################*/
        static void menu_principal()
        {
            int menu = 0;

            do
            {
                Console.Clear();
                Console.Write(@"
   //========================\\
   || 1 - Matriz simétrica   ||                
   || 2 - Número perfecto    ||         
   || 3 - Fibonacci          ||
   || 4 - Años trisiestos    ||
   || 5 - Numero capicúo     ||
   ||------------------------||
   || 0 - Salir del programa ||
   \\========================//
                                Hecho por Alejandro Platero Rebollo
       Opción: ");

                try
                {                   //Try-catch que controlará las excepciones que salten
                    menu = int.Parse(Console.ReadLine());
                }
                catch (FormatException) //Controlará que no se meta un número
                {
                    Console.WriteLine("**ERROR** Introduzca un número");
                    Thread.Sleep(900);
                    menu_principal();
                }
                catch (OverflowException)   //Controlará que se meta un número muy grande
                {
                    Console.WriteLine("**ERROR** Introduzca un número del 0 al 3");
                    Thread.Sleep(900);
                    menu_principal();
                }
                catch (Exception)   //Controlará cualquiera que no sean los dos anteriores
                {
                    Console.WriteLine("**ERROR** Error genérico");
                    Thread.Sleep(900);
                    menu_principal();
                }

                switch (menu)
                {
                    case 1:
                        matriz();
                        break;
                    case 2:
                        perfecto();
                        break;
                    case 3:
                        fibonacci();
                        break;
                    case 4:
                        trisiesto();
                        break;
                    case 5:
                        capicua();
                        break;
                    case 0:
                        Environment.Exit(1);
                        break;
                }

            } while (menu != 0);   //Hacemos un do-while que finalice cuando el usuario quiera salir, es decir cuando introduzca 0

        }

        /*################################### Matriz simétrica ######################################*/
        static void matriz()
        {
            Console.Clear();

            bool esAsimetrica = false;  //Esta variable nos permitirá ver si es simétrica o no

            int[,] matrizA = new int[3, 3] { { 1,1,2 },
                                             { 1,5,2 },     //Matriz simétrica
                                             { 2,2,3,} };

            int[,] matrizB = new int[3, 3] { { 2,1,3 },
                                             { 1,2,2 },     //Matriz no simétrica
                                             { 2,2,3,} };

            int[,] matrizC = new int[4, 4] { { 1,2,3,4 },
                                             { 2,3,4,5 },   //Matriz no simétrica
                                             { 3,5,5,6 },
                                             { 4,5,6,7 } };

            int[,] matrizD = new int[4, 4] { { 1,2,3,4 },
                                             { 2,3,4,5 },   //Matriz simétrica
                                             { 3,4,5,6 },
                                             { 4,5,6,7 } };


            for (int i = 0; i < matrizC.GetLength(0); i++)  //Este for controlará las filas
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)    //Este for controlará las columnas
                {
                    if (matrizC[i, j] == matrizC[j, i]) //Si la posicion tomadas de las dos variables es igual a la posicion al contrario
                    {                                   //Querrá decir que esa posición es simétrica
                        Console.Write("# ");

                    }

                    if (matrizC[i, j] != matrizC[j, i]) //En cambio si no lo es lo marcará con una X y el bool se pondrá a true
                    {
                        Console.Write("X ");
                        esAsimetrica = true;
                    }
                }
                Console.WriteLine("");  //Este WriteLine es para hacer la forma de un array bidimensional, es decir un cuadrado
            }

            if (esAsimetrica == true)   //Si la variable es true entonces querrá decir que no es simétrica
            {
                Console.WriteLine("\nLa matriz no es simétrica");
            }
            else
            {
                Console.WriteLine("\nLa matriz es simétrica");
            }

            Console.WriteLine("\n\nPulse cualquier tecla para salir");
            Console.ReadKey();

        }

        /*################################### Número perfecto ######################################*/

        static void perfecto()
        {
            int numero = 0;   //Esta variable nos permitirá introducir el número que queramos
            int total = 0;   //Esta variable será la que almacene la suma de todos los divisores del número introducido

            Console.Clear();

            Console.Write("Introduce un numero: ");

            try
            {                   //Try-catch que controlará las excepciones que salten
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException) //Controlará que no se meta un número
            {
                Console.WriteLine("**ERROR** Introduzca un número");
                Thread.Sleep(900);
                perfecto();
            }
            catch (OverflowException)   //Controlará que se meta un número muy grande
            {
                Console.WriteLine("**ERROR** Introduzca un número del 0 al 3"); //--typo--
                Thread.Sleep(900);
                perfecto();
            }
            catch (Exception)   //Controlará cualquiera que no sean los dos anteriores
            {
                Console.WriteLine("**ERROR** Error genérico");
                Thread.Sleep(900);
                perfecto();
            }

            //if(numero < 0)
            //{
            //    Console.WriteLine("Introduzca un numero mayor de 0");
            //    Thread.Sleep(900);    :'(
            //    perfecto();
            //}

            int[] divisores = new int[numero];  //Asignamos a un array la longitud del número introducido


            for (int i = 1; i < numero; i++)    //Este array verá los divisores del número introducido
            {
                if (numero % i == 0) //Si el resultado es 0 se almacenará el en array
                {
                    divisores[i] = i;
                    Console.Write("{0}, ", i); //Y se mostrará
                }
            }

            for (int i = 0; i < divisores.Length; i++)  //Este for hará la suma de todos los divisores
            {
                total += divisores[i];
            }

            Console.WriteLine(" El total es {0} ", total);

            if (numero == total) //Si el total de los divisores es igual al numero introducido querrá decir que el número es perfecto
            {
                Console.WriteLine("\nEl número es perfecto");
            }
            else
            {
                Console.WriteLine("\nEl número no es perfecto");
            }

            Console.WriteLine("\n\nPulse cualquier tecla para salir");
            Console.ReadKey();
        }
        /*################################### Secuencia de Fibonacci ######################################*/
        static void fibonacci()
        {
            int numero = 0;   //Esta variable nos permitirá introducir el número que queramos

            Console.Clear();
            Console.Write("Introduzca un número que mostrará N números de la serie Fibonacci: ");

            try //Try-catch que controlará las excepciones que salten
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException) //Controlará que no se meta un número
            {
                Console.WriteLine("**ERROR** Introduzca un número");
                Thread.Sleep(900);
                fibonacci();
            }
            catch (OverflowException)   //Controlará que se meta un número muy grande
            {
                Console.WriteLine("**ERROR** Introduzca un número del 0 al 3");//--TYPO--
                Thread.Sleep(900);
                fibonacci();
            }
            catch (Exception)   //Controlará cualquiera que no sean los dos anteriores
            {
                Console.WriteLine("**ERROR** Error genérico");
                Thread.Sleep(900);
                fibonacci();
            }

            int[] secuencia = new int[numero + 1000000];         //Creamos un array que tendra N posiciones de memoria más 1000000 por si acaso se quedara corto

            secuencia[0] = 0;   //Asignamos a la memoria 0 el valor 0 y a la memoria 1 el valor 1 para poder hacer correctamente la secuencia de Fibonacci
            secuencia[1] = 1;

            Console.WriteLine("");  //Metemos un espacio para que se vea mejor en la consola

            for (int i = 0; i < numero; i++)        //Este for nos hará las cuentas de la secuencia y nos la mostrará
            {
                secuencia[i + 2] = secuencia[i] + secuencia[i + 1];
                Console.Write("{0}, ", secuencia[i]);


                i++;    //Este incremento de i nos servirá para seguir haciendo las cuentas correctamente


                secuencia[i + 2] = secuencia[i] + secuencia[i + 1];
                Console.Write("{0}, ", secuencia[i]);

                if (i == numero - 1)  //Si la secuencia llega a su fin se muestra el siguiente mensaje
                {
                    Console.Write("SECUENCIA FINALIZADA");
                }
            }

            Console.WriteLine("\n\nPulse cualquier tecla para salir");
            Console.ReadKey();
        }

        /*############################################################### SEGUNDA PARTE ##################################################################*/

        static void trisiesto()
        {
            int cont = 0;

            for (int i = 2018; i <= 2501; i++)

                if (i % 4 == 0 || i % 100 == 0 && i % 400 == 0)
                {
                    if ((i % 3 == 0 || i % 7 == 0) && i % 100 != 0)
                    {
                        Console.Write("{0}, ", i);
                        cont++;
                    }
                }
            Console.WriteLine("\n\nNúmero de años: {0}", cont);
            
            System.Console.WriteLine("\nPulse cualquier tecla para salir");
            Console.ReadKey();
        }

        /*################################### Capicua ######################################*/

        static void capicua()
        {
            int num = 0;

            Console.Clear();
            Console.Write("Introduzca un número positivo: ");

            try
            {

                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Introduzca un número");
                Thread.Sleep(900);

            }
            catch (OverflowException)
            {
                Console.WriteLine("Introduzca un número más pequeño");
                Thread.Sleep(900);
            }
            catch
            {
                Console.WriteLine("Error genérico");
                Thread.Sleep(1000);
            }


            if (num <= 0)
            {
                Console.WriteLine("Introduzca un número positivo");
                Thread.Sleep(900);
                capicua();
            }
            else
            {

                char[] numeros = num.ToString().ToCharArray();

                if (numeros.Length < 0 || numeros.Length > 5)
                {
                    Console.WriteLine("Introduzca un número de 5 cifras");
                    Thread.Sleep(900);
                    capicua();
                }
                else if (numeros.Length == 1)
                {
                    Console.WriteLine("El número es capicúo");
                }
                else if (numeros.Length == 2)
                {
                    if (numeros[0] == numeros[1])
                    {
                        Console.WriteLine("El número es capicúo");
                    }
                    else
                    {
                        Console.WriteLine("El número no es capicúo");
                    }
                }
                else if (numeros.Length == 3)
                {
                    if (numeros[0] == numeros[2])
                    {
                        Console.WriteLine("El número es capicúo");
                    }
                    else
                    {
                        Console.WriteLine("El número no es capicúo");
                    }
                }
                else if (numeros.Length == 4)
                {
                    if (numeros[0] == numeros[3] && numeros[1] == numeros[2])
                    {
                        Console.WriteLine("El número es capicúo");
                    }
                    else
                    {
                        Console.WriteLine("El número no es capicúo");
                    }
                }
                else if (numeros.Length == 5)
                {
                    if (numeros[0] == numeros[4] && numeros[1] == numeros[3])
                    {
                        Console.WriteLine("El número es capicúo");

                    }
                    else
                    {
                        Console.WriteLine("El número no es capicúo");
                    }
                }
            }
            
            System.Console.WriteLine("\nPulse cualquier tecla para salir");
            Console.ReadKey();
        }

    }

}
