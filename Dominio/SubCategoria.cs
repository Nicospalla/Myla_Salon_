using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SubCategoria
    {
        public int IdSub { get; set; }
        public int idCategoria { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Duración")]

        public TimeSpan Duracion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
