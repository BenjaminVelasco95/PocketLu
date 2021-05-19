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
        string idProducto="";
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

        private void LimpForm()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
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
            idProducto = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dtgProductos.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `productos`(`nombre`, `precio`) VALUES ('" + txtNombre.Text + "','" + txtPrecio.Text + "');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado el prodcuto con éxito");
                cn.Close();
                dtgProductos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("UPDATE `productos` SET `nombre`='" + txtNombre.Text + "',`precio`='" + txtPrecio.Text + "' WHERE `idProducto`='" + idProducto + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah modificado el producto con éxito");
                cn.Close();
                dtgProductos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("DELETE FROM productos WHERE idProducto = '" + idProducto + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ha eliminado el producto");
                cn.Close();
                dtgProductos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpForm();
        }
    }
}
