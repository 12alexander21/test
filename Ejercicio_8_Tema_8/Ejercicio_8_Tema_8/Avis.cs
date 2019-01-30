using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Tema_8
{
    class Avis
    {
        int oficinas;
        string nombreGerente;
        string tlfOficina;
        string tlfGuardia;
        DateTime fechaAlta;
        List<Coche> misCoches = new List<Coche>();

        public Avis()
        {
            int cont = 0;
            oficinas = ++cont;
            fechaAlta = DateTime.Now;
        }

        public Avis(string nombreGerente, string tlfOficina, string tlfGuardia): this ()
        {
            this.nombreGerente = nombreGerente;
            this.tlfOficina = tlfOficina;
            this.tlfGuardia = tlfGuardia;
        }

        public Coche this[Coche pos]
        {
            set
            {
                misCoches[] = value;
            }
        }
    }
}
