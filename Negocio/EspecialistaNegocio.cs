using Accesorios;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EspecialistaNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public List<Especialista> listaEspecialista()
        {
            List<Especialista> lista = new List<Especialista>();
            try
            {
                datos.setearConsulta("select Id, Nombre,Apellido,Email,Telefono from ESPECIALISTAS ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Especialista aux = new Especialista();
                    aux.IdEspecialista = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                   // aux.Cumple = (DateTime)datos.Lector["Cumple"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void nuevoEsp(Especialista aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT into ESPECIALISTAS (Nombre,Apellido,Email,Telefono,Cumple) values (@Nombre, @Apellido, @Email, @Telefono, @Cumple)");
                datos.setearParametros("@Nombre", aux.Nombre);
                datos.setearParametros("@Apellido", aux.Apellido);
                datos.setearParametros("@Email", aux.Email);
                datos.setearParametros("@Telefono", aux.Telefono);
                datos.setearParametros("@Cumple", aux.Cumple);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
