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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            ti = new Timer();
            InitializeComponent();
            ti.Enabled = true;
        }
        Timer ti;
        string idCredito = "", idVenta="", curdate;
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
                string llenar = "SELECT * FROM `creditos`;";
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
        private DataTable CombClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idClientes, nombre FROM clientes",cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        private DataTable CombVentas()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idVenta FROM ventas WHERE credito = 'no'", cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        private void LimpForm()
        {
            txtMonto.Text = "";
        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            cbClientes.DataSource = CombClientes();
            cbClientes.ValueMember = "idClientes";
            cbClientes.DisplayMember = "nombre";

            cbVenta.DataSource = CombVentas();
            cbVenta.ValueMember = "idVenta";
            cbVenta.DisplayMember = "idventa";

            DateTime hoy = DateTime.Now;
            curdate = hoy.ToString("yy/MM/dd");
            dtgCreditos.DataSource = llenar_Grid();
        }

        private void cbVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT SUM(precio) FROM despliegueVenta WHERE idVenta = '" + cbVenta.SelectedValue.ToString() + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtMonto.Text = dr[0].ToString();
                }

                cn.Close();
            }
            catch
            {
                MessageBox.Show("Registro Inexistente");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `creditos`(`idCliente`, `idVenta`, `fecha`, `monto`) VALUES ('"+cbClientes.SelectedValue.ToString()+"','"+cbVenta.SelectedValue.ToString()+"','"+curdate+"','"+txtMonto.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                cn.Close();

                cn.Open();
                cmd.CommandText = ("UPDATE ventas SET credito = 'si' WHERE idVenta ='" + cbVenta.SelectedValue.ToString() + "';");
                dr = cmd.ExecuteReader();
                cn.Close();
                MessageBox.Show("Credito Registrado con exito");
                dtgCreditos.DataSource = llenar_Grid();
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
                cmd.CommandText = ("DELETE FROM creditos where idCredito = '"+idCredito+"'");
                MySqlDataReader dr = cmd.ExecuteReader();
                cn.Close();

                cn.Open();
                cmd.CommandText = ("UPDATE ventas SET credito = 'no' WHERE idVenta ='"+idVenta+"';");
                dr = cmd.ExecuteReader();
                cn.Close();
                MessageBox.Show("Se ah eliminado el credito");
                dtgCreditos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///

        }

        private void dtgCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCredito = dtgCreditos.CurrentRow.Cells[0].Value.ToString();
            idVenta = dtgCreditos.CurrentRow.Cells[2].Value.ToString();
            txtMonto.Text = dtgCreditos.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
