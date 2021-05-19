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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            ti = new Timer();
            InitializeComponent();
            ti.Enabled = true;
        }
        Timer ti;
        string curdate, idVenta ="", idVenta2 ="", idDespliegue ="";
        double totalCompra;
        static string conn = "SERVER = 127.0.0.1; PORT=3306;DATABASE=pocketlu;UID=root;PWD=;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();
        
        private DataTable GridVentas()
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT * FROM `ventas`;";
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

        private DataTable GridDespliegue(string idV)
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT * FROM `despliegueventa` WHERE idVenta = " + idV + ";";
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
         /*ventas*/
        private void Ventas_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            curdate = hoy.ToString("yy/MM/dd");
            dtgVentas.DataSource = GridVentas();
        }

        private void dtgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DespliegueVenta ob = new DespliegueVenta();
            idVenta = dtgVentas.CurrentRow.Cells[0].Value.ToString();
            ob.idVenta = dtgVentas.CurrentRow.Cells[0].Value.ToString();
            dtgDVentas.DataSource = GridDespliegue(idVenta);
        }

        private void btnNVenta_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `ventas`(`fecha`) VALUES ('" + curdate + "');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah creado la venta");
                cn.Close();
                dtgVentas.DataSource = GridVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///

            ///
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = (" DELETE FROM `ventas` WHERE idVenta = '" + idVenta + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah cancelado la venta seleccionada");
                cn.Close();
                dtgVentas.DataSource = GridVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///

            ///
        }

        private void btnAProducto_Click(object sender, EventArgs e)
        {
            if (idVenta == "")
            {
                MessageBox.Show("porfavor seleccione una venta");
            }
            else
            {
                DespliegueVenta ver = new DespliegueVenta();
                ver.idVenta = idVenta;
                ver.Show();
            }
        }

        private void btnEProducto_Click(object sender, EventArgs e)
        {
            if (idDespliegue == "" && idVenta2 == "")
            {
                MessageBox.Show("Porfavor Selecciona un producto");
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = ("DELETE FROM `despliegueventa` WHERE idVenta ='" + idVenta2 + "' AND idDespliegue ='"+idDespliegue+"';");
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Se ah cancelado la venta seleccionada");
                    cn.Close();
                    dtgDVentas.DataSource = GridDespliegue(idVenta2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
                }
                ///

                ///
            }
        }

        private void dtgDVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idDespliegue = dtgDVentas.CurrentRow.Cells[0].Value.ToString();
            idVenta2 = dtgDVentas.CurrentRow.Cells[1].Value.ToString();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntDellProdcutos_Click(object sender, EventArgs e)
        {
            if (idVenta == "")
            {
                MessageBox.Show("Porfavor seleccione una venta");
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = ("DELETE FROM `despliegueventa` WHERE `idVenta` = '"+idVenta+"';");
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Se ah cancelado la venta seleccionada");
                    cn.Close();
                    dtgDVentas.DataSource = GridDespliegue(idVenta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
                }
                ///

                ///
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (pCobro.Visible == false)
                pCobro.Visible = true;
                
            else 
            { 
                pCobro.Visible = false;
                txtCPago.Text = "";
                lblTotalPagar.Text ="";
                lblCambio.Text = "";
            }
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT SUM(precio) FROM `despliegueventa` WHERE `idVenta` = '" + idVenta + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    totalCompra = Convert.ToDouble(dr[0].ToString());
                    lblTotalPagar.Text = totalCompra.ToString();
                }
                cn.Close();
            }   
            catch
            {

            }
        }

        private void txtCPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(txtCPago.Text) - totalCompra;
                lblCambio.Text = total.ToString();
            }
            catch
            {

            }
        }
    }
}
