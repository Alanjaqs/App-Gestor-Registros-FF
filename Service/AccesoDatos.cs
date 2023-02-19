using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Service
{
    public class AccesoDatos
    {
        // Atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        // Constructor

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=FINALFANTASY_DB; integrated security=true");
            comando = new SqlCommand();
        }

        // Propiedades

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // Metodos

        // Metodo para realizar una consulta SQL
        public void SetConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        // Metodo para ejecutar una lectura SQL (Select)
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // Metodo para ejecutar una accion SQL (Insert/Update/Delete)

        public void EjecutarAccion()
        {

            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo para inyectar parámetro en consulta
        public void SetParametro(string nombre, object value)
        {
            comando.Parameters.AddWithValue(nombre, value);
        }

        // Metodo para cerrar la conexión
        public void CerrarConexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
