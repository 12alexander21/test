using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Tema_8
{
    class Program
    {
        static protected int num; //Variable que usaremos para crear el array con la longitud que deseemos
        static void Main(string[] args)
        {
            
            //Instanciación del objeto y sus atributos
            Coche coche1 = new Coche();
            coche1.SetMarca("Toyota");
            coche1.SetModelo("Corolla");
            coche1.SetMatricula("1234ABC");

            numeOcu(); //Pedimos cuantos ocupantes queremos introducir

            string[] numeroOcu = new string[num]; //Creamos un array con la longitud que hayamos introducido

            coche1.SetOcupantes(numeroOcu); //Seteamos los ocupantes pasando el array por parametro

            Coche coche2 = new Coche(coche1); //Creamos un nuevo objeto y al constructor le pasamos por parametro el anterior objeto creado

            Console.Write("\nPrimer coche: ");
            VerPorConsola(coche1); //Los mostramos
            Console.Write("Segundo coche: ");
            VerPorConsola(coche2); 

            ModificarPrimerOcu(coche1, numeroOcu); //Modificamos el primero ocupante del coche. Le pasamos el objeto y el array anteriormente creado

            Console.Write("\nPrimer coche: ");
            VerPorConsola(coche1); //Los mostramos
            Console.Write("Segundo coche: ");
            VerPorConsola(coche2);

            Console.WriteLine("\n\nPulse cualquier tecla para salir");
            Console.ReadKey();
            
        }

        static void VerPorConsola(Coche coche)
        {
            Console.Write("Marca: {0}, Modelo: {1}, Matricula: {2}, Ocupantes: ",coche.GetMarca(), coche.GetModelo(), coche.GetMatricula());
            for (int i = 0; i < coche.GetOcupantes().Length; i++)
            {
                Console.Write("{0} ",coche.GetOcupantes()[i]);
            }
            Console.WriteLine("");
        }

        static void ModificarPrimerOcu(Coche coche, string[] numeroOcu)
        {
          
            Console.WriteLine("\n\nNombre actual del primer vehículo: {0}", coche.GetOcupantes());
            Console.Write("Introduzca un nuevo nombre para el primer ocupante: ");
            numeroOcu[0] = Console.ReadLine();

            for (int i = 1; i < numeroOcu.Length; i++)
            {
                numeroOcu[i] = coche.GetOcupantes()[i];
            }

            coche.SetOcupantes(numeroOcu);
            
        }

        static void numeOcu()
        {
            Console.Write("Introduzca un numero de ocupantes: ");
            num = int.Parse(Console.ReadLine());   
        }

    }
}
