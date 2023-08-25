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
        
        public List<Categorias> listarCat()
        {
            List<Categorias> lista = new List<Categorias>();
            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
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
        }
    }
}
