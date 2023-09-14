using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Caja
    {
        public int IdCaja { get; set; }
        public string  Usuario { get; set; }
        public int Inicio { get; set; }
        public int Retiro { get; set; }
        public string RetiroMotivo { get; set; }
        public int PagoProv { get; set; }
        public string NombreProv { get; set; }
        public int Ingreso { get; set; }
        public int PagoTarjeta { get; set; }
        public int PagoEfectivo { get; set; }
        public Clientes Cliente { get; set; }
        public Especialista Especialista { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }

    }
}
