using Accesorios;
using Dominio;
namespace Negocio
{
    
    public class ClientesNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public List<Clientes> listar(int id = 0)
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                if( id == 0)
                {
                    datos.setearConsulta("Select Id, Nombre, Apellido, Telefono,UltimaVisita, Cumple, Email from DATOSCLIENTES where Estado = 1");

                }else if( id != 0)
                {
                    datos.setearConsulta("Select Id, Nombre, Apellido, Telefono,UltimaVisita,Cumple, Email from DATOSCLIENTES where Id = @IdCliente and Estado = 1 " );
                    datos.setearParametros("@IdCliente", id);
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Clientes aux = new Clientes();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    if (datos.Lector["Cumple"] != DBNull.Value)
                        aux.Cumple = (DateTime)datos.Lector["Cumple"];
                    if (datos.Lector["UltimaVisita"] != DBNull.Value)
                        aux.UltVisita = (DateTime)datos.Lector["UltimaVisita"];
                    if (datos.Lector["Email"] != DBNull.Value)
                        aux.Email = (string)datos.Lector["Email"];
                   
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConn();
            }
        }

        public void crearCliente(Clientes aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("  INSERT into DATOSCLIENTES (Nombre,Apellido,Email,Telefono,Cumple, Estado) values (@Nombre, @Apellido, @Email, @Telefono, @Cumple, 1)");
                datos.setearParametros("@Nombre",aux.Nombre);
                datos.setearParametros("@Apellido", aux.Apellido);
                datos.setearParametros("@Email",aux.Email);
                datos.setearParametros("@Telefono", aux.Telefono);
                datos.setearParametros("@Cumple",aux.Cumple);
                
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConn();
            }
        }
        public void editarCliente(Clientes aux)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("  update DATOSCLIENTES set  Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, Cumple = @Cumple, UltimoContacto = @UltimoContacto where Id = @Id");
                datos.setearParametros("@Nombre", aux.Nombre);
                datos.setearParametros("@Apellido", aux.Apellido);
                datos.setearParametros("@Email" , aux.Email);
                datos.setearParametros("@Telefono", aux.Telefono);
                datos.setearParametros("@Cumple", aux.Cumple);
                datos.setearParametros("@UltimoContacto", aux.UltContacto);
                datos.setearParametros("@Id", aux.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConn();}
        }
        public void eliminarCliente(Clientes aux)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("UPDATE DATOSCLIENTES set Estado = 0 where Id = @Id");
                datos.setearParametros("@Id",aux.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}