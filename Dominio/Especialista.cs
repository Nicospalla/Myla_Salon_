using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Especialista
    {
        public int IdEspecialista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Cumple { get; set; }

        public int Sueldo { get; set; }
        public int Porcentaje { get; set; }


        public override string ToString()
        {
            return Nombre;
        }

    }
}
