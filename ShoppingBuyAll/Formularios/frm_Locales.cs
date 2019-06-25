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
                    local.modificar_local(this.Controls);
                    MessageBox.Show("Local Modificado Correctamente", "Mensaje"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void boton_Nuevo_Click(object sender, EventArgs e)
        {
            _val.blanquear_objetos(this.Controls);
            txt_Cuil.Enabled = true;
            this.txt_Cuil.Focus();
            dataGridView1.DataSource = "";
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            if (local.validar_local(this.Controls) == Validar.estado_validacion.correcta)
            {
                if (local.agregar_local(this.Controls) == true)
                {
                    MessageBox.Show("Local agregado correctamente", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

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
            btn_agregarRubro.Enabled = false;
            btn_mostrarRubros.Enabled = false;
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

            txt_Cuil.Enabled = true;
            txt_Nombre_Local.Enabled = true;
            cmb_Tipo_Loc.Enabled = true;
            btn_Buscar_CUIL.Visible = false;
            btn_agregarRubro.Enabled = true;
            btn_mostrarRubros.Enabled = true;
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
            frm_LocalesFiltrados LocxTipo = new frm_LocalesFiltrados();
            LocxTipo.ShowDialog();
        }

        private void btn_agregarRubro_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.local.buscar_local(this.txt_Cuil.Text.Trim());
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("Primero debe agregar el local para luego agregar sus Rubros.");
            }
            else
            {
                frm_RubroLocal locxrub = new frm_RubroLocal();
                locxrub.txt_Cuil.Text = this.txt_Cuil.Text.Trim();
                locxrub.ShowDialog();
            }
            
        }

        private void btn_mostrarRubros_Click(object sender, EventArgs e)
        {
            
            if (txt_Cuil.Text == "")
            {
                MessageBox.Show("No se Ingreso el CUIL");
                return;
            }
            DataTable tabla = new DataTable();
            tabla = rubrosxloc.buscar_Rubro(this.txt_Cuil.Text.Trim());
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El CUIL no tiene Rubros asociadas");
                return;
            }
            else
            {
                dataGridView1.Visible = true;
                label1.Visible = true;
                dataGridView1.DataSource = tabla;
            }

        }
    }
}
