using Clases;

namespace Carniceria_MD
{
    public partial class Form1 : Form
    {
        private List<int> ids = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            try
            {
                VentasDB ventasDB = new VentasDB();

                foreach (var item in ventasDB.Read())
                {

                    if ( !ids.Exists( x => x == item.Id) )
                    {
                        dgvVentas.Rows.Add(item.Id, item.Nombre, item.DateTime);
                        ids.Add(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); 
            Refresh();
        }
    }
}