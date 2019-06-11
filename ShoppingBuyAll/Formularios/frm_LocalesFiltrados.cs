using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.clases;
using System.Runtime.InteropServices;
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_LocalesFiltrados : Form
    {
        public frm_LocalesFiltrados()
        {
            InitializeComponent();
        }
        Locales obj_local = new Locales();
        Validar validacion = new Validar();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frm_LocalPorTipo_Load(object sender, EventArgs e)
        {
            this.cmb_tipoCom.cargar("Tipo_Comercio", "id_tipoC", "descripcion");
            validacion.blanquear_objetos(this.Controls);
        }

        private void Barra_De_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_rest.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_rest.Visible = true;
        }

        private void txt_cuil_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_cuil.Enabled == true)
            {
                this.txt_cuil.Enabled = false;
                this.txt_cuil.Text = "";
            }
            else
            {
                this.txt_cuil.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_Nom.Enabled == true)
            {
                this.txt_Nom.Enabled = false;
                this.txt_Nom.Text = "";
            }
            else
            {
                this.txt_Nom.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cmb_tipoCom.Enabled == true)
            {
                this.cmb_tipoCom.Enabled = false;
                this.cmb_tipoCom.SelectedIndex = -1;
            }
            else
            {
                this.cmb_tipoCom.Enabled = true;
            }
        }

        public void recuperarDatos()
        {
            DataTable tabla_filtro = new DataTable();
            tabla_filtro = obj_local.buscar_local_filtrado(this.Controls);
            datagrid_filtro.DataSource = tabla_filtro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacion.validar_Form(this.Controls) == 0)
            {
                recuperarDatos();
            }
            else
            {
                if (this.txt_cuil.Text != "")
                {
                    recuperarDatos();
                    return;
                }
                if (this.txt_Nom.Text != "")
                {
                    recuperarDatos();
                    return;
                }                
                if (this.cmb_tipoCom.SelectedIndex != -1)
                {
                    recuperarDatos();
                    return;
                }

                MessageBox.Show("No se ha seleccionado ningun campo");
            }
        }
    }
}
