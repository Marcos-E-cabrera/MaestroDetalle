using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ConceptoDB
    {
        private string connectionString = "Data Source = .; Database = MaestroDetalle2; Trusted_Connection = True;";

        public void Add(int id_Ventas,Concepto concepto) 
        {
            string query = " INSERT INTO concepto (id_ventas, producto, cantidad, precioUnitario)" +
                " VALUES (@id_ventas, @producto, @cantidad, @precioUnitario)";

            using ( SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(query,connection);

                command.Parameters.AddWithValue("@id_ventas", id_Ventas);
                command.Parameters.AddWithValue("@producto", concepto.Producto);
                command.Parameters.AddWithValue("@cantidad", concepto.Cantidad);
                command.Parameters.AddWithValue("@precioUnitario", concepto.PrecioUnitario);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

            }
        }  
    }
}
