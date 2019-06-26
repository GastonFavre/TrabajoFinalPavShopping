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
            if (this.txt_patenteFiltrado.Visible)
            {
                if (this.txt_patenteFiltrado.Text == "")
                {
                    MessageBox.Show("Debe ingresar una patente");
                }
                else
                {
                    GrillaFiltrados.DataSource = AutoCliente.buscar_porPatente(txt_patenteFiltrado.Text);
                }
            }

            if (this.txt_NumDocFiltrado.Visible)
            {
                if (this.txt_NumDocFiltrado.Text == "" || cmb_tipoDocFiltrado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar el tipo y numero de documento");
                }
                else
                {
                    GrillaFiltrados.DataSource = AutoCliente.buscar_porDNI(txt_NumDocFiltrado.Text);
                }
            }

            if (this.cmbPlayaFiltrado.Visible)
            {
                if (this.cmbPlayaFiltrado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar la playa");
                }
                else
                {
                    GrillaFiltrados.DataSource = AutoCliente.buscar_porPlaya(cmbPlayaFiltrado.SelectedValue.ToString());
                }
            }

            if (this.dt_fecha_entradaFiltrado.Visible)
            {
                if (this.dt_fecha_entradaFiltrado.Text == "")
                {
                    MessageBox.Show("Debe ingresar una fecha");
                }
                else
                {
                    GrillaFiltrados.DataSource = AutoCliente.buscar_porFecha(dt_fecha_entradaFiltrado.Text);
                }
            }

            
        }

       

        private void checkPatente_CheckedChanged(object sender, EventArgs e)
        {
            
            
                if (this.txt_patenteFiltrado.Enabled == true)
                {
                    this.txt_patenteFiltrado.Enabled = false;

                    this.txt_NumDocFiltrado.Visible = true;
                    this.cmb_tipoDocFiltrado.Visible = true;
                    this.cmbPlayaFiltrado.Visible = true;
                    this.dt_fecha_entradaFiltrado.Visible = true;

                    this.checkNroDNI.Enabled = true;
                  
                    this.checkFechaIngreso.Enabled = true;
                    this.checkPlaya.Enabled = true;
            }
                else
                {
                    this.txt_patenteFiltrado.Enabled = true;

                    this.txt_NumDocFiltrado.Visible = false;
                    this.cmb_tipoDocFiltrado.Visible = false;
                    this.cmbPlayaFiltrado.Visible = false;
                    this.dt_fecha_entradaFiltrado.Visible = false;

                    this.checkNroDNI.Enabled = false;
                  
                    this.checkFechaIngreso.Enabled = false;
                    this.checkPlaya.Enabled = false;

                    this.txt_patenteFiltrado.Focus();
                }
            
        }

        

        private void checkNroDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txt_NumDocFiltrado.Enabled == true)
            {
                this.txt_NumDocFiltrado.Enabled = false;
                this.cmb_tipoDocFiltrado.Enabled = false;
                this.txt_patenteFiltrado.Visible = true;
                this.cmb_tipoDocFiltrado.Visible = true;
                this.cmbPlayaFiltrado.Visible = true;
                this.dt_fecha_entradaFiltrado.Visible = true;

                this.checkPatente.Enabled = true;
               
                this.checkFechaIngreso.Enabled = true;
                this.checkPlaya.Enabled = true;
            }
            else
            {
                this.txt_NumDocFiltrado.Enabled = true;
                this.cmb_tipoDocFiltrado.Enabled = true;

                this.txt_patenteFiltrado.Visible = false;
                
                this.cmbPlayaFiltrado.Visible = false;
                this.dt_fecha_entradaFiltrado.Visible = false;

                this.checkPatente.Enabled = false;
                
                this.checkFechaIngreso.Enabled = false;
                this.checkPlaya.Enabled = false;

                this.txt_NumDocFiltrado.Focus();
            }
        }

        

        private void checkPlaya_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbPlayaFiltrado.Enabled == true)
            {
                this.cmbPlayaFiltrado.Enabled = false;
                this.txt_NumDocFiltrado.Visible = true;
                this.cmb_tipoDocFiltrado.Visible = true;
                this.txt_patenteFiltrado.Visible = true;
                this.dt_fecha_entradaFiltrado.Visible = true;

                this.checkNroDNI.Enabled = true;
            
                this.checkFechaIngreso.Enabled = true;
                this.checkPatente.Enabled = true;
            }
            else
            {
                this.cmbPlayaFiltrado.Enabled = true;

                this.txt_NumDocFiltrado.Visible = false;
                this.cmb_tipoDocFiltrado.Visible = false;
                this.txt_patenteFiltrado.Visible = false;
                this.dt_fecha_entradaFiltrado.Visible = false;

                this.checkNroDNI.Enabled = false;
               
                this.checkFechaIngreso.Enabled = false;
                this.checkPatente.Enabled = false;

                this.cmbPlayaFiltrado.Focus();

            }
        }

        

        private void checkFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dt_fecha_entradaFiltrado.Enabled == true)
            {
                this.dt_fecha_entradaFiltrado.Enabled = false;
                this.txt_NumDocFiltrado.Visible = true;
                this.cmb_tipoDocFiltrado.Visible = true;
                this.cmbPlayaFiltrado.Visible = true;
                this.txt_patenteFiltrado.Visible = true;

                this.checkNroDNI.Enabled = true;
              
                this.checkPatente.Enabled = true;
                this.checkPlaya.Enabled = true;
            }
            else
            {
                this.dt_fecha_entradaFiltrado.Enabled = true;

                this.txt_NumDocFiltrado.Visible = false;
                this.cmb_tipoDocFiltrado.Visible = false;
                this.cmbPlayaFiltrado.Visible = false;
                this.txt_patenteFiltrado.Visible = false;

                this.checkNroDNI.Enabled = false;
              
                this.checkPatente.Enabled = false;
                this.checkPlaya.Enabled = false;

                this.dt_fecha_entradaFiltrado.Focus();
            }
        }

        

        private void btn_nuevoFiltrado_Click(object sender, EventArgs e)
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
