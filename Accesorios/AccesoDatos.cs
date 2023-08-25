
using Microsoft.Data.SqlClient;

namespace Accesorios
{
    public class AccesoDatos
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            try
            {
                conn = new SqlConnection("server = .\\SQLEXPRESS ; database = MYLA_DB ; integrated security = true;Encrypt=False ; Trusted_Connection=True ");
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta (string consulta)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();
                lector = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearParametros(string nombre, object valor)
        {
            try
            {
                cmd.Parameters.AddWithValue(nombre, valor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConn()
        {
            try
            {
                cmd.Parameters.Clear();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}