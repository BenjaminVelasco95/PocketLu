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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            ti = new Timer();
            InitializeComponent();
            ti.Enabled = true;
        }
        string curdate;
        Timer ti;
        string idGasto="";
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
                string llenar = "SELECT * FROM `gastos`;";
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
            txtDescrip.Text = "";
            txtMonto.Text = "";
        }
        private void Gastos_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            curdate = hoy.ToString("yy/MM/dd");
            dtgGastos.DataSource = llenar_Grid();
        }

        private void dtgGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idGasto = dtgGastos.CurrentRow.Cells[0].Value.ToString();
            txtDescrip.Text = dtgGastos.CurrentRow.Cells[1].Value.ToString();
            txtMonto.Text = dtgGastos.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `gastos`(`Descripcion`, fecha, `Monto`) VALUES ('"+txtDescrip.Text+"','"+curdate+"','"+txtMonto.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Gasto Registrado con exito");
                cn.Close();
                dtgGastos.DataSource = llenar_Grid();
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
                cmd.CommandText = ("UPDATE `gastos` SET `Descripcion`='"+txtDescrip.Text+"',`Monto`='"+txtMonto.Text+"' WHERE `idGasto`='"+idGasto+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se modifico el registro con exito");
                cn.Close();
                dtgGastos.DataSource = llenar_Grid();
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
                cmd.CommandText = ("DELETE FROM `gastos` WHERE idGasto = '"+idGasto+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Registro eliminado");
                cn.Close();
                dtgGastos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///
        }
    }
}
