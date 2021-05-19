using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PocketLu.FormAdmin;

namespace PocketLu
{
    public partial class IndexAdmin : Form
    {
        public IndexAdmin()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }
        private Timer ti;
        public string rol;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /*Metodos*/
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RetraerSubmenu()
        {
            if (pMenuVertical.Width == 250)
                pMenuVertical.Width = 65;
        }
        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy =DateTime.Now;
            lblReloj.Text = hoy.ToString("f");

        }

        /*Al cargar el form*/
        private void IndexAdmin_Load(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                btnCredito.Visible = false;
                btnClientes.Visible = false;
                btnUsuarios.Visible = false;
                btnReportes.Visible = false;
            }
        }

        /*Desplazamiento de la barra de botones*/
        private void btnSlideMenu_Click(object sender, EventArgs e)
        {
            if (pMenuVertical.Width == 250)
                pMenuVertical.Width = 65;
            else
                pMenuVertical.Width = 250;
        }
        /*Botones de la ventana*/
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Login ver = new Login();
            ver.Show();
            this.Close();
        }

        private void iconMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaxi.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconMaxi.Visible = true;
            iconRestaurar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*Movimiento de la ventana*/
        private void pBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        /*Botones de la ventana*/
        private void btnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new Ventas());
            RetraerSubmenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductosAdmin());
            RetraerSubmenu();
        }

        
    }
}
