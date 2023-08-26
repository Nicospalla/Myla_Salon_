using System.ComponentModel;

namespace Dominio
{
    public class Clientes
    {
        [DisplayName("Numero de Cliente")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime Cumple { get; set; }
        [DisplayName("Última Visita")]
        public DateTime UltVisita { get; set; }
        [DisplayName("Último Contacto")]
        public DateTime UltContacto { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}