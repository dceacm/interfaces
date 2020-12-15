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
            string queryString = "SELECT TOP 1 OrdenCarpeta FROM Documento ORDER BY OrdenCarpeta DESC;";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = (int.Parse(reader["OrdenCarpeta"].ToString()) + 1).ToString();
                    }
                }
            }
            return id;
        }

        public void EliminarDocumento(Documento documento)
        {
            string queryString = "DELETE FROM DOCUMENTO WHERE carpeta=@carpeta, ordenCarpeta=@ordenCarpeta, fecha=@fecha, " +
                "contenido=@contenido, clave1=@clave1, clave2=@clave2, clave3=@clave3;)";

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
                con.Close();
            }
        }

        public void ModificarDocumento(Documento documentoOrigen, Documento documento)
        {
            string queryString = "UPDATE DOCUMENTO SET carpeta=@carpeta, ordenCarpeta=@ordenCarpeta, fecha=@fecha, " +
                "contenido=@contenido, clave1=@clave1, clave2=@clave2, clave3=@clave3 WHERE carpeta=@carpetaOr, " +
                "ordenCarpeta=@ordenCarpetaOr, fecha=@fechaOr, contenido=@contenidoOr, clave1=@clave1Or, " +
                "clave2=@clave2Or, clave3=@clave3Or";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", documentoOrigen.Carpeta);
                cmd.Parameters.AddWithValue("@ordenCarpeta", documentoOrigen.OrdenCarpeta);
                cmd.Parameters.AddWithValue("@fecha", documentoOrigen.Fecha);
                cmd.Parameters.AddWithValue("@contenido", documentoOrigen.Contenido);
                cmd.Parameters.AddWithValue("@clave1", documentoOrigen.Clave1);
                cmd.Parameters.AddWithValue("@clave2", documentoOrigen.Clave2);
                cmd.Parameters.AddWithValue("@clave3", documentoOrigen.Clave3);

                cmd.Parameters.AddWithValue("@carpetaOr", documento.Carpeta);
                cmd.Parameters.AddWithValue("@ordenCarpetaOr", documento.OrdenCarpeta);
                cmd.Parameters.AddWithValue("@fechaOr", documento.Fecha);
                cmd.Parameters.AddWithValue("@contenidoOr", documento.Contenido);
                cmd.Parameters.AddWithValue("@clave1Or", documento.Clave1);
                cmd.Parameters.AddWithValue("@clave2Or", documento.Clave2);
                cmd.Parameters.AddWithValue("@clave3Or", documento.Clave3);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
