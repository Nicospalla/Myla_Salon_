using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HistoVentas
    {
        [DisplayName("Numero de Cliente")]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
        [DisplayName("Especialista")]
        public int IdEspecialista { get; set; }
        [DisplayName("Categoria")]
        public Categorias IdCat { get; set; }
        [DisplayName("Sub Categoria")]
        public SubCategoria IdSub { get; set; }
        public string ServicioAdicional { get; set; }
        public string CodigoTinte { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Precio { get; set; }
    }
}
