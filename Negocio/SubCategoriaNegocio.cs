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
                if (idEsp != 0 && contiene ==true && idCat != 0)
                {
                    datos.setearConsulta("select S.Id, S.descripcion as Descripcion, S.IdCategoria as IdCategoria from SUBCATEGORIA S, CATEGORIAS C, ESPECIALISTAS_CATEGORIAS EC, ESPECIALISTAS E where s.IdCategoria = c.Id and C.Id = ec.idCat and ec.idEsp = E.Id and e.Id = @IdEsp and EC.IdCat = @IdCat ");
                    datos.setearParametros("@IdEsp", idEsp);
                    datos.setearParametros("@IdCat", idCat);
                }
                else
                {
                    datos.setearConsulta("select Id, IdCategoria, Descripcion from SUBCATEGORIA ");
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    SubCategoria SubCategoria = new SubCategoria();

                    SubCategoria.IdSub = (int)datos.Lector["Id"];
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

    }

}
