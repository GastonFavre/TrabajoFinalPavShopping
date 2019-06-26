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
using ShoppingBuyAll.Componentes;

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

        private void frm_LocalPorTipo_Load(object sender, EventArgs e)
        {
            this.cmb_tipoCom.cargar("Tipo_Comercio", "id_tipoC", "descripcion");
            validacion.blanquear_objetos(this.Controls);
        }
  
        public void recuperarDatos()
        {
            DataTable tabla_filtro = new DataTable();
            tabla_filtro = obj_local.buscar_local_filtrado(this.Controls);
            datagrid_filtro.DataSource = tabla_filtro;
        }

        private bool validar_campos(Control.ControlCollection controles)
        {
            int cont = 0;
            foreach (Control item in controles)
            {
                if (item.GetType().Name == "TextBoxDeControl")
                {
                    if (item.Text == "")
                    {
                        cont += 1;
                    }
                }
                if (item.GetType().Name == "ComboBoxDeControl")
                {
                    if (((ComboBoxDeControl)item).SelectedIndex == -1)
                    {
                        cont += 1;
                    }
                }
            }
            if (cont == 8)
            {
                return false;
            }

            return true;
        }
        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_Cuil_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_Cuil.Checked)
            {
                txt_CuilLocal.Enabled = true;
                txt_CuilLocal.Focus();
            }
            else
            {
                txt_CuilLocal.Enabled = false;
                txt_CuilLocal.Text = "";
            }
        }

        private void cb_TipoComercio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_TipoComercio.Checked)
            {
                cmb_tipoCom.Enabled = true;
                cmb_tipoCom.Focus();
            }
            else
            {
                cmb_tipoCom.Enabled = false;
                cmb_tipoCom.SelectedIndex = -1;               
            }
        }

        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string comando_sql = "";
            if (cb_Cuil.Checked)
            {
                if (txt_CuilLocal.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtrado por CUIL, por ende debe escribir un CUIL.");
                    txt_CuilLocal.Focus();
                    return;
                }
                else
                {
                    comando_sql = comando_sql + " WHERE " + txt_CuilLocal._campo + " = " + txt_CuilLocal.Text.Trim();
                }
            }
            if (cb_TipoComercio.Checked)
            {
                if (cmb_tipoCom.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Tipo de Comercio a buscar");
                    cmb_tipoCom.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + cmb_tipoCom._campo + " = " + cmb_tipoCom.SelectedValue.ToString();
                }
                else
                {
                    comando_sql = comando_sql + " AND " + cmb_tipoCom._campo + " = " + cmb_tipoCom.SelectedValue.ToString();
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
            tabla = obj_local.buscar_Locales_Filtrado(comando_sql);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encuentra ningun Local segun la busqueda realizada.");
            }
            else
            {
                datagrid_filtro.DataSource = tabla;
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            datagrid_filtro.DataSource = "";
            cb_Cuil.Checked = false;
            cb_Nombre.Checked = false;
            cb_TipoComercio.Checked = false;
            txt_CuilLocal.Text = "";
            txt_CuilLocal.Enabled = false;
            txt_Nombre.Text = "";
            txt_Nombre.Enabled = false;
            cmb_tipoCom.Text = "";
            cmb_tipoCom.Enabled = false;          
        }

        private void txt_CuilLocal_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
