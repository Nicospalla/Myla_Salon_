using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        public int IdTurno { get; set; }
        public Clientes Cliente { get; set; }
        public SubCategoria SubCategoria { get; set; }
        public Especialista Especialista { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Estado { get; set; }
        public int Duracion { get; set; }

    }
}
