using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
     public class accesoDatos
    {
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader Lector;

        ///este es para no usar el read
        public SqlDataReader lector
        {
            get { return Lector; }
        }
        public accesoDatos()
        {
            Conexion = new SqlConnection("server=LAPTOP-OTJVIM30\\SQLEXPRESS;database=CATALOGO_DB;integrated security=true");
            Comando = new SqlCommand();
        }

        public void SetearQuery(string consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = consulta;
        }
        // este metodo se hace para ejecutar una sentencia , como tengo que agregar
        //no es una consulta entonces es una nonquery
        public void ejecutarAccion()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearParametros(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void CerrarConexion()
        {
            if (Lector != null)
                Lector.Close();
            Conexion.Close();

        }
    }
}

