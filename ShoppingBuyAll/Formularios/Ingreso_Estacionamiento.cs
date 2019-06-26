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
    public partial class Ingreso_Estacionamiento : Form
    {
        //nuevos objetos 

        tipos_documento obj_tipo_doc = new tipos_documento();
        Validar _val = new Validar();
        Estacionamiento autoCliente = new Estacionamiento();
        

        

        public Ingreso_Estacionamiento()
        {
            InitializeComponent();
        }

        //busca un auto por patente que tiene que estar registrado anteriormente
        // en el sistema , si no, le avisa que no esta registrado

        private void btn_Buscar_patente_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable tabla1 = new DataTable();
            DataTable tabla2 = new DataTable();
            DataTable tablaTipoDoc = new DataTable();
            tabla = autoCliente.Consultar_Automovil_Cliente(txt_patente.Text.Trim());
            

            if (this.txt_patente.Text == "" )
            {
                //valida que en se ingrese alguna patente
                MessageBox.Show("No ingreso una patente");
                txt_patente.Focus();
            }
            else
            {
                if (tabla.Rows.Count > 0)
                {
                    tabla2 = autoCliente.consultar_lugar_playa(this.txt_patente.Text.Trim());
                    if (tabla2.Rows.Count > 0)
                    {
                        MessageBox.Show("El vehiculo ya se encuentra en el estacionamiento!");
                        return;
                    }

                    
                    this.txt_nroDoc.Text = tabla.Rows[0]["num_doc1"].ToString();
                    this.cmb_tipoDoc.Text = tabla.Rows[0]["tipo_doc2"].ToString();

                    tablaTipoDoc = autoCliente.descripcion_TIPODOC(cmb_tipoDoc.Text);
                    tipoDocumento.Text = tablaTipoDoc.Rows[0]["descripcion"].ToString();


                    tabla1 = autoCliente.Consultar_Cliente(txt_nroDoc.Text);
                    this.txt_nomCliente.Text = tabla1.Rows[0]["nombres"].ToString();
                    this.txt_apellido.Text = tabla1.Rows[0]["apellido"].ToString();

                    
                    cmb_IdPlaya.Enabled = true;
                    txt_Estacionamiento.Enabled = true;
                    txt_horaDesde.Text = DateTime.Now.ToShortTimeString();
                    dt_fecha_entrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    
                    this.dt_fecha_entrada.Focus();
                }
                else
                {
                    //ingreso una patente que no existe en el sistema
                    MessageBox.Show("El auto no esta registrado en el sistema");
                    txt_patente.Text = "";
                    txt_patente.Focus();
                }
                //valida que no se busque una patente que ya esta registrada en el estacionamiento
                
            }
        }

        //se efectua el registro del auto como ingresado al estacionamiento
        //se completa la tabla EstacXCliente  con agregar_enEstacionamiento
        // ¿¿¿¿se debe agregar que no se repita el lugar asignado????
        //se blanquean los campos para el ingreso de un nuevo auto

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            



            if (autoCliente.validar_autoCliente(this.Controls) == Validar.estado_validacion.correcta && txt_patente.Text != "")
            {
                autoCliente.agregar_enEstacionamiento(this.Controls);

                MessageBox.Show("Auto agregado correctamente en el \n estacionamiento", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this._val.blanquear_objetos(this.Controls);
                tipoDocumento.Text = "";


            }
            else
            {
                MessageBox.Show("No hay un numero de patente ingresado");
            }

            
            _val.blanquear_objetos(this.Controls);
            tipoDocumento.Text = "";

        }

        //se cierra el formulario de ingreso de vehiculos
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            Dispose();
        }

        //al abrirse el formulario de salida se guarda la fecha actual en la que se esta
        //retirando el auto

        private void Ingreso_Estacionamiento_Load(object sender, EventArgs e)
        {
            this.cmb_IdPlaya.cargar("Playa", "id_playa", "nombre");
            ;

        }

        
    }
}
