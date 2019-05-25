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
    public partial class frm_Clientes2 : Form
    {
        Cliente2 cliente = new Cliente2();
        AccesoBD _BD = new AccesoBD();
        Validar _val = new Validar();
        TarjetaXCliente tarjetas = new TarjetaXCliente();

        public frm_Clientes2()
        {
            InitializeComponent();
        }


        private void frm_Clientes2_Load(object sender, EventArgs e)
        {
            this.cmbBarrio.cargar("Barrio", "id_barrio", "nombre");
            this.cmbSexo.cargar("Sexo", "id_sex", "nombre");
            this.cmb_tipoDoc.cargar("Tipo_Documento", "id_doc", "descripcion");
            this.cmbEstadoCivil.cargar("Estado_Civil", "id_estado", "nombre");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cliente.validar_Cliente(this.Controls) == Validar.estado_validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = cliente.buscar_cliente(this.cmb_tipoDoc.SelectedValue.ToString(), this.txt_NumDoc.Text.ToString().Trim());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El Cliente ingresado para Modificar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.modificar_cliente(this.Controls);
                    MessageBox.Show("Cliente Modificado Correctamente", "Mensaje"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void boton_Nuevo_Click(object sender, EventArgs e)
        {
            _val.blanquear_objetos(this.Controls);
            cmb_tipoDoc.Enabled = true;
            txt_NumDoc.Enabled = true;
            this.cmb_Tipo_Doc.Focus();
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {

            if (cliente.validar_Cliente(this.Controls) == Validar.estado_validacion.correcta)
            {
                if (cliente.agregar_cliente(this.Controls) == true)
                {
                    MessageBox.Show("Cliente agregado correctamente", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            if ((this.cmb_tipoDoc.SelectedIndex != -1) && (this.txt_NumDoc.Text != ""))
            {
                cliente.eliminar(cmb_tipoDoc.SelectedValue.ToString(), txt_NumDoc.Text.Trim());
                _val.blanquear_objetos(this.Controls);
            }
            else
            {
                MessageBox.Show("Debe Ingresar el tipo de Documento y el Numero para eliminar un cliente", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            _val.blanquear_objetos(this.Controls);
            txt_Ape.Enabled = false;
            txt_Nom.Enabled = false;
            txtCalle.Enabled = false;
            txtNumCalle.Enabled = false;
            cmbSexo.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbBarrio.Enabled = false;
            dateTimePicker2.Enabled = false;
            btn_Buscar_Doc.Visible = true;
            cmb_tipoDoc.Enabled = true;
            txt_NumDoc.Enabled = true;
            btn_agregarTarjeta.Enabled = false;
            btn_mostrarTarjetas.Enabled = false;



        }

        private void btn_Buscar_Doc_Click(object sender, EventArgs e)
        {
            if(txt_NumDoc.Text == "" || cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Numero o tipo de documento no ingresado");
                _val.blanquear_objetos(this.Controls);
                return;
            }

            DataTable tabla = new DataTable();
            tabla = this.cliente.buscar_cliente(this.cmb_tipoDoc.SelectedValue.ToString(), txt_NumDoc.Text.Trim());
            if (tabla.Rows.Count == 1)
            {
                txt_Ape.Text = tabla.Rows[0]["apellido"].ToString();
                txt_Nom.Text = tabla.Rows[0]["nombres"].ToString();
                txtCalle.Text = tabla.Rows[0]["calle"].ToString();
                txtNumCalle.Text = tabla.Rows[0]["numero"].ToString();
                cmbBarrio.SelectedValue = tabla.Rows[0]["id_barrio1"];
                cmbEstadoCivil.SelectedValue = tabla.Rows[0]["estado_civil1"];
                cmbSexo.SelectedValue = tabla.Rows[0]["sexo1"];
                dateTimePicker2.Value = Convert.ToDateTime(tabla.Rows[0]["fecha_nacim"].ToString());
                btn_buscarDoc.Visible = false;
                btn_agregarTarjeta.Enabled = true;
                btn_mostrarTarjetas.Enabled = true;

            }
            else
            {
                MessageBox.Show("El cliente solicitado no se encuetra en el sistema");
            }
            cmb_tipoDoc.Enabled = false;
            txt_NumDoc.Enabled = false;
            txt_Ape.Enabled = true;
            txt_Nom.Enabled = true;
            txtCalle.Enabled = true;
            txtNumCalle.Enabled = true;
            dateTimePicker2.Enabled = true;
            cmbBarrio.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            cmbSexo.Enabled = true;
            btn_Buscar_Doc.Visible = false;
        }

        private void txtNumCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }

        private void txt_Letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true) && (char.IsWhiteSpace(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }

        private void btn_agregarTarjeta_Click(object sender, EventArgs e)
        {
            frm_TarjetaCliente tarjeta = new frm_TarjetaCliente();
            tarjeta.txt_TipoDoc.Text = this.cmb_tipoDoc.SelectedValue.ToString();
            tarjeta.txt_NumDocu.Text = this.txt_NumDoc.Text.Trim();
            tarjeta.ShowDialog();

        }


        private void btn_mostrarTarjetas_Click(object sender, EventArgs e)
        {
            if (cmb_tipoDoc.SelectedIndex == -1)
            {
                
                MessageBox.Show("No se Ingreso el tipo de Documento");
                return;
            }
            if (txt_NumDoc.Text == "")
            {
                MessageBox.Show("No se Ingreso el numero de Documento");
                return;
            }
            DataTable tabla = new DataTable();
            tabla = tarjetas.buscar_Tarjeta(this.cmb_tipoDoc.SelectedValue.ToString(), this.txt_NumDoc.Text.ToString().Trim());
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El cliente no tiene Tarjetas asociadas");
                return;
            }
            else
            {
                dataGridView1.Visible = true;
                label21.Visible = true;
                dataGridView1.DataSource = tabla;
            }

        }

        private void btn_agregar_barrio_Click(object sender, EventArgs e)
        {
           
                frm_Barrio form_Barrio = new frm_Barrio();
                form_Barrio.ShowDialog();

            if (form_Barrio.actualizar)
            {
                this.cmbBarrio.cargar("Barrio", "id_barrio", "nombre");
                form_Barrio.actualizar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_clientes_filtrados form_filtrados = new frm_clientes_filtrados();
            form_filtrados.ShowDialog();
        }
    }

}

