using System;

namespace Ejercicio_24_Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pi=4;

            for (int i = 3 ; i <= 1000; i+=2)
            {
                pi = pi + 4/i;
                System.Console.Write(pi = pi + 4/i);
                pi = pi - 4/i;
                System.Console.Write(pi = pi - 4/i);
            }
        }
    }
}
