using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.Formularios;
using ShoppingBuyAll.clases;
using ShoppingBuyAll.Componentes;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Automoviles2 : Form
    {
        Marcas obj_marca = new Marcas();
        Tipo_Auto obj_tipo_auto = new Tipo_Auto();
        tipos_documento obj_tipo_doc = new tipos_documento();
        Modelo obj_modelo = new Modelo();
        Cliente2 obj_cliente = new Cliente2();
        Automovil obj_automovil = new Automovil();
        Validar obj_validar = new Validar();
        bool consulta_hecha = true;

        public frm_Automoviles2()
        {
            InitializeComponent();
        }

        
        private bool verificar_existencia_cliente()
        {
            DataTable tabla = new DataTable();
            tabla = obj_cliente.buscar_cliente(cmb_Tipo_Doc.SelectedValue.ToString(), this.txt_nroDoc.Text.ToString().Trim());
            if (tabla.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (obj_automovil.validar_automovil(this.Controls) == Validar.estado_validacion.correcta)
            {
                if (verificar_existencia_cliente())
                {
                    this.obj_automovil.auto_Insert_A(this.Controls);
                    MessageBox.Show("Automovil agregado correctamente");
                }
                else
                {
                    MessageBox.Show("El cliente ingresado no existe", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.obj_validar.blanquear_objetos(this.Controls);


            this.txt_nroDoc.Enabled = true;
            this.cmb_TipoAuto.Enabled = true;
            this.cmb_Tipo_Doc.Enabled = true;
            this.cmb_Modelo.Enabled = false;
            this.cmb_Marca.Enabled = true;
            this.btn_Buscar_Patente.Visible = false;
            this.consulta_hecha = true;
            this.txt_Patente.Enabled = true;

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            this.obj_validar.blanquear_objetos(this.Controls);
            this.btn_Buscar_Patente.Visible = true;

            this.txt_nroDoc.Enabled = false;
            this.cmb_TipoAuto.Enabled = false;
            this.cmb_Tipo_Doc.Enabled = false;
            this.cmb_Modelo.Enabled = false;
            this.cmb_Marca.Enabled = false;
        }

        private void btn_Buscar_Patente_Click(object sender, EventArgs e)
        {

            if (this.txt_Patente.Text == "")
            {
                MessageBox.Show("Por favor ingrese una patente");
                txt_Patente.Focus();
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = this.obj_automovil.Consultar_Automovil(this.txt_Patente.Text.ToString().Trim());
                if (tabla.Rows.Count != 0)
                {
                    consulta_hecha = false;
                    this.txt_Patente.Text = tabla.Rows[0]["patente"].ToString();
                    
                    this.cmb_Marca.SelectedValue = tabla.Rows[0]["id_marca1"];
                    this.obj_modelo.tipo_marca = this.cmb_Marca.SelectedIndex;
                    this.cmb_Modelo.DataSource = this.obj_modelo.Recuperar_Modelos();
                    this.cmb_Modelo.DisplayMember = "nombre";
                    this.cmb_Modelo.ValueMember = "id_modelo";
                    this.cmb_Modelo.SelectedValue = tabla.Rows[0]["modelo"];
                    this.consulta_hecha = true;
                    this.cmb_TipoAuto.SelectedValue = tabla.Rows[0]["cod_tipo1"];
                    this.cmb_Tipo_Doc.SelectedValue = tabla.Rows[0]["tipo_doc2"];
                    this.txt_nroDoc.Text = tabla.Rows[0]["num_doc1"].ToString();
                    this.btn_Modificar.Enabled = true;
                    this.btn_Buscar_Patente.Visible = false;
                    this.txt_nroDoc.Enabled = true;
                    this.cmb_TipoAuto.Enabled = true;
                    this.cmb_Tipo_Doc.Enabled = true;
                    this.cmb_Modelo.Enabled = true;
                    this.cmb_Marca.Enabled = true;
                    this.btn_Eliminar.Enabled = true;
                    this.txt_Patente.Enabled = false;

                }
                else
                {
                    MessageBox.Show("No se encontro el automovil");
                }

            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (obj_automovil.validar_automovil(this.Controls) == Validar.estado_validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = this.obj_automovil.Consultar_Automovil(this.txt_Patente.Text.ToString().Trim());

                if (verificar_existencia_cliente() && (tabla.Rows.Count != 0))
                {
                    obj_automovil.auto_modificar_A(this.Controls);
                    MessageBox.Show("Vehiculo Modificado Correctamente", "Mensaje"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se puede realizar la modificacion", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_automovil.Consultar_Automovil(this.txt_Patente.Text.ToString().Trim());
            if (tabla.Rows.Count != 0)
            {
                this.obj_automovil.Eliminar_automovil(this.txt_Patente.Text.ToString().Trim());
            }
            else
            {
                MessageBox.Show("No se puede realizar la eliminacion", "Mensaje"
                            , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void traer_Modelos(object sender, EventArgs e)
        {
            if (this.cmb_Marca.SelectedIndex != -1 && consulta_hecha)
            {
                this.obj_modelo.tipo_marca = this.cmb_Marca.SelectedIndex;
                this.cmb_Modelo.DataSource = this.obj_modelo.Recuperar_Modelos();
                this.cmb_Modelo.DisplayMember = "nombre";
                this.cmb_Modelo.ValueMember = "id_modelo";
                this.cmb_Modelo.SelectedValue = -1;
            }
            this.habilitar_Modelo(sender, e);
        }

        private void habilitar_Modelo(object sender, EventArgs e)
        {
            this.cmb_Modelo.Enabled = true;
        }

        private void frm_Automoviles2_Load(object sender, EventArgs e)
        {
            this.cmb_Marca.DataSource = this.obj_marca.Recuperar_Marcas();
            this.cmb_Marca.DisplayMember = "descripcion";
            this.cmb_Marca.ValueMember = "id_marca";
            this.cmb_Marca.SelectedValue = -1;



            this.cmb_Tipo_Doc.DataSource = this.obj_tipo_doc.Recuperar_tipos_documento();
            this.cmb_Tipo_Doc.DisplayMember = "descripcion";
            this.cmb_Tipo_Doc.ValueMember = "id_doc";
            this.cmb_Tipo_Doc.SelectedValue = -1;

            this.cmb_TipoAuto.DataSource = this.obj_tipo_auto.Recuperar_Tipo_Auto();
            this.cmb_TipoAuto.DisplayMember = "nombre";
            this.cmb_TipoAuto.ValueMember = "cod_tipo";
            this.cmb_TipoAuto.SelectedValue = -1;
            this.cmb_Modelo.Enabled = false;
            
        }

        private void txt_nroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }

        private void btn_agregarTarjeta_Click(object sender, EventArgs e)
        {
            frm_Marca form_Marca = new frm_Marca();
            form_Marca.ShowDialog();
            if (form_Marca.act)
            {
                this.actualizar_Cmb();
                form_Marca.act = false;
            }
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            frm_Modelo form_Modelo = new frm_Modelo();
            form_Modelo.ShowDialog();
           
        }

        public void actualizar_Cmb()
        {
            this.cmb_Marca.DataSource = this.obj_marca.Recuperar_Marcas();
            this.cmb_Marca.DisplayMember = "descripcion";
            this.cmb_Marca.ValueMember = "id_marca";
            this.cmb_Marca.SelectedValue = -1;
        }

       
    }

}

