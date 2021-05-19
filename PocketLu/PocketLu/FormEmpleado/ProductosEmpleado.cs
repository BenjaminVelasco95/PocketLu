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

namespace PocketLu.FormEmpleado
{
    public partial class ProductosEmpleado : Form
    {
        public ProductosEmpleado()
        {
            InitializeComponent();
        }
        static string conn = "SERVER = 127.0.0.1; PORT=3306;DATABASE=pocketlu;UID=root;PWD=;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        /*METODOS*/
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

        private DataTable BusquedaGrid(string param)
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT * FROM productos WHERE nombre LIKE '%" + param + "%'";
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

        private void ProductosEmpleado_Load(object sender, EventArgs e)
        {
            dtgProductos.DataSource = llenar_Grid();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgProductos.DataSource = BusquedaGrid(txtBusqueda.Text);
            }
            catch
            {

            }
        }
    }
}
