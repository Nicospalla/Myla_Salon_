using Accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class CajaNegocio
    {
        public bool cajaActiva(DateTime fecha)
        {
            AccesoDatos datos = new();
            bool status = false;
            try
            {
                datos.setearConsulta("SELECT 1 FROM CAJA WHERE Fecha = @fecha AND Estado = 1");
                datos.setearParametros("@fecha", fecha);
                datos.ejecutarLectura();
                if (datos.Lector.HasRows)
                {
                    status = true;
                }
                return status;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }

        public void activarCaja(DateTime fecha, int eftInicio, User aux)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("insert  into CAJA (Fecha,Inicio,Usuario,Estado) values (@Fecha, @Inicio, @Usuario, 1)");
                datos.setearParametros("@Fecha", fecha);
                datos.setearParametros("@Usuario", aux.Usuario);
                datos.setearParametros("@Inicio", eftInicio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
        public void nuevaVenta(Caja caja, string Metodo)
        {
            AccesoDatos datos = new();
            try
            {
                if (Metodo == "Efectivo")
                {
                    datos.setearConsulta("insert into CAJA (PagoEfectivo, IdCliente, IdEspe, Fecha) values (@PagoEfectivo, @IdCliente, @IdEspe, @Fecha) ");
                    datos.setearParametros("@PagoEfectivo", caja.PagoEfectivo);
                }
                else if (Metodo == "Tarjeta")
                {
                    datos.setearConsulta("insert into CAJA (PagoTarjeta, IdCliente, IdEspe, Fecha) values (@PagoTarjeta, @IdCliente, @IdEspe, @Fecha) ");
                    datos.setearParametros("@PagoTarjeta", caja.PagoTarjeta);
                }
                datos.setearParametros("@IdCliente", caja.Cliente.Id);
                datos.setearParametros("@IdEspe", caja.Especialista.IdEspecialista);
                datos.setearParametros("@Fecha", caja.Fecha); ;
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
        public List<Caja> listarCajas(DateTime fecha)
        {
            List<Caja> lista = new();
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("SELECT C.Id AS Id, Usuario, Inicio, Retiro, RetiroMotivo, PagoProv, NombreProv," +
                    " Ingreso, PagoTarjeta, PagoEfectivo, IdCliente, dc.Nombre AS NombreCli, e.Nombre AS NombreEsp," +
                    "IdEspe, Fecha\r\nFROM CAJA C\r\nLEFT JOIN DATOSCLIENTES DC ON C.IdCliente = DC.Id " +
                    "LEFT JOIN ESPECIALISTAS E ON C.IdEspe = E.Id\r\nWHERE Fecha = @Fecha;");
                datos.setearParametros("@Fecha", fecha);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Caja aux = new Caja();
                    aux.IdCaja = (int)datos.Lector["Id"];
                    aux.Usuario = datos.Lector["Usuario"] != DBNull.Value ? (string)datos.Lector["Usuario"] : "";
                    aux.Inicio = datos.Lector["Inicio"] != DBNull.Value ? (int)datos.Lector["Inicio"] : 0;
                    aux.Retiro = datos.Lector["Retiro"] != DBNull.Value ? (int)datos.Lector["Retiro"] : 0;
                    aux.RetiroMotivo = datos.Lector["RetiroMotivo"] != DBNull.Value ? (string)datos.Lector["RetiroMotivo"] : "";
                    aux.PagoProv = datos.Lector["PagoProv"] != DBNull.Value ? (int)datos.Lector["PagoProv"] : 0;
                    aux.NombreProv = datos.Lector["NombreProv"] != DBNull.Value ? (string)datos.Lector["NombreProv"] : "";
                    aux.Ingreso = datos.Lector["Ingreso"] != DBNull.Value ? (int)datos.Lector["Ingreso"] : 0;
                    aux.PagoTarjeta = datos.Lector["PagoTarjeta"] != DBNull.Value ? (int)datos.Lector["PagoTarjeta"] : 0;
                    aux.PagoEfectivo = datos.Lector["PagoEfectivo"] != DBNull.Value ? (int)datos.Lector["PagoEfectivo"] : 0;
                    if (datos.Lector["IdCliente"] != DBNull.Value)
                    {
                        aux.Cliente = new Clientes();
                        aux.Cliente.Id = (int)datos.Lector["IdCliente"];
                        aux.Cliente.Nombre = (string)datos.Lector["NombreCli"];
                    }
                    if (datos.Lector["IdEspe"] != DBNull.Value)
                    {
                        aux.Especialista = new Especialista();
                        aux.Especialista.IdEspecialista = (int)datos.Lector["IdEspe"];
                        aux.Especialista.Nombre = (string)datos.Lector["NombreEsp"];
                    }
                    aux.Fecha = fecha;
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void eliminarRegistros(DateTime fecha)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from CAJA where Fecha < @Fecha");
                datos.setearParametros("@Fecha", fecha);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
        public void movimientosCaja(int eft, int index, DateTime fecha,User user, string motivo = "")
        {
            AccesoDatos datos = new();
            try
            {
                if (index == 1)
                {
                    datos.setearConsulta("INSERT into CAJA (Inicio, Fecha, Usuario) values (@Inicio, @Fecha, @Usuario) ");
                    datos.setearParametros("@Inicio", eft);

                }
                else if (index == 2)
                {
                    datos.setearConsulta(" INSERT into CAJA (Ingreso, Fecha,Usuario) values (@Ingreso, @Fecha,@Usuario) ");
                    datos.setearParametros("@Ingreso", eft);
                }
                else if (index == 3)
                {
                    datos.setearConsulta("INSERT into CAJA (Retiro, RetiroMotivo, Fecha, Usuario) values (@Retiro, @RetiroMotivo, @Fecha,@Usuario)");
                    datos.setearParametros("@Retiro",eft);
                    datos.setearParametros("@RetiroMotivo",motivo);
                }
                else if (index == 4)
                {
                    datos.setearConsulta("INSERT into CAJA (PagoProv, NombreProv, Fecha, Usuario) values (@PagoProv, @NombreProv, @Fecha,@Usuario)");
                    datos.setearParametros("@PagoProv", eft);
                    datos.setearParametros("@NombreProv",motivo);
                }
                datos.setearParametros("@Usuario", user.Usuario);
                datos.setearParametros("@Fecha", fecha);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }finally { datos.cerrarConn(); }
        }
    }
}
