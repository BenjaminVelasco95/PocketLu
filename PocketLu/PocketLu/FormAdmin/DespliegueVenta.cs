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
    public partial class DespliegueVenta : Form
    {
        public DespliegueVenta()
        {
            InitializeComponent();
        }
        double precio;
        static string conn = "SERVER = 127.0.0.1; PORT=3306;DATABASE=pocketlu;UID=root;PWD=;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();
        public string idVenta;

        private DataTable Llenar_Grid()
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

        private void DespliegueVenta_Load(object sender, EventArgs e)
        {
            dtgProductos.DataSource = Llenar_Grid();
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProd.Text = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombreProd.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            precio = Convert.ToDouble(dtgProductos.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnAProducto_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `despliegueventa`( `idVenta`, `idProducto`, `nombreProducto`, `cantidad`, `precio`) VALUES ('"+idVenta+"','"+txtIdProd.Text+"','"+txtNombreProd.Text+"','"+txtCantidad.Text+"','"+txtTotal.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah creado el producto al carrito");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///

            ///
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = precio * Convert.ToDouble(txtCantidad.Text);
                txtTotal.Text = Convert.ToString(total);
            }
            catch
            {

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
