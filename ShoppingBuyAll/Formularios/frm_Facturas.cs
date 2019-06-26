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
            
        }

        private void rb_numFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_numFactura.Checked)
            {
                this.txt_NumFactura.Text = "";
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
                this.txt_Cliente.Text = "";
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
                this.txt_Fecha.Text = "";
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
                this.txt_Precio.Text = "";
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

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Fecha.Visible)
            {
                if (txt_Fecha.Text != "")
                {

                    dataGridView1.DataSource = factura.buscar_Factura_Fecha(txt_Fecha.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo para realizar la busqueda por filtro");
                    return;
                }
            }
            if (txt_NumFactura.Visible)
            {
                if (txt_NumFactura.Text != "")
                {
                    dataGridView1.DataSource = factura.buscar_Factura_Numero(txt_NumFactura.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo para realizar la busqueda por filtro");
                    return;
                }
            }
            if (txt_Precio.Visible)
            {
                if (txt_Precio.Text != "")
                {
                    dataGridView1.DataSource = factura.buscar_Factura_precio(txt_Precio.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo para realizar la busqueda por filtro");
                    return;
                }
            }
            if (txt_Cliente.Visible)
            {
                if (txt_Cliente.Text != "")
                {
                    dataGridView1.DataSource = factura.buscar_Factura_Cliente(txt_Cliente.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo para realizar la busqueda por filtro");
                    return;
                }
            }

            //int c = dataGridView1.Rows.Count;
            //for (int i = 0; i < c-1; i++)
            //{
            //    if (i == 0)
            //    {
            //        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //    }
            //    else
            //    {
            //        if (dataGridView1.Rows[i].Cells[0].Value != dataGridView1.Rows[i - 1].Cells[0].Value)
            //        {
            //            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //        }
            //        else
            //        {
            //            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //        }
            //    }
                
            //}
        }

        private void frm_Facturas_Load(object sender, EventArgs e)
        {

        }
    }
}
