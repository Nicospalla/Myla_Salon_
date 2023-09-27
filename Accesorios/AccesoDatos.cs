
using Microsoft.Data.SqlClient;

namespace Accesorios
{
    public class AccesoDatos
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader lector;
        public string connString { get; set; }
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos(int creation = 0)
        {
            try
            {
                //conn = new SqlConnection("workstation id=MYLA_DB.mssql.somee.com;packet size=4096;user id=flomaza_SQLLogin_1;pwd=sn3d2lepjq;data source=MYLA_DB.mssql.somee.com;persist security info=False;initial catalog=MYLA_DB; Encrypt=False");
                if (creation != 0)
                {
                    connString = "server = .\\SQLEXPRESS ; integrated security= true ; Encrypt = false ;  Trusted_Connection = true";
                }
                else
                {
                    connString = "server = .\\SQLEXPRESS ; database = MYLA_DB ; integrated security = true;Encrypt=False ; Trusted_Connection=True ";
                }
                conn = new SqlConnection(connString);
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool verificarExisteciaDDBB()
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta(string consulta)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
        }
        public void setearStoredProcedure(string procedure)
        {
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = procedure;
            }
            catch (Exception ex)
            {

                throw;
            }
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
        public int ejecutarAccionInt()
        {
            int idEsp;
            try
            {
                cmd.Connection = conn;
                conn.Open();
                idEsp = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return idEsp;
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