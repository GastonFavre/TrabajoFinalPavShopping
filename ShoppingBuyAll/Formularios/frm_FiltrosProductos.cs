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
    public partial class frm_FiltrosProductos : Form
    {
        public frm_FiltrosProductos()
        {
            InitializeComponent();
        }

        Producto producto = new Producto();

        private void cb_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Codigo.Checked)
            {
                txt_Codigo.Enabled = true;
                txt_Codigo.Focus();
            }
            else
            {
                txt_Codigo.Enabled = false;
                txt_Codigo.Text = "";
            }
        }

        private void cb_Precio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Precio.Checked)
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

        private void cb_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Nombre.Checked)
            {
                txt_Nombre.Enabled = true;
                txt_Nombre.Focus();
            }
            else
            {
                txt_Nombre.Enabled = false;
                txt_Nombre.Text = "";
            }
        }

        private void txt_PrecioDesde_TextChanged(object sender, EventArgs e)
        {
            txt_PrecioHasta.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string comando_sql = "";
            if (cb_Codigo.Checked)
            {
                if (txt_Codigo.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por codigo, por ende debe escribir un codigo.");
                    txt_Codigo.Focus();
                    return;
                }
                else
                {
                    comando_sql = comando_sql + " WHERE " + txt_Codigo._campo + " = " + txt_Codigo.Text.Trim();
                }
            }
            if (cb_Precio.Checked)
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
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + txt_PrecioDesde._campo + " BETWEEN " + txt_PrecioDesde.Text.Trim() + " AND " + txt_PrecioHasta.Text.Trim();
                }
                else
                {
                    comando_sql = comando_sql + " AND " + txt_PrecioDesde._campo + " BETWEEN " + txt_PrecioDesde.Text.Trim()+ " AND " + txt_PrecioHasta.Text.Trim();
                }
                
            }
            if (cb_Nombre.Checked)
            {
                if (txt_Nombre.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por nombre, por ende debe escribir uno.");
                    txt_Nombre.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + txt_Nombre._campo + " LIKE '%" + txt_Nombre.Text.Trim() + "%'";
                }
                else
                {
                    comando_sql = comando_sql + " AND  " + txt_Nombre._campo + " LIKE '%" + txt_Nombre.Text.ToString() + "%'";
                }
            }
            DataTable tabla = new DataTable();
            tabla = producto.buscar_productos_filtrado(comando_sql);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encuentra ningun producto segun la busqueda realizada.");
            }
            else
            {
                dataGridView1.DataSource = tabla;
            }
            
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            cb_Codigo.Checked = false;
            cb_Nombre.Checked = false;
            cb_Precio.Checked = false;
            txt_Codigo.Text = "";
            txt_Codigo.Enabled = false;
            txt_Nombre.Text = "";
            txt_Nombre.Enabled = false;
            txt_PrecioDesde.Text = "";
            txt_PrecioDesde.Enabled = false;
            txt_PrecioHasta.Text = "";
            txt_PrecioHasta.Enabled = false;
        }

        private void txt_PrecioDesde_TextChanged_1(object sender, EventArgs e)
        {
            txt_PrecioHasta.Enabled = true;
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar_solo_numeros(sender, e);
        }
    
        private void verificar_solo_numeros(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }

        private void txt_PrecioDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar_solo_numeros(sender, e);
        }

        private void txt_PrecioHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar_solo_numeros(sender, e);
        }

        private void frm_FiltrosProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
