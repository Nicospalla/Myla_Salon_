using Accesorios;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TurnosNegocio
    {
        public List<Turnos> listarTurnos(DateTime fecha, string Estado = "", int idEsp = 0)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                if(Estado == "Reservado" && idEsp ==0)
                {
                    datos.setearConsulta("select IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado,Duracion from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and t.Estado = 'Reservado'");

                }else if (Estado == "Resevado" && idEsp != 0)
                {
                    datos.setearConsulta("select IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado,Duracion from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and IdEspecialista = @IdEsp and t.Estado = 'Reservado'");
                    datos.setearParametros("@IdEsp", idEsp);
                }
                else if(Estado == "Disponible" && idEsp == 0)
                {
                    datos.setearConsulta("select IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado,Duracion from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and t.Estado = 'Disponible'");
                }else if(Estado == "Disponible" && idEsp != 0)
                {
                    datos.setearConsulta("select IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado,Duracion from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and IdEspecialista = @IdEsp and t.Estado = 'Disponible'");
                    datos.setearParametros("@IdEsp", idEsp);
                }else
                {
                    datos.setearConsulta("select IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado,Duracion from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and t.Estado = 'Disponible'");
                }
                datos.setearParametros("@Fecha", fecha);
                datos.ejecutarLectura();
                Turnos turno = new Turnos();
                List<Turnos> lista = new List<Turnos>();
                while (datos.Lector.Read())
                {
                    turno.IdTurno = (int)datos.Lector["IdTurno"];
                    turno.Fecha = fecha;
                    turno.HoraInicio = (DateTime)datos.Lector["HoraInicio"];
                    turno.HoraFin = (DateTime)datos.Lector["HoraFin"];
                    turno.Cliente = new Clientes();
                    turno.Cliente.Id = (int)datos.Lector["IdCliente"];
                    turno.Cliente.Nombre = (string)datos.Lector["NombreCliente"];
                    turno.SubCategoria = new SubCategoria();
                    turno.SubCategoria.IdSub = (int)datos.Lector["IdSubCategoria"];
                    turno.SubCategoria.Descripcion = (string)datos.Lector["Subcategoria"];
                    turno.Especialista = new Especialista();
                    turno.Especialista.IdEspecialista = (int)datos.Lector["IdEspecialista"];
                    turno.Especialista.Nombre = (string)datos.Lector["Especialista"];
                    turno.Estado = (string)datos.Lector["t.Estado"];
                    turno.Duracion = (int)datos.Lector["Duracion"];
                    lista.Add(turno);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
        public void nuevoTurno(Turnos turno)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                turno.HoraFin = turno.HoraInicio.AddMinutes(turno.Duracion);
                datos.setearConsulta("insert into TURNOS (IdCliente,IdSubCategoria,IdEspecialista,Fecha, HoraInicio, HoraFin, Estado) values (@IdCliente, @IdSubcategoria, @IdEspecialista, @Fecha, @HoraInicio, @HoraFin, 'Reservado' )");
                datos.setearParametros("@IdCliente",turno.Cliente.Id);
                datos.setearParametros("@IdSubCategoria",turno.SubCategoria.IdSub);
                datos.setearParametros("@IdEspeialista", turno.Especialista.IdEspecialista);
                datos.setearParametros("@Fecha", turno.Fecha);
                datos.setearParametros("@HoraInicio", turno.HoraInicio);
                datos.setearParametros("@HoraFin", turno.HoraFin);
                //datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
        public bool verifDisponible(DateTime fecha, string hora)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) AS CantidadTurnosDisponibles FROM Turnos WHERE Fecha = @Fecha AND HoraInicio = @HoraInicio and Estado = 'Reservado'");
                datos.setearParametros("@Fecha", fecha);
                datos.setearParametros("@HoraInicio", hora);
                int qty = datos.ejecutarAccionInt();
                if(qty > 0)
                {
                    return false;
                }return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
