using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class VentasDB
    {
        private string connectionString = "Data Source = .; Database = MaestroDetalle2; Trusted_Connection = True;";

        public List<Venta> Read()
        {
            List<Venta> ventas = new List<Venta> ();

            string query = "SELECT * FROM ventas" ;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                var reader = command.ExecuteReader();
                
                while (reader.Read()) 
                {
                    ventas.Add(new Venta(int.Parse(reader["id"].ToString()),
                                        reader["nombre"].ToString(),
                                        DateTime.Parse(reader["fecha"].ToString())));
                }

                reader.Close();
                connection.Close();
            }

            return ventas;
        }

        public void Add(Venta venta)
        {
            string query = " INSERT INTO ventas (nombre, fecha)" +
                " VALUES (@nombre, @fecha)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", venta.Nombre);
                command.Parameters.AddWithValue("@fecha", venta.DateTime);
                 
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

            }
        }
    }
}
