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
using ShoppingBuyAll.clases;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_clientes_filtrados : Form
    {

        Cliente2 cliente = new Cliente2();
        Validar validacion = new Validar();

        public frm_clientes_filtrados()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_rest.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_rest.Visible = true;
        }

        private void Barra_De_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacion.validar_Form(this.Controls) == 0)
            {
                recuperarDatos();
            }
            else
            {
                if (this.cmb_tipoDoc.SelectedIndex != -1)
                {
                    recuperarDatos();
                    return;
                }
                if(this.txt_Ape.Text != "")
                {
                    recuperarDatos();
                    return;
                }
                if(this.txt_Nom.Text != "")
                {
                    recuperarDatos();
                    return;
                }
                if(this.txt_NumDoc.Text != "")
                {
                    recuperarDatos();
                    return;
                }
                if(this.txtCalle.Text != "")
                {
                    recuperarDatos();
                    return;
                }
                if(this.cmbBarrio.SelectedIndex != -1)
                {
                    recuperarDatos();
                    return;
                }
                if(this.cmbEstadoCivil.SelectedIndex != -1)
                {
                    recuperarDatos();
                    return;
                }
                if(this.cmbSexo.SelectedIndex != -1)
                {
                    recuperarDatos();
                    return;
                }

                MessageBox.Show("No se ha seleccionado ningun campo");
            }
        }


        public void recuperarDatos()
        {
            DataTable tabla_filtro = new DataTable();
            tabla_filtro = cliente.buscar_cliente_filtrado(this.Controls);
            datagrid_filtro.DataSource = tabla_filtro;
        }

        private void Barra_De_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoDoc.Enabled == true)
            {
                this.cmb_tipoDoc.Enabled = false;
                this.cmb_tipoDoc.SelectedIndex = -1;
            }
            else
            {
                this.cmb_tipoDoc.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_NumDoc.Enabled == true)
            {
                this.txt_NumDoc.Enabled = false;
                this.txt_NumDoc.Text = "";
            }
            else
            {
                this.txt_NumDoc.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_Ape.Enabled == true)
            {
                this.txt_Ape.Enabled = false;
                this.txt_Ape.Text = "";
            }
            else
            {
                this.txt_Ape.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtCalle.Enabled == true)
            {
                this.txtCalle.Enabled = false;
                this.txtCalle.Text = "";
            }
            else
            {
                this.txtCalle.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbBarrio.Enabled == true)
            {
                this.cmbBarrio.Enabled = false;
                this.cmbBarrio.SelectedIndex = -1;
            }
            else
            {
                this.cmbBarrio.Enabled = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbEstadoCivil.Enabled == true)
            {
                this.cmbEstadoCivil.Enabled = false;
                this.cmbEstadoCivil.SelectedIndex = -1;
            }
            else
            {
                this.cmbEstadoCivil.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbSexo.Enabled == true)
            {
                this.cmbSexo.Enabled = false;
                this.cmbSexo.SelectedIndex = -1;
            }
            else
            {
                this.cmbSexo.Enabled = true;
            }
        }

        private void frm_clientes_filtrados_Load(object sender, EventArgs e)
        {
            this.cmbBarrio.cargar("Barrio", "id_barrio", "nombre");
            this.cmbSexo.cargar("Sexo", "id_sex", "nombre");
            this.cmb_tipoDoc.cargar("Tipo_Documento", "id_doc", "descripcion");
            this.cmbEstadoCivil.cargar("Estado_Civil", "id_estado", "nombre");
            validacion.blanquear_objetos(this.Controls);
        }

        
    }
}
