using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PocketLu.FormAdmin
{
    public partial class ProductosAdmin : Form
    {
        public ProductosAdmin()
        {
            InitializeComponent();
        }
        static string conn = "SERVER = 127.0.0.1; PORT=3306;DATABASE=pocketlu;UID=root;PWD=;"; 
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();
        /*Metodos*/
        private DataTable llenar_Grid()
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT * FROM `productos`;";
                MySqlCommand cmd = new MySqlCommand(llenar, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        /*cargar el form*/
        private void ProductosAdmin_Load(object sender, EventArgs e)
        {
            IndexAdmin ob = new IndexAdmin();
            if (ob.rol == "Empleado")
            {
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
            }
            dtgProductos.DataSource = llenar_Grid();
        }
        /*Cerrar formulario actual*/
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dtgProductos.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
