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

        private void rb_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Fecha.Checked)
            {
                txt_FechaDesde.Enabled = true;
                txt_FechaHasta.Enabled = true;
                txt_FechaDesde.Focus();
            }
            else
            {
                txt_FechaDesde.Enabled = false;
                txt_FechaHasta.Enabled = false;
                txt_FechaDesde.Text = "";
                txt_FechaHasta.Text = "";
            }
        }

        private void rb_MontoFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_MontoFactura.Checked)
            {
                txt_PrecioDesde.Enabled = true;
                txt_PrecioDesde.Focus();
            }
            else
            {
                txt_PrecioDesde.Enabled = false;
                txt_PrecioHasta.Enabled = false;
                txt_PrecioDesde.Text = "";
                txt_PrecioHasta.Text = "";
            }
        }

        private void rb_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Cliente.Checked)
            {
                txt_Cliente.Enabled = true;
                txt_Cliente.Focus();
            }
            else
            {
                txt_Cliente.Enabled = false;
                txt_Cliente.Text = "";
            }
        }

        private void rb_numFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_numFactura.Checked)
            {
                txt_NumFactura.Enabled = true;
                txt_NumFactura.Focus();
            }
            else
            {
                txt_NumFactura.Enabled = false;
                txt_NumFactura.Text = "";
            }
        }

        private void txt_PrecioDesde_TextChanged(object sender, EventArgs e)
        {
            txt_PrecioHasta.Enabled = true;
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            string comando_sql = "";
            string comando_sql_having = "";

            //CADENA DE NUMERO FACTURA
            if (rb_numFactura.Checked)
            {
                if (txt_NumFactura.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por numero de factura, por ende debe escribir un numero.");
                    txt_NumFactura.Focus();
                    return;
                }
                else
                {
                    comando_sql = comando_sql + " WHERE " + txt_NumFactura._campo + " = " + txt_NumFactura.Text.Trim();
                }
            }

            //CADENA DE PRECIO
            if (rb_MontoFactura.Checked)
            {

                if (txt_PrecioDesde.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por precio, por ende debe escribir un precio desde y un precio hasta.");
                    txt_PrecioDesde.Focus();
                    return;
                }
                if (txt_PrecioHasta.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por precio, por ende debe escribir un precio desde y un precio hasta.");
                    txt_PrecioHasta.Focus();
                    return;
                }
                if (int.Parse(txt_PrecioDesde.Text) > int.Parse(txt_PrecioHasta.Text))
                {
                    MessageBox.Show("El precio desde debe ser menor al precio hasta.");
                    txt_PrecioDesde.Text = "";
                    txt_PrecioHasta.Text = "";
                    txt_PrecioDesde.Focus();
                    return;
                }
                if (comando_sql_having == "")
                {
                    comando_sql_having = comando_sql_having + @"GROUP BY C.nro_factura, CL.nombres, CL.apellido
                                                                HAVING SUM(P.precio * D.cantidad) BETWEEN " + txt_PrecioDesde.Text.Trim() + " AND " + txt_PrecioHasta.Text.Trim();
                }

            }

            //CADENA DE CLIENTE
            if (rb_Cliente.Checked)
            {
                if (txt_Cliente.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por nombre de cliente, por ende debe escribir uno.");
                    txt_Cliente.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + txt_Cliente._campo + " LIKE '%" + txt_Cliente.Text.Trim() + "%'";
                }
                else
                {
                    comando_sql = comando_sql + " AND  " + txt_Cliente._campo + " LIKE '%" + txt_Cliente.Text.ToString() + "%'";
                }
            }

            //CADENA DE FECHA
            if (rb_Fecha.Checked)
            {

                if (txt_FechaDesde.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por fecha, por ende debe escribir una fecha desde y una fecha hasta.");
                    txt_FechaDesde.Focus();
                    return;
                }
                if (txt_FechaHasta.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por fecha, por ende debe escribir una fecha desde y una fecha hasta.");
                    txt_FechaHasta.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + txt_FechaDesde._campo + " BETWEEN CONVERT(char(10),'" + txt_FechaDesde.Text.Trim() + "',103) AND CONVERT(char(10),'" + txt_FechaHasta.Text.Trim() + "',103)";
                }
                else
                {
                    comando_sql = comando_sql + " AND " + txt_FechaDesde._campo + " BETWEEN CONVERT(char(10),'" + txt_FechaDesde.Text.Trim() + "', 103) AND CONVERT(char(10),'" + txt_FechaHasta.Text.Trim() + "', 103)";
                }

            }

            DataTable tabla = new DataTable();
            tabla = factura.buscar_facturaFiltrado(comando_sql, comando_sql_having);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encuentra ningun producto segun la busqueda realizada.");
            }
            else
            {
                dataGridView1.DataSource = tabla;
            }


        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            txt_Cliente.Enabled = false;
            txt_Cliente.Text = "";
            txt_FechaDesde.Enabled = false;
            txt_FechaDesde.Text = "";
            txt_FechaHasta.Enabled = false;
            txt_FechaHasta.Text = "";
            txt_NumFactura.Enabled = false;
            txt_NumFactura.Text = "";
            txt_PrecioDesde.Enabled = false;
            txt_PrecioDesde.Text = "";
            txt_PrecioHasta.Enabled = false;
            txt_PrecioHasta.Text = "";
            rb_Cliente.Checked = false;
            rb_Fecha.Checked = false;
            rb_MontoFactura.Checked = false;
            rb_numFactura.Checked = false;
        }
    }
}
