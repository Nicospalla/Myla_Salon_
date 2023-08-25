using Accesorios;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HistoVentasNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public List<HistoVentas> buscaHistorial(int idCliente)
        {
            List<HistoVentas> lista = new List<HistoVentas>();
            try
            {
                datos.setearConsulta("SELECT IdCliente, IdEspecialista,HV.IdCategoria,IdSubcategoria, S.Descripcion, S.Id as IdSub,S.Descripcion as Subcategoria , C.Descripcion as Categoria ,DC.Nombre as Nombre, ServicioAdicional,CodigoTinte,Fecha,Precio from HISTORIAL_VENTAS as HV, CATEGORIAS as C, SUBCATEGORIA as S, DATOSCLIENTES as DC where HV.IdCategoria = C.Id and IdSubcategoria = S.Id and DC.Id = HV.IdCliente and IdCliente = @IdCliente");
                datos.setearParametros("@IdCliente", idCliente);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    HistoVentas aux = new HistoVentas();
                    aux.IdCliente = idCliente;
                    aux.Cliente = new Clientes();
                    aux.Cliente.Nombre = (string)datos.Lector["Nombre"];
                    aux.IdEspecialista = (int)datos.Lector["IdEspecialista"];
                    aux.IdCat = new Categorias();
                    aux.IdCat.idCat = (int)datos.Lector["IdCategoria"];
                    aux.IdCat.Descripcion = (string)datos.Lector["Categoria"];
                    aux.IdSub = new SubCategoria();
                    aux.IdSub.idSub = (int)datos.Lector["IdSub"];
                    aux.IdSub.Descripcion = (string)datos.Lector["Subcategoria"];
                    aux.ServicioAdicional = (string)datos.Lector["ServicioAdicional"];
                    aux.CodigoTinte = (string)datos.Lector["CodigoTinte"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Precio = (Decimal)datos.Lector["Precio"];
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

        public void nuevaVenta(HistoVentas venta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("  insert into HISTORIAL_VENTAS (IdCliente,IdEspecialista,IdCategoria,IdSubcategoria,ServicioAdicional,CodigoTinte,Fecha,Precio) values (@IdCliente,@IdEspecialista,@IdCategoria,@IdSubcategoria,@ServicioAdicional,@CodigoTinte,@Fecha,@Precio)");
                datos.setearParametros("@IdCliente",venta.IdCliente);
                datos.setearParametros("@IdEspecialista",venta.IdEspecialista);
                datos.setearParametros("@IdCategoria",venta.IdCat);
                datos.setearParametros("@IdSubcategoria",venta.IdSub);
                datos.setearParametros("@ServicioAdicional",venta.ServicioAdicional);
                datos.setearParametros("@CodigoTinte",venta.CodigoTinte);
                datos.setearParametros("@Fecha",venta.Fecha);
                datos.setearParametros("@Precio",venta.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
