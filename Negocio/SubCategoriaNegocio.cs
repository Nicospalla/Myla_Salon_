using Accesorios;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SubCategoriaNegocio
    {
        public List<SubCategoria> listarSubCat(int idEsp = 0, int idCat = 0 , bool contiene = false)
        {
            AccesoDatos datos = new AccesoDatos();
            List<SubCategoria> lista = new List<SubCategoria>();
            try
            {
                if (idEsp != 0 && contiene && idCat != 0)
                {
                    datos.setearConsulta("select S.Id, S.descripcion as Descripcion, Duracion, S.IdCategoria as IdCategoria from SUBCATEGORIA S, CATEGORIAS C, ESPECIALISTAS_CATEGORIAS EC, ESPECIALISTAS E where s.IdCategoria = c.Id and C.Id = ec.idCat and ec.idEsp = E.Id and e.Id = @IdEsp and EC.IdCat = @IdCat ");
                    datos.setearParametros("@IdEsp", idEsp);
                    datos.setearParametros("@IdCat", idCat);
                }else if(idEsp != 0 && contiene && idCat == 0)
                {
                    datos.setearConsulta("select S.Id, S.descripcion as Descripcion,Duracion, S.IdCategoria as IdCategoria from SUBCATEGORIA S, CATEGORIAS C, ESPECIALISTAS_CATEGORIAS EC, ESPECIALISTAS E where s.IdCategoria = c.Id and C.Id = ec.idCat and ec.idEsp = E.Id and e.Id = @IdEsp");
                    datos.setearParametros("@IdEsp", idEsp);
                }
                else
                {
                    datos.setearConsulta("select Id, IdCategoria, Descripcion, Duracion from SUBCATEGORIA ");
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    SubCategoria sub = new SubCategoria();

                    sub.IdSub = (int)datos.Lector["Id"];
                    sub.idCategoria = (int)datos.Lector["IdCategoria"];
                    sub.Descripcion = (string)datos.Lector["Descripcion"];
                    sub.Duracion = (TimeSpan)datos.Lector["Duracion"];
                    lista.Add(sub);
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
