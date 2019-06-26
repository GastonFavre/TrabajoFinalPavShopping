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

        int LX, LY;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?","Alerta",MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btn_max.Visible = false;
            btn_rest.Visible = true;
        }

        private void btn_rest_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(924, 788);
            this.Location = new Point(LX, LY);
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
                this.panel_contenedor.Controls.RemoveAt(1);
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

        private void btn_buscarFiltrado_Click(object sender, EventArgs e)
        {
            AbrirFormaHija(new frm_EstacionamientoFiltrado());
        }

        private void btn_abm_clientes_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Clientes2());
        }

        private void btn_filtro_cliente_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_clientes_filtrados());
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            AbrirFormaHija(new frm_Reporte());
        }

        private void panel_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

    }
        //AGREGO UN COMENTARIO DE MIERDA
    
}
