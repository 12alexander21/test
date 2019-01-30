using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Tema_8
{
    class Coche
    {
        string marca;
        string modelo;
        string matricula;
        string[] ocupantes;

        public Coche()
        {
            //Constructor vacio
        }

        public Coche(Coche coche) //Constructor de copia de objeto
        {
            marca = coche.marca;
            modelo = coche.modelo;
            matricula = coche.matricula;
            ocupantes = coche.ocupantes;
            ocupantes = new string[coche.ocupantes.Length];
            for (int i = 0; i < coche.ocupantes.Length; i++)
            {
                ocupantes[i] = coche.ocupantes[i];
            }

        }
       


        #region Selectores
        public string GetMarca()
        {
            return marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public string GetMatricula()
        {
            return matricula;
        }
        public string[] GetOcupantes()
        {
            return ocupantes;
        }
        #endregion

        #region Modificadores
        public void SetMarca(string UnaMarca)
        {
            marca = UnaMarca;
        }

        public void SetModelo(string UnModelo)
        {
            modelo = UnModelo;
        }

        public void SetMatricula(string UnaMatricula)
        {
            matricula = UnaMatricula;
        }

        public void SetOcupantes(string[] UnosOcupantes)
        {
            if (ocupantes == null)
            {
                ocupantes = new string[UnosOcupantes.Length];
            
                for (int i = 0; i < ocupantes.Length; i++)
                {
                    Console.Write("Introduzca el nombre del ocupante Nº{0}: ", i + 1);
                    ocupantes[i] = Console.ReadLine();
                }
            }
            else
            {
                for (int i = 0; i < ocupantes.Length; i++)
                {
                    ocupantes[i] = UnosOcupantes[i];
                }
            }
            
        }
        #endregion
    }
}