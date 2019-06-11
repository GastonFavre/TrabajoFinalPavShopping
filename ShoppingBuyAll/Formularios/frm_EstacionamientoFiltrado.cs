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

        private void frm_EstacionamientoFiltrado_Load(object sender, EventArgs e)
        {
            this.cmbPlayaFiltrado.cargar("Playa", "id_playa", "nombre");
            this.cmb_tipoDocFiltrado.cargar("Tipo_Documento", "id_doc", "descripcion");
            this.cmbPlayaFiltrado.SelectedIndex = -1;
            this.cmb_tipoDocFiltrado.SelectedIndex = -1;

        }
             
            

        private void btn_buscarFiltrado_Click(object sender, EventArgs e)
        {
            Estacionamiento AutoCliente = new Estacionamiento();
            DataTable tabla_filtrados = new DataTable();
            tabla_filtrados = AutoCliente.buscar_estacionamiento_filtrado(this.Controls);
            if (tabla_filtrados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados \n para los filtros aplicados");
            }
            else
            {
                GrillaFiltrados.DataSource = tabla_filtrados;
            } 

        }

       

        private void checkPatente_CheckedChanged(object sender, EventArgs e)
        {
            
            
                if (this.txt_patenteFiltrado.Enabled == true)
                {
                    this.txt_patenteFiltrado.Enabled = false;
                }
                else
                {
                    this.txt_patenteFiltrado.Enabled = true;
                    this.txt_patenteFiltrado.Focus();
                }
            
        }

        private void checkTipoDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoDocFiltrado.Enabled == true)
            {
                this.cmb_tipoDocFiltrado.Enabled = false;
            }
            else
            {
                this.cmb_tipoDocFiltrado.Enabled = true;
                this.cmb_tipoDocFiltrado.Focus();
            }
        }

        private void checkNroDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_NumDocFiltrado.Enabled == true)
            {
                this.txt_NumDocFiltrado.Enabled = false;
            }
            else
            {
                this.txt_NumDocFiltrado.Enabled = true;
                this.txt_NumDocFiltrado.Focus();
            }
        }

        private void checkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_nombreFiltrado.Enabled == true)
            {
                this.txt_nombreFiltrado.Enabled = false;
            }
            else
            {
                this.txt_nombreFiltrado.Enabled = true;
                this.txt_nombreFiltrado.Focus();
            }
        }

        private void checkApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_apellidoFiltrado.Enabled == true)
            {
                this.txt_apellidoFiltrado.Enabled = false;
            }
            else
            {
                this.txt_apellidoFiltrado.Enabled = true;
                this.txt_apellidoFiltrado.Focus();
            }
        }

        private void checkPlaya_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbPlayaFiltrado.Enabled == true)
            {
                this.cmbPlayaFiltrado.Enabled = false;
            }
            else
            {
                this.cmbPlayaFiltrado.Enabled = true;
                this.cmbPlayaFiltrado.Focus();
            }
        }

        private void checkNroEstac_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_NroEstacionFiltrado.Enabled == true)
            {
                this.txt_NroEstacionFiltrado.Enabled = false;
            }
            else
            {
                this.txt_NroEstacionFiltrado.Enabled = true;
                this.txt_NroEstacionFiltrado.Focus();
            }
        }

        private void checkFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dt_fecha_entradaFiltrado.Enabled == true)
            {
                this.dt_fecha_entradaFiltrado.Enabled = false;
            }
            else
            {
                this.dt_fecha_entradaFiltrado.Enabled = true;
                this.dt_fecha_entradaFiltrado.Focus();
            }
        }

        private void checkHoraIng_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_horaDesdeFiltrado.Enabled == true)
            {
                this.txt_horaDesdeFiltrado.Enabled = false;
            }
            else
            {
                this.txt_horaDesdeFiltrado.Enabled = true;
                this.txt_horaDesdeFiltrado.Focus();
            }
        }

        private void checkHoraSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_horaSalidaFiltrado.Enabled == true)
            {
                this.txt_horaSalidaFiltrado.Enabled = false;
            }
            else
            {
                this.txt_horaSalidaFiltrado.Enabled = true;
                this.txt_horaSalidaFiltrado.Focus();
            }
        }

        private void btn_nuevoFiltrado_Click(object sender, EventArgs e)
        {
            txt_patenteFiltrado.Text = "";
            txt_NumDocFiltrado.Text = "";
            txt_NroEstacionFiltrado.Text = "";
            txt_nombreFiltrado.Text = "";
            txt_apellidoFiltrado.Text = "";
            txt_horaDesdeFiltrado.Text = "";
            txt_horaSalidaFiltrado.Text = "";
            dt_fecha_entradaFiltrado.Text = "";
            cmbPlayaFiltrado.SelectedIndex = -1;
            cmb_tipoDocFiltrado.SelectedIndex = -1;
            checkPatente.Checked = false;
            checkApellido.Checked = false;
            checkNombre.Checked = false;
            checkNroDNI.Checked = false;
            checkTipoDNI.Checked = false;
            checkPlaya.Checked = false;
            checkNroEstac.Checked = false;
            checkHoraIng.Checked = false;
            checkFechaIngreso.Checked = false;
            checkHoraSalida.Checked = false;
            GrillaFiltrados.DataSource = "";
        }
    }
}
