using Accesorios;
using Dominio;
namespace Negocio
{
    
    public class ClientesNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public List<Clientes> listar()
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                datos.setearConsulta("Select Id, Nombre, Apellido, Telefono from DATOSCLIENTES");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Clientes aux = new Clientes();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
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
       
    }
}