using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria_MD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Cantidad = int.Parse(txtCantidad.Text);
            string Producto = txtProducto.Text;
            decimal Precio = decimal.Parse(txtPrecio.Text);

            dgvConcepto.Rows.Add(new object[] { Cantidad, Producto, Precio, "Eliminar" });

            txtCantidad.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";

            txtCantidad.Focus();


        }


        private void dgvConcepto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvConcepto.Columns["Eliminar"].Index)
                return;

            dgvConcepto.Rows.RemoveAt(e.RowIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VentasDB ventasDB = new VentasDB();
                Venta venta = new Venta(txtCliente.Text, DateTime.Now);

                ventasDB.Add(venta);

                var lst = ventasDB.Read();
                int id_Venta = lst[lst.Count - 1].Id; // Obtenemos el ID de la última venta agregada

                ConceptoDB conceptoDB = new ConceptoDB();

                foreach( DataGridViewRow dr in dgvConcepto.Rows)
                {
                    Concepto concepto = new Concepto(int.Parse(dr.Cells[0].Value.ToString()),
                                                     dr.Cells[1].Value.ToString(),
                                                     decimal.Parse(dr.Cells[2].Value.ToString()));

                    conceptoDB.Add(id_Venta, concepto);
                }


                MessageBox.Show("Cargado con EXITO");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
