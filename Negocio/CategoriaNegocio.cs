using Accesorios;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        
        public List<Categorias> listarCat(int idEsp = 0, bool contiene = false)
        {
            List<Categorias> lista = new List<Categorias>();
            try
            {
                if(idEsp != 0 && contiene == false)
                {
                    datos.setearConsulta("SELECT C.Id as Id, C.Descripcion as Descripcion FROM CATEGORIAS C WHERE C.Id NOT IN ( SELECT EC.IdCat FROM ESPECIALISTAS_CATEGORIAS EC WHERE EC.IdEsp = @idEsp)");
                    datos.setearParametros("@IdEsp",idEsp);
                }else if(idEsp != 0 && contiene == true)
                {
                    datos.setearConsulta("SELECT C.Id as Id, C.Descripcion as Descripcion FROM CATEGORIAS C WHERE C.Id IN ( SELECT EC.IdCat FROM ESPECIALISTAS_CATEGORIAS EC WHERE EC.IdEsp = @idEsp)");
                    datos.setearParametros("@IdEsp", idEsp);
                }
                else
                {
                    datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categorias categorias = new Categorias();
                    categorias.idCat = (int)datos.Lector["Id"];
                    categorias.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(categorias);
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
