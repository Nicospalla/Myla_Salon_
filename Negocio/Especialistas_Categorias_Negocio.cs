using Accesorios;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Especialistas_Categorias_Negocio
    {
        public List<Especialista> listarEspCat(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Especialista> lista = new List<Especialista>();
            try
            {
                datos.setearConsulta("  select E.Nombre as Nombre from ESPECIALISTAS_CATEGORIAS as EC, ESPECIALISTAS as E, CATEGORIAS as C where E.Id = idEsp and C.Id = idCat and idCat = @idCat");
                datos.setearParametros("@IdCat", id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Especialista aux = new Especialista();
                    aux.Nombre = (string)datos.Lector["Nombre"];
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
    }
}
