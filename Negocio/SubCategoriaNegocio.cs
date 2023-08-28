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
        public List<SubCategoria> listarSubCat(int idCat = 0, int idEsp = 0, bool contiene = false)
        {
            AccesoDatos datos = new AccesoDatos();
            List<SubCategoria> lista = new List<SubCategoria>();
            try
            {
                if (idCat != 0 && idEsp != 0 && contiene == true)
                {
                    datos.setearConsulta("SELECT DISTINCT S.Id as IdSub, S.Descripcion as Descripcion, S.IdCategoria as IdCategoria FROM ESPECIALISTAS as E \r\nINNER JOIN ESPECIALISTAS_SUBCATEGORIAS as ES ON E.Id = ES.IdEsp\r\nINNER JOIN SUBCATEGORIA as S ON ES.IdSubCat = S.Id\r\nINNER JOIN CATEGORIAS as C ON S.IdCategoria = C.Id\r\nWHERE E.Id = @IdEsp AND C.Id = @IdCat");
                    datos.setearParametros("@IdCat", idCat);
                    datos.setearParametros("@IdEsp", idEsp);
                }
                else if (idCat == 0 && idEsp != 0 && contiene == true)
                {
                    datos.setearConsulta("SELECT DISTINCT S.Id AS IdSub, S.IdCategoria as IdCategoria, S.Descripcion AS Descripcion\r\nFROM ESPECIALISTAS AS E\r\nINNER JOIN ESPECIALISTAS_SUBCATEGORIAS AS ES ON E.Id = ES.IdEsp\r\nINNER JOIN SUBCATEGORIA AS S ON ES.IdSubCat = S.Id\r\nWHERE E.Id = @IdEsp");
                    datos.setearParametros("IdEsp", idEsp);
                }
                else if (idCat != 0)
                {
                    datos.setearConsulta("select S.Id as IdSub, S.IdCategoria as IdCategoria, S.Descripcion as Descripcion from SUBCATEGORIA as S, CATEGORIAS as C where S.IdCategoria = C.Id and C.Id = @IdCat");
                    datos.setearParametros("@IdCat", idCat);
                }
                else
                {
                    datos.setearConsulta("select Id as IdSub, IdCategoria, Descripcion from SUBCATEGORIA ");
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    SubCategoria SubCategoria = new SubCategoria();

                    SubCategoria.IdSub = (int)datos.Lector["IdSub"];
                    SubCategoria.idCategoria = (int)datos.Lector["IdCategoria"];
                    SubCategoria.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(SubCategoria);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //  
        

        //public List<SubCategoria> listarSubCat(int idEsp = 0, List<int> idCats = null, bool contiene = false)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    List<SubCategoria> lista = new List<SubCategoria>();

        //    try
        //    {
        //        if (idEsp != 0 && contiene)
        //        {
        //            string query = "SELECT DISTINCT S.Id as IdSub, S.Descripcion as Descripcion, S.IdCategoria as IdCategoria " +
        //                           "FROM ESPECIALISTAS as E " +
        //                           "INNER JOIN ESPECIALISTAS_SUBCATEGORIAS as ES ON E.Id = ES.IdEsp " +
        //                           "INNER JOIN SUBCATEGORIA as S ON ES.IdSubCat = S.Id " +
        //                           "INNER JOIN CATEGORIAS as C ON S.IdCategoria = C.Id " +
        //                           "WHERE E.Id = @IdEsp";

        //            // Verificamos si se proporciona una lista de categorías
        //            if (idCats != null && idCats.Count > 0)
        //            {
        //                string idCatsParam = string.Join(",", idCats);
        //                query += " AND C.Id IN (" + idCatsParam + ")";
        //            }

        //            datos.setearConsulta(query);
        //            datos.setearParametros("@IdEsp", idEsp);
        //        }
        //        else if (idEsp != 0 && !contiene)
        //        {
        //            string query = "SELECT DISTINCT S.Id AS IdSub, S.IdCategoria as IdCategoria, S.Descripcion AS Descripcion " +
        //                           "FROM ESPECIALISTAS AS E " +
        //                           "INNER JOIN ESPECIALISTAS_SUBCATEGORIAS AS ES ON E.Id = ES.IdEsp " +
        //                           "INNER JOIN SUBCATEGORIA AS S ON ES.IdSubCat = S.Id " +
        //                           "WHERE E.Id = @IdEsp";

        //            datos.setearConsulta(query);
        //            datos.setearParametros("@IdEsp", idEsp);
        //        }
        //        else if (idCats != null && idCats.Count > 0)
        //        {
        //            string idCatsParam = string.Join(",", idCats);
        //            string query = "SELECT S.Id as IdSub, S.IdCategoria as IdCategoria, S.Descripcion as Descripcion " +
        //                           "FROM SUBCATEGORIA as S " +
        //                           "INNER JOIN CATEGORIAS as C ON S.IdCategoria = C.Id " +
        //                           "WHERE C.Id IN (" + idCatsParam + ")";

        //            datos.setearConsulta(query);
        //        }
        //        else
        //        {
        //            datos.setearConsulta("SELECT Id as IdSub, IdCategoria, Descripcion FROM SUBCATEGORIA");
        //        }

        //        datos.ejecutarLectura();

        //        while (datos.Lector.Read())
        //        {
        //            SubCategoria subCategoria = new SubCategoria();

        //            subCategoria.IdSub = (int)datos.Lector["IdSub"];
        //            subCategoria.idCategoria = (int)datos.Lector["IdCategoria"];
        //            subCategoria.Descripcion = (string)datos.Lector["Descripcion"];
        //            lista.Add(subCategoria);
        //        }

        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


    }

}
