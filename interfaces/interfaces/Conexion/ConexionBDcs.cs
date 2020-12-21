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

        public void AnadirCarpeta(Documento documento)
        {
            string queryString = "IF NOT EXISTS (SELECT * FROM Carpeta WHERE CarpetaId = @carpeta) BEGIN INSERT Carpeta(CarpetaId) VALUES(@carpeta) END;";
         
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {            
                cmd.Parameters.AddWithValue("@carpeta", int.Parse(documento.Carpeta));
              
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool AnadirDocumento(Documento documento)
        {
            bool anadir = false;
            AnadirCarpeta(documento);
            string queryString = string.Empty;

            if (string.IsNullOrEmpty(documento.Clave2))
            {
                queryString = "INSERT Documento VALUES(@carpeta,@ordenCarpeta, @fecha, @contenido, @clave1, null, null);";
            }
            else if (string.IsNullOrEmpty(documento.Clave3))
            {
                queryString = "INSERT Documento VALUES(@carpeta,@ordenCarpeta, @fecha, @contenido, @clave1, @clave2, null);";
            }
            else
            {
                queryString = "INSERT Documento VALUES(@carpeta,@ordenCarpeta, @fecha, @contenido, @clave1, @clave2, @clave3 );";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", int.Parse(documento.Carpeta));
                cmd.Parameters.AddWithValue("@ordenCarpeta", int.Parse(documento.OrdenCarpeta));
                cmd.Parameters.AddWithValue("@fecha", documento.Fecha);
                cmd.Parameters.AddWithValue("@contenido", documento.Contenido);
                cmd.Parameters.AddWithValue("@clave1", documento.Clave1);

                if (!string.IsNullOrEmpty(documento.Clave2))
                {
                    cmd.Parameters.AddWithValue("@clave2", documento.Clave2);
                }

                if (!string.IsNullOrEmpty(documento.Clave3))
                {
                    cmd.Parameters.AddWithValue("@clave3", documento.Clave3);
                }

                con.Open();
                cmd.ExecuteNonQuery();
                anadir = true;
            }
            return anadir;
        }
        public string GetLastID(String text)
        {
            string id = string.Empty;
            string queryString = "SELECT ISNULL((SELECT TOP 1 OrdenCarpeta FROM Documento WHERE carpeta=@carpeta ORDER BY OrdenCarpeta DESC),0);";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", int.Parse(text));
                con.Open();
                id = (int.Parse(cmd.ExecuteScalar().ToString())+1).ToString().PadLeft(3,'0');              
            }
            return id;
        }

        public void EliminarDocumento(Documento documento)
        {
            string queryString = "DELETE DOCUMENTO WHERE carpeta=@carpeta AND ordenCarpeta=@ordenCarpeta AND fecha=@fecha AND " +
                                    "contenido=@contenido AND clave1=@clave1;";

            //int count=CountDocumentos(documento.Carpeta);

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", int.Parse(documento.Carpeta));
                cmd.Parameters.AddWithValue("@ordenCarpeta", int.Parse(documento.OrdenCarpeta));
                cmd.Parameters.AddWithValue("@fecha", documento.Fecha);
                cmd.Parameters.AddWithValue("@contenido", documento.Contenido);
                cmd.Parameters.AddWithValue("@clave1", documento.Clave1);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ModificarDocumento(Documento documentoOrigen, Documento documento)
        {
            string queryString = "UPDATE Documento SET carpeta=@carpeta, ordenCarpeta=@ordenCarpeta, fecha=@fecha, " +
                                    "contenido=@contenido, clave1=@clave1, clave2=@clave2, clave3=@clave3 " +
                                    "WHERE carpeta=@carpetaOr AND " +
                                    "ordenCarpeta=@ordenCarpetaOr AND fecha=@fechaOr AND contenido=@contenidoOr AND " +
                                    "clave1=@clave1Or AND clave2=@clave2Or AND clave3=@clave3Or;";
            
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", int.Parse(documento.Carpeta));
                cmd.Parameters.AddWithValue("@ordenCarpeta", int.Parse(documento.OrdenCarpeta));
                cmd.Parameters.AddWithValue("@fecha", documentoOrigen.Fecha);
                cmd.Parameters.AddWithValue("@contenido", documentoOrigen.Contenido);
                cmd.Parameters.AddWithValue("@clave1", documentoOrigen.Clave1);
                cmd.Parameters.AddWithValue("@clave2", documentoOrigen.Clave2);
                cmd.Parameters.AddWithValue("@clave3", documentoOrigen.Clave3);

                cmd.Parameters.AddWithValue("@carpetaOr", int.Parse(documento.Carpeta));
                cmd.Parameters.AddWithValue("@ordenCarpetaOr", int.Parse(documento.OrdenCarpeta));
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

        public int CountDocumentos(string carpeta)
        {
            string queryString = "SELECT COUNT(*) FROM DOCUMENTO WHERE carpeta=@carpeta";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@carpeta", carpeta);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }

        public List<Documento> GetDocumentos(string queryString) {
            List<Documento> list = new List<Documento>();
            
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string carpeta = reader["Carpeta"].ToString();
                        string ordenCarpeta = reader["OrdenCarpeta"].ToString();
                        DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                        string contenido = reader["Contenido"].ToString();
                        string clave1 = reader["Clave1"].ToString();
                        string clave2 = reader["Clave2"].ToString();
                        string clave3 = reader["Clave3"].ToString();

                        Documento d = new Documento(carpeta, ordenCarpeta, fecha, contenido, clave1, clave2, clave3);
                        list.Add(d);
                    }
                }
                
            }

            return list;
        }

    }
}
