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

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Facturas : Form
    {

        public frm_Facturas()
        {
            InitializeComponent();
        }

        Facturas factura = new Facturas();
        private void btn_CargarGrid_Click(object sender, EventArgs e)
        {
            if (txt_Fecha.Visible)
            {
                if (txt_Fecha.Text != "")
                {

                    dataGridView1.DataSource = factura.buscar_Factura_Fecha(txt_Fecha.Text.Trim());
                }
            }
            if (txt_NumFactura.Visible)
            {
                if (txt_NumFactura.Text != "")
                {
                    dataGridView1.DataSource = factura.buscar_Factura_Numero(txt_NumFactura.Text.Trim());
                }
            }
            if (txt_Precio.Visible)
            {
                if (txt_Precio.Text != "")
                {
                    
                }
            }
            if (txt_Cliente.Visible)
            {
                if (txt_Cliente.Text != "")
                {
                    dataGridView1.DataSource = factura.buscar_Factura_Cliente(txt_Cliente.Text.Trim());
                }
            }
        }

        private void rb_numFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_numFactura.Checked)
            {
                this.txt_NumFactura.Visible = true;
                dataGridView1.DataSource = "";
                txt_NumFactura.Focus();
            }
            else
            {
                this.txt_NumFactura.Visible = false;
                dataGridView1.DataSource = "";
            }
        }

        private void rb_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_Cliente.Checked)
            {
                this.txt_Cliente.Visible = true;
                dataGridView1.DataSource = "";
                txt_Cliente.Focus();
            }
            else
            {
                this.txt_Cliente.Visible = false;
                dataGridView1.DataSource = "";
            }
        }

        private void rb_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_Fecha.Checked)
            {
                this.txt_Fecha.Visible = true;
                dataGridView1.DataSource = "";
                txt_Fecha.Focus();
            }
            else
            {
                this.txt_Fecha.Visible = false;
                dataGridView1.DataSource = "";
            }
        }

        private void rb_MontoFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_MontoFactura.Checked)
            {
                this.txt_Precio.Visible = true;
                dataGridView1.DataSource = "";
                txt_Precio.Focus();
            }
            else
            {
                this.txt_Precio.Visible = false;
                dataGridView1.DataSource = "";
            }
        }


    }
}
