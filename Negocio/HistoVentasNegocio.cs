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
                datos.setearStoredProcedure("ObtenerVentasConIdSubCategoria");
                //datos.setearConsulta("  SELECT IdVenta, IdCliente, IdEspecialista, E.Nombre as NombreEsp,HV.IdCategoria,IdSubcategoria, S.Descripcion, S.Id as IdSub,S.Descripcion as Subcategoria , C.Descripcion as Categoria ,DC.Nombre as Nombre, ServicioAdicional,CodigoTinte,Fecha,Precio from HISTORIAL_VENTAS as HV, CATEGORIAS as C, SUBCATEGORIA as S, DATOSCLIENTES as DC, ESPECIALISTAS as E where HV.IdCategoria = C.Id and IdSubcategoria = S.Id and E.Id = IdEspecialista and DC.Id = HV.IdCliente and IdCliente = 1");
                datos.setearParametros("@IdCliente", idCliente);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    HistoVentas aux = new HistoVentas();
                    aux.IdVenta = (int)datos.Lector["IdVenta"];
                    aux.IdCliente = idCliente;
                    aux.Cliente = new Clientes();
                    aux.Cliente.Nombre = (string)datos.Lector["Nombre"];

                    aux.Especialista = new Especialista();
                    aux.Especialista.IdEspecialista = (int)datos.Lector["IdEspecialista"];
                    aux.Especialista.Nombre = (string)datos.Lector["NombreEsp"];
                    
                    
                    aux.IdCat = new Categorias();
                    aux.IdCat.idCat = (int)datos.Lector["IdCategoria"];
                    aux.IdCat.Descripcion = (string)datos.Lector["Categoria"];
                    
                    if(datos.Lector["IdSub"] != DBNull.Value)
                    {
                        aux.IdSub = new SubCategoria();
                        
                        aux.IdSub.idCategoria = (int)datos.Lector["IdSub"];
                        aux.IdSub.Descripcion = (string)datos.Lector["Subcategoria"];
                    }

                    aux.ServicioAdicional = (string)datos.Lector["ServicioAdicional"];
                    aux.CodigoTinte = (string)datos.Lector["CodigoTinte"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Precio =Math.Truncate((Decimal)datos.Lector["Precio"]*100)/100;
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

        public void accionSobreVentas(HistoVentas venta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if(venta.IdVenta != 0)
                {
                    datos.setearConsulta("update HISTORIAL_VENTAS set IdCliente = @IdCliente,  IdEspecialista = @IdEspecialista, IdCategoria = @IdCategoria, IdSubcategoria = @IdSubcategoria, ServicioAdicional = @ServicioAdicional, CodigoTinte = @CodigoTinte, Fecha = @Fecha,Precio = @Precio where IdVenta = @IdVenta ");
                    datos.setearParametros("@IdVenta", venta.IdVenta);
                }
                else
                {
                    datos.setearConsulta("insert into HISTORIAL_VENTAS (IdCliente,IdEspecialista,IdCategoria,IdSubcategoria,ServicioAdicional,CodigoTinte,Fecha,Precio) values (@IdCliente,@IdEspecialista,@IdCategoria,@IdSubcategoria,@ServicioAdicional,@CodigoTinte,@Fecha,@Precio)  UPDATE DATOSCLIENTES  set UltimaVisita = '2023-08-27', UltimoContacto = '2023-08-27' where Id = @IdCliente");
                }

                datos.setearParametros("@IdCliente",venta.IdCliente);
                datos.setearParametros("@IdEspecialista",venta.Especialista.IdEspecialista);
                datos.setearParametros("@IdCategoria",venta.IdCat.idCat);
                datos.setearParametros("@IdSubcategoria", venta.IdSub.IdSub);
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
        public void eliminarVenta(HistoVentas venta)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("delete from HISTORIAL_VENTAS where IdVenta = @IdVenta");
                datos.setearParametros("@IdVenta",venta.IdVenta);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
