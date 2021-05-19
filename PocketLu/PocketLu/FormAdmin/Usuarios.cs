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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        string idUsuario;
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
                string llenar = "SELECT * FROM `usuarios`;";
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
            txtContraseña.Text = "";
            txtEdad.Text = "";
            txtNombre.Text = "";
            txtNUsuario.Text = "";
            txtRol.Text = "";
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text= dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtRol.Text = dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtNUsuario.Text = dtgUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtContraseña.Text = dtgUsuarios.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `usuarios`(`nombre`, `apellidos`, `edad`, `rol`, `nombreUsuario`, `Contraseña`) VALUES ('"+txtNombre.Text+"','"+txtApellido.Text+"','"+txtEdad.Text+"','"+txtRol.Text+"','"+txtNUsuario.Text+"','"+txtContraseña.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado un nuevo Usuario");
                cn.Close();
                dtgUsuarios.DataSource = llenar_Grid();
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
                cmd.CommandText = ("UPDATE `usuarios` SET `nombre`='"+txtNombre.Text+"',`apellidos`='"+txtApellido.Text+"',`edad`='"+txtEdad.Text+"',`rol`='"+txtRol.Text+"',`nombreUsuario`='"+txtNUsuario.Text+"',`Contraseña`='"+txtContraseña.Text+"' WHERE `idUsuario`='"+idUsuario+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ha modificado los datos del Usuario");
                cn.Close();
                dtgUsuarios.DataSource = llenar_Grid();
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
                cmd.CommandText = ("DELETE FROM `usuarios` WHERE `idUsuario` ='"+idUsuario+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah eliminado un Usuario");
                cn.Close();
                dtgUsuarios.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            LimpForm();
            ///
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dtgUsuarios.DataSource = llenar_Grid();
        }
    }
}
