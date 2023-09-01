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

        public List<Especialista> listaEspecialista(int id = 0, string nombre = "")
        {
            List<Especialista> lista = new List<Especialista>();
            try
            {
                if(id == 0 && nombre =="")
                {
                    datos.setearConsulta("select Id, Nombre,Apellido,Email,Telefono,Sueldo, Porcentaje, Cumple from ESPECIALISTAS where Estado = 1");
                }
                else if(id != 0 && nombre == "") 
                {
                    datos.setearConsulta("select Id, Nombre,Apellido,Email,Telefono,Sueldo, Porcentaje, Cumple from ESPECIALISTAS where Id = @IdEsp and Estado = 1");
                    datos.setearParametros("@IdEsp", id);
                }
                else if(nombre != "")
                {
                    datos.setearConsulta("select Id, Nombre,Apellido,Email,Telefono,Sueldo, Porcentaje, Cumple from ESPECIALISTAS where Nombre = @IdNombre and Estado = 1");
                    datos.setearParametros("@IdNombre", nombre);
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Especialista aux = new Especialista();
                    aux.IdEspecialista = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    if (datos.Lector["Cumple"] != DBNull.Value)
                        aux.Cumple = (DateTime)datos.Lector["Cumple"];
                    else
                    {
                        aux.Cumple = DateTime.Today;
                    }
                    aux.Sueldo = datos.Lector["Sueldo"] != DBNull.Value ? Math.Truncate((Decimal)datos.Lector["Sueldo"]*100)/100 :  0;
                    aux.Porcentaje = datos.Lector["Porcentaje"] != DBNull.Value ? (double)datos.Lector["Porcentaje"] : 0f;
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }

        public int nuevoEsp(Especialista aux)
        {
            AccesoDatos datos = new AccesoDatos();

            int idEsp;
            try
            {
                datos.setearConsulta("INSERT into ESPECIALISTAS (Nombre,Apellido,Email,Telefono,Cumple,Sueldo, Porcentaje, Estado)output inserted.Id values (@Nombre, @Apellido, @Email, @Telefono, @Cumple, @Sueldo, @Porcentaje, 1)");
                datos.setearParametros("@Nombre", aux.Nombre);
                datos.setearParametros("@Apellido", aux.Apellido);
                datos.setearParametros("@Email", aux.Email);
                datos.setearParametros("@Telefono", aux.Telefono);
                datos.setearParametros("@Cumple", aux.Cumple);
                datos.setearParametros("@Sueldo", aux.Sueldo);
                datos.setearParametros("Porcentaje", aux.Porcentaje);
                idEsp = datos.ejecutarAccionInt();
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConn();
            }
            return idEsp;
        }

        public void eliminaEspecialista(int idEsp)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update ESPECIALISTAS set Estado = 0 where Id = @IdEsp");
                datos.setearParametros("@IdEsp", idEsp);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }finally { datos.cerrarConn(); }
        }
        public void editarEspecialista(Especialista aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Update ESPECIALISTAS set Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, Cumple = @Cumple, Sueldo = @Sueldo, Porcentaje = @Porcentaje where Id = @IdEsp";
                datos.setearConsulta(consulta);
                datos.setearParametros("@IdEsp", aux.IdEspecialista);
                datos.setearParametros("@Nombre", aux.Nombre);
                datos.setearParametros("@Apellido", aux.Apellido);
                datos.setearParametros("@Email", aux.Email);
                datos.setearParametros("@Telefono", aux.Telefono);
                datos.setearParametros("@Sueldo", aux.Sueldo);
                datos.setearParametros("@Porcentaje", aux.Porcentaje);
                datos.setearParametros("@Cumple", aux.Cumple);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
    }
}
