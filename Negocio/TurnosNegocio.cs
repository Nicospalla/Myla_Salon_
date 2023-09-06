using Accesorios;
using Dominio;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TurnosNegocio
    {
        public List<Turnos> listarTurnos(DateTime fecha, int idEsp = 0)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                if( idEsp ==0)
                {
                    datos.setearStoredProcedure("listarTurnosTodos");
                }else if (idEsp != 0)
                {
                    datos.setearStoredProcedure("listarTurnosIdEsp");
                    //datos.setearConsulta("select top 1 IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado as esta2 from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and IdEspecialista = @IdEsp and t.Estado = 'Reservado' and IdTurno = IdTurno");
                    datos.setearParametros("@IdEsp", idEsp);
                }
                else
                {
                    datos.setearConsulta("select IdTurno, IdCliente, C.Nombre as NombreCliente, IdSubCategoria, s.Descripcion as Subcategoria, IdEspecialista, e.Nombre as Especialista,Fecha,HoraInicio, HoraFin,t.Estado as esta2 from TURNOS T, SUBCATEGORIA S, DATOSCLIENTES C, ESPECIALISTAS E where IdCliente = c.Id and IdSubCategoria = s.Id and IdEspecialista = e.Id and t.Fecha = @Fecha and t.Estado = 'Disponible'");
                }
                datos.setearParametros("@Fecha", fecha);
                datos.ejecutarLectura();
                List<Turnos> lista = new List<Turnos>();
                while (datos.Lector.Read())
                {
                    Turnos turno = new Turnos();
                    turno.IdTurno = (int)datos.Lector["IdTurno"];
                    turno.Fecha = fecha;
                    turno.HoraInicio = (TimeSpan)datos.Lector["HoraInicio"];
                    turno.HoraFin = (TimeSpan)datos.Lector["HoraFin"];
                    turno.Cliente = new Clientes();
                    turno.Cliente.Id = (int)datos.Lector["IdCliente"];
                    turno.Cliente.Nombre = (string)datos.Lector["NombreCliente"];
                    turno.SubCategoria = new SubCategoria();
                    turno.SubCategoria.IdSub = (int)datos.Lector["IdSubCategoria"];
                    turno.SubCategoria.Descripcion = (string)datos.Lector["Subcategoria"];
                    turno.Especialista = new Especialista();
                    turno.Especialista.IdEspecialista = (int)datos.Lector["IdEspecialista"];
                    turno.Especialista.Nombre = (string)datos.Lector["Especialista"];
                    turno.Estado = (string)datos.Lector["esta2"];
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
        public int defineTurnos(Turnos turno, int idTurno = 0, bool modif = false)
        {
            AccesoDatos datos = new();
            int Id = 0;
            try
            {
                string consulta = "";
                if(modif == true)
                {
                    
                    consulta += "update TURNOS set IdTurno = 0 where id = (select top 1 id from TURNOS where IdTurno =  @IdTurno) " +
                        "delete from TURNOS where IdTurno = @IdTurno " +
                        "update TURNOS set IdTurno = @IdTurno,Estado = @Estado, IdCliente = @IdCliente, IdSubCategoria = @IdSubCategoria, IdEspecialista = @IdEspecialista, Fecha = @Fecha, HoraInicio = @HoraInicio, HoraFin = @HoraFin where IdTurno = 0 ";
                    datos.setearConsulta(consulta);
                    Id = turno.IdTurno;
                }
                else if(idTurno == 0)
                {
                    consulta += "insert into TURNOS (IdCliente, IdSubCategoria,IdEspecialista,Fecha, HoraInicio, HoraFin, Estado) output inserted.Id  values (@IdCliente, @IdSubcategoria , @IdEspecialista, @Fecha, @HoraInicio, @HoraFin, @Estado )";
                    datos.setearConsulta(consulta);
                }else if(idTurno != 0)
                {
                    consulta += "insert into TURNOS (IdCliente,IdTurno,IdSubCategoria,IdEspecialista,Fecha, HoraInicio, HoraFin, Estado) values (@IdCliente,@IdTurno , @IdSubcategoria, @IdEspecialista, @Fecha, @HoraInicio, @HoraFin, @Estado)";
                    datos.setearConsulta(consulta);
                }
                datos.setearParametros("@IdCliente",turno.Cliente.Id);
                datos.setearParametros("@IdSubCategoria",turno.SubCategoria.IdSub);
                datos.setearParametros("@IdEspecialista", turno.Especialista.IdEspecialista);
                datos.setearParametros("@Fecha", turno.Fecha);
                datos.setearParametros("@HoraInicio", turno.HoraInicio);
                datos.setearParametros("@HoraFin", turno.HoraFin);
                datos.setearParametros("@Estado", turno.Estado);
                if(idTurno == 0)
                {
                    Id = datos.ejecutarAccionInt();
                    datos.cerrarConn();
                    datos.setearConsulta("update TURNOS set IdTurno = @Id where Id = @Id");
                    datos.setearParametros("@Id", Id);
                    datos.ejecutarAccion();
                }else if(idTurno != 0)
                {
                    datos.setearParametros("@IdTurno", idTurno);
                    datos.ejecutarAccion();
                }
                return Id;
            }
            catch (Exception ex)
            {

                throw ex;

            }finally { datos.cerrarConn(); }
        }

        public void eliminarTurno(Turnos turno)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Turnos where IdTurno = @IdTurno");
                datos.setearParametros("@IdTurno", turno.IdTurno);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool verifDisponible(DateTime fecha, string hora, int idEsp, int idTurno = 0)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if(idTurno != 0)
                {
                    datos.setearConsulta("SELECT COUNT(*) AS CantidadTurnosDisponibles FROM Turnos WHERE Fecha = @Fecha AND HoraInicio = @HoraInicio and Estado = 'Reservado' and IdEspecialista = @idEsp and not IdTurno = @IdTurno");
                    datos.setearParametros("@IdTurno", idTurno);
                }
                else
                {
                    datos.setearConsulta("SELECT COUNT(*) AS CantidadTurnosDisponibles FROM Turnos WHERE Fecha = @Fecha AND HoraInicio = @HoraInicio and Estado = 'Reservado' and IdEspecialista = @idEsp");
                }
                datos.setearParametros("@Fecha", fecha);
                datos.setearParametros("@HoraInicio", hora);
                datos.setearParametros("@idEsp", idEsp);
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
            finally
            {
                datos.cerrarConn();
            }
        }
    }
}
