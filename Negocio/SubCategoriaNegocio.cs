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
        public List<SubCategoria> listarSubCat(int idCat = 0)
        {
            AccesoDatos  datos = new AccesoDatos();
            List<SubCategoria> lista = new List<SubCategoria>();
            try
            {
                if (idCat != 0)
                {
                    datos.setearConsulta("select S.Id as Id, S.IdCategoria as IdCategoria, S.Descripcion as Descripcion from SUBCATEGORIA as S, CATEGORIAS as C where S.IdCategoria = C.Id and C.Id = @IdCat");
                    datos.setearParametros("@IdCat", idCat);
                }
                else
                {
                    datos.setearConsulta("select Id, IdCategoria, Descripcion from SUBCATEGORIAS ");
                }
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    SubCategoria SubCategoria = new SubCategoria();

                    SubCategoria.Id = (int)datos.Lector["Id"];
                    SubCategoria.idSub = (int)datos.Lector["IdCategoria"];
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
        
    }
}
