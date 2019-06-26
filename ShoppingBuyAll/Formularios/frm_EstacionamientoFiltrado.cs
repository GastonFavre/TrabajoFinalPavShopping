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
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll.Formularios
{

    // A la hora de cargar la grilla solo filtra por playa y por patente por separado y juntos
    // , los demas nose si no me esta tomando como combo box de control, textbox de control , 
    // o datetimepicker,use el buscar_filtrado de clientes_filtrados.   
    // Nose si esta bien ese buscar_filtrado , por lo que aparece y por los nombres de la 
    // columna

    public partial class frm_EstacionamientoFiltrado : Form
    {
        public frm_EstacionamientoFiltrado()
        {
            InitializeComponent();
        }
        Estacionamiento estacionamiento = new Estacionamiento();

        private void frm_EstacionamientoFiltrado_Load(object sender, EventArgs e)
        {
            this.cmbPlayaFiltrado.cargar("Playa", "id_playa", "nombre");
            this.cmb_tipoDocFiltrado.cargar("Tipo_Documento", "id_doc", "descripcion");
            this.cmbPlayaFiltrado.SelectedIndex = -1;
            this.cmb_tipoDocFiltrado.SelectedIndex = -1;

        }
             
            

        private void btn_buscarFiltrado_Click(object sender, EventArgs e)
        {
            string comando_sql = "";
            if (checkPatente.Checked)
            {
                if (txt_patenteFiltrado.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por codigo, por ende debe escribir un codigo.");
                    txt_patenteFiltrado.Focus();
                    return;
                }
                else
                {
                    comando_sql = comando_sql + " WHERE " + txt_patenteFiltrado._campo + " = '" + txt_patenteFiltrado.Text.Trim() + "'";
                }
            }
            if (checkPlaya.Checked)
            {
                if (cmbPlayaFiltrado.SelectedIndex == -1)
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado por precio, por ende debe escribir un precio desde y un precio hasta.");
                    cmbPlayaFiltrado.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + cmbPlayaFiltrado._campo + " = " + this.cmbPlayaFiltrado.SelectedValue.ToString();
                }
                else
                {
                    comando_sql = comando_sql + " AND " + cmbPlayaFiltrado._campo + " = " + this.cmbPlayaFiltrado.SelectedValue.ToString();
                }
            }
            if (checkNroDNI.Checked)
            {
                if (txt_NumDocFiltrado.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado numero de documento, por ende debe escribir uno.");
                    txt_NumDocFiltrado.Focus();
                    return;
                }
                if (cmb_tipoDocFiltrado.SelectedIndex == -1)
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado numero de documento, por ende debe seleccionar un tipo de documento.");
                    cmb_tipoDocFiltrado.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + txt_NumDocFiltrado._campo + " = " + txt_NumDocFiltrado.Text.Trim() + "AND " + cmb_tipoDocFiltrado._campo + " = " + cmb_tipoDocFiltrado.SelectedValue.ToString();
                }
                else
                {
                    comando_sql = comando_sql + " AND  " + txt_NumDocFiltrado._campo + " = " + txt_NumDocFiltrado.Text.Trim() + "AND " + cmb_tipoDocFiltrado._campo + " = " + cmb_tipoDocFiltrado.SelectedValue.ToString();
                }
            }
            if (checkFechaIngreso.Checked)
            {
                if (dt_fecha_entradaFiltrado.Text == "")
                {
                    MessageBox.Show("Se ecuentra seleccionada la opcion de filtado fecha, por ende debe escribir una fecha.");
                    dt_fecha_entradaFiltrado.Focus();
                    return;
                }
                if (comando_sql == "")
                {
                    comando_sql = comando_sql + " WHERE " + dt_fecha_entradaFiltrado._campo + " = '" + dt_fecha_entradaFiltrado.Text.Trim() + "'";
                }
                else
                {
                    comando_sql = comando_sql + " AND " + dt_fecha_entradaFiltrado._campo + " = '" + dt_fecha_entradaFiltrado.Text.Trim() + "'";
                }
            }
            DataTable tabla = new DataTable();
            tabla = estacionamiento.buscar_EstacionamientoFiltadoAuto(comando_sql);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encuentra ningun producto segun la busqueda realizada.");
            }
            else
            {
                GrillaFiltrados.DataSource = tabla;
            }

        }

       

        private void checkPatente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPatente.Checked)
            {
                txt_patenteFiltrado.Enabled = true;
                txt_patenteFiltrado.Focus();
            }
            else
            {
                txt_patenteFiltrado.Enabled = false;
                txt_patenteFiltrado.Text = "";
            }
        }

        

        private void checkNroDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNroDNI.Checked)
            {
                txt_NumDocFiltrado.Enabled = true;
                cmb_tipoDocFiltrado.Enabled = true;
                cmb_tipoDocFiltrado.Focus();
            }
            else
            {
                txt_NumDocFiltrado.Enabled = false;
                cmb_tipoDocFiltrado.Enabled = false;
                txt_NumDocFiltrado.Text = "";
            }
        }

        

        private void checkPlaya_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlaya.Checked)
            {
                cmbPlayaFiltrado.Enabled = true;
                cmbPlayaFiltrado.Focus();
            }
            else
            {
                cmbPlayaFiltrado.Enabled = false;
                cmbPlayaFiltrado.SelectedIndex = -1;
            }
        }

        

        private void checkFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechaIngreso.Checked)
            {
                dt_fecha_entradaFiltrado.Enabled = true;
                dt_fecha_entradaFiltrado.Focus();
            }
            else
            {
                dt_fecha_entradaFiltrado.Enabled = false;
                dt_fecha_entradaFiltrado.Text = "";
            }
        }

      

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_nuevoFiltrado_Click_1(object sender, EventArgs e)
        {
            txt_patenteFiltrado.Text = "";
            txt_NumDocFiltrado.Text = "";

            dt_fecha_entradaFiltrado.Text = "";
            cmbPlayaFiltrado.SelectedIndex = -1;
            cmb_tipoDocFiltrado.SelectedIndex = -1;
            checkPatente.Checked = false;

            checkNroDNI.Checked = false;

            checkPlaya.Checked = false;

            checkFechaIngreso.Checked = false;

            GrillaFiltrados.DataSource = "";
        }

        private void txt_NumDocFiltrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }
    }
}
