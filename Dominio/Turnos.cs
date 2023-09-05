using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        public int IdTurno { get; set; }
        public Clientes Cliente { get; set; }
        public Especialista Especialista { get; set; }
        public SubCategoria SubCategoria { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("Hora de Inicio")]
        public TimeSpan HoraInicio { get; set; }
        [DisplayName("Hora de Fin")]
        public TimeSpan HoraFin { get; set; }
        public string Estado { get; set; }

    }
}
