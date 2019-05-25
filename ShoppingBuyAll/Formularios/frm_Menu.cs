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
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll
{
    public partial class frm_Menu : Form
    {

  

        public frm_Menu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_rest.Visible = true;
        }

        private void btn_rest_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_rest.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_De_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormaHija(object formhija)
        {

            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Clientes2());
        }

        private void btn_Automoviles_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Automoviles2());
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Productos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Locales());
        }


        private void frm_Menu_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = DateTime.Now.ToShortTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }


       

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Compras());
        }

        private void btnEstacionamiento_Click(object sender, EventArgs e)
        {
            if (panelSubmenu.Visible)
            {
                panelSubmenu.Visible = false;
            }
            else
            {
                panelSubmenu.Visible = true;
            }
            
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new Ingreso_Estacionamiento());
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new salida_estacionamiento());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frm_Facturas());
        }
        //AGREGO UN COMENTARIO DE MIERDA
    }
}
