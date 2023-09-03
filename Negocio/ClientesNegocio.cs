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
                    datos.setearConsulta("Select Id, Nombre, Apellido, Telefono,UltimaVisita, Cumple from DATOSCLIENTES");

                }else if( id != 0)
                {
                    datos.setearConsulta("Select Id, Nombre, Apellido, Telefono,UltimaVisita,Cumple from DATOSCLIENTES where Id = @IdCliente " );
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
                datos.setearConsulta("  INSERT into DATOSCLIENTES (Nombre,Apellido,Email,Telefono,Cumple) values (@Nombre, @Apellido, @Email, @Telefono, @Cumple)");
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
       
    }
}