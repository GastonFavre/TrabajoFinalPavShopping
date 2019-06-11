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
using ShoppingBuyAll.Componentes;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Locales : Form
    {
        Locales local = new Locales();
        AccesoBD _BD = new AccesoBD();
        Validar _val = new Validar();
        RubrosXLocal rubrosxloc = new RubrosXLocal();
        public frm_Locales()
        {
            InitializeComponent();
        }

        private void frm_Locales_Load(object sender, EventArgs e)
        {
            this.cmb_Tipo_Loc.cargar("Tipo_Comercio", "id_tipoC", "descripcion");
            this.cmb_Rubro.cargar("Rubros", "cod_rub", "nombre");
        }

        private void boton_Modi_Click(object sender, EventArgs e)
        {
            if (local.validar_local(this.Controls) == Validar.estado_validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = local.buscar_local(this.txt_Cuil.Text.ToString().Trim());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El Local ingresado para Modificar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    local.modificar_local(this.Controls, txt_Cuil.Text.ToString().Trim());
                    MessageBox.Show("Local Modificado Correctamente", "Mensaje"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void boton_Nuevo_Click(object sender, EventArgs e)
        {
            _val.blanquear_objetos(this.Controls);
            txt_Cuil.Enabled = true;
            this.cmb_Tipo_Loc.Focus();
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            if (local.validar_local(this.Controls) == Validar.estado_validacion.correcta)
            {
                local.agregar_local(this.Controls);
                MessageBox.Show("Local agregado correctamente", "Mensaje", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            if (this.txt_Cuil.Text != "")
            {
                local.eliminar_local(txt_Cuil.Text.Trim());
                _val.blanquear_objetos(this.Controls);
            }
            else
            {
                MessageBox.Show("Debe Ingresar el CUIL para eliminar un Local", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            _val.blanquear_objetos(this.Controls);
            txt_Nombre_Local.Enabled = false;
            cmb_Tipo_Loc.Enabled = false;
            btn_Buscar_CUIL.Visible = true;
        }

        private void btn_Buscar_CUIL_Click(object sender, EventArgs e)
        {
            if (txt_Cuil.Text == "")
            {
                MessageBox.Show("CUIL no ingresado");
                _val.blanquear_objetos(this.Controls);
                return;
            }

            DataTable tabla = new DataTable();
            
            tabla = this.local.buscar_local(this.txt_Cuil.Text.Trim());
            if (tabla.Rows.Count == 1)
            {
                txt_Nombre_Local.Text = tabla.Rows[0]["nombre"].ToString();
                cmb_Tipo_Loc.SelectedValue = tabla.Rows[0]["tipo_Comercio1"];
                btn_Buscar_CUIL.Visible = false;
            }
            else
            {
                MessageBox.Show("El local solicitado no se encuetra en el sistema");
            }

            txt_Cuil.Enabled = false;
            txt_Nombre_Local.Enabled = true;
            cmb_Tipo_Loc.Enabled = true;
            cmb_Rubro.Enabled = true;
            btn_Buscar_CUIL.Visible = false;
        }

        private void txt_Cuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }

        private void btn_Local_Tipo_Click(object sender, EventArgs e)
        {
            frm_LocalPorTipo LocxTipo = new frm_LocalPorTipo();
            LocxTipo.ShowDialog();
        }
    }
}
