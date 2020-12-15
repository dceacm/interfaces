using interfaces.Modelos;
using interfaces.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Conexion
{
    public class ConexionBDcs
    {
        public string connectionString = Settings.Default.connectionString;

        public void AnadirDocumento(Documento documento)
        {
            string queryString = "INSERT Documento VALUES(@carpeta, @ordenCarpeta, @fecha, @contenido, @clave1, @clave2, @clave3 );";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", documento.Carpeta);
                cmd.Parameters.AddWithValue("@ordenCarpeta", documento.OrdenCarpeta);
                cmd.Parameters.AddWithValue("@fecha", documento.Fecha);
                cmd.Parameters.AddWithValue("@contenido", documento.Contenido);
                cmd.Parameters.AddWithValue("@clave1", documento.Clave1);
                cmd.Parameters.AddWithValue("@clave2", documento.Clave2);
                cmd.Parameters.AddWithValue("@clave3", documento.Clave3);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public string GetLastID()
        {
            string id = string.Empty;
            string queryString = "SELECT ISNULL((SELECT TOP 1 OrdenCarpeta FROM Documento ORDER BY OrdenCarpeta DESC),0);";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {

                con.Open();
                id = (int.Parse(cmd.ExecuteScalar().ToString())+1).ToString();              
            }
            return id;
        }
    }
}
