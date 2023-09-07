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
        
        public List<Categorias> listarCat(int idEsp = 0, bool contiene = false, List<int>? listaCat = null)
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

        public void quitarCategoria(int idEsp, int idCat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ESPECIALISTAS_CATEGORIAS where idEsp = @idEsp and idCat =@idCat ");
                datos.setearParametros("@idEsp",idEsp);
                datos.setearParametros("@idCat",idCat);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
        public void insertarCategoria(int idEsp, int idCat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ESPECIALISTAS_CATEGORIAS (idCat, idEsp) values (@idCat, @idEsp)");
                datos.setearParametros("@idCat",idCat);
                datos.setearParametros("@idEsp",idEsp);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }finally { datos.cerrarConn(); }
        }

        public void nuevaCat(string cat)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                datos.setearParametros("@Descripcion",cat);
                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarCat (Categorias cat)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("  delete from ESPECIALISTAS_CATEGORIAS where idCat = @idCat delete from SUBCATEGORIA where IdCategoria = @idCat delete from CATEGORIAS where Id = @idCat");
                datos.setearParametros("@idCat", cat.idCat);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
