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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        string idCliente;
        static string conn = "SERVER = 127.0.0.1; PORT=3306;DATABASE=pocketlu;UID=root;PWD=;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        private DataTable llenar_Grid()
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT * FROM `clientes`;";
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
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dtgClientes.DataSource = llenar_Grid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `clientes`(`nombre`, `apellidos`, `direccion`, `telefono`) VALUES ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "')");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado un nuevo cliente");
                cn.Close();
                dtgClientes.DataSource = llenar_Grid();
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
                cmd.CommandText = ("UPDATE `clientes` SET `nombre`='"+txtNombre.Text+"',`apellidos`='"+txtApellido.Text+"',`direccion`='"+txtDireccion.Text+"',`telefono`='"+txtTelefono.Text+"' WHERE `idClientes`='"+idCliente+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Los datos del cliente han sido modificados");
                cn.Close();
                dtgClientes.DataSource = llenar_Grid();
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
                cmd.CommandText = ("DELETE FROM `clientes` WHERE `idClientes` ='"+idCliente+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Los datos del cliente han sido Eliminados");
                cn.Close();
                dtgClientes.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = dtgClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dtgClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dtgClientes.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
