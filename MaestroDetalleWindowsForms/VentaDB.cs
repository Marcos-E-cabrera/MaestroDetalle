using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MaestroDetalleWindowsForms
{
    public class VentaDB
    {
        private string connectionString = "Data Source = .; Database = MaestroDetalleProcedimiento; Trusted_Connection = True;";


        public void add(string cliente, List<Concepto> lst)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var dt = new DataTable();

                dt.Columns.Add("Id");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Precio");

                int i = 1; // id
                foreach ( var oElement in lst ) 
                {
                    dt.Rows.Add(i, oElement.Cantidad, oElement.Nombre, oElement.Precio);
                    i++;
                }



                SqlCommand command = new SqlCommand("spGardarVenta", connection);
                var parametrosLista = new SqlParameter("@lstConceptos", SqlDbType.Structured);
                parametrosLista.TypeName = "dbo.Detail";
                parametrosLista.Value = dt;

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(parametrosLista);
                command.Parameters.AddWithValue("@cliente", cliente);   

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close(); 
            }
        }
    }
}