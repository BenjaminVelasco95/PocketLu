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
using System.Runtime.InteropServices;
using PocketLu.FormAdmin;

namespace PocketLu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        static string conn = "SERVER = 127.0.0.1; PORT=3306;DATABASE=pocketlu;UID=root;PWD=;";
        MySqlConnection cn = new MySqlConnection(conn);
        
        /*boton Salir*/
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Desplazamiento de la barra*/
        private void pBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*Acceder*/
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT `nombre`, `apellidos`, `rol`, `nombreUsuario`, `Contraseña` FROM `usuarios` WHERE `nombreUsuario` = '"+txtUsuario.Text+"' AND `Contraseña`='"+txtContraseña.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string rol = Convert.ToString(dr[2]);
                    IndexAdmin ver = new IndexAdmin();
                    MessageBox.Show("Bienvenido " + Convert.ToString(dr[0]) + " " + Convert.ToString(dr[1]));
                    ver.rol = Convert.ToString(dr[2]);
                    ver.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }

                cn.Close();
            }
            catch
            {

            }
        }
    }
}
