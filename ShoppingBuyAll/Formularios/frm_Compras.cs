using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.clases;
using ShoppingBuyAll.Componentes;
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll
{
    public partial class frm_Compras : Form
    {
        Cliente2 Cliente = new Cliente2();
        Producto Selec_producto = new Producto();
        AccesoBD _BD = new AccesoBD();
        Locales Selec_local = new Locales();
        tipos_comercio Selec_tipo_com = new tipos_comercio();
        Validar validacion = new Validar();
        TarjetaXCliente tarjetas = new TarjetaXCliente();
        Compras compras = new Compras();

        string cod = "";
        string nom = "";
        string precioUnidad = "";
        string loc = "";
        string cantidad = "";
        string precioTotal = "";


        public frm_Compras()
        {
            InitializeComponent();
        }


        private void frm_Compras_Load(object sender, EventArgs e)
        {
            this.cmb_TipoDoc.cargar("Tipo_Documento", "id_doc", "descripcion");
            this.cmb_TipoDoc.SelectedIndex = -1;
        }

        private void btn_bucarCliente_Click(object sender, EventArgs e)
        {
            if (this.txt_NumeroDoc.Text != "" & this.cmb_TipoDoc.SelectedIndex != -1)
            {
                DataTable tabla = new DataTable();
                tabla = this.Cliente.buscar_cliente(this.cmb_TipoDoc.SelectedValue.ToString(), this.txt_NumeroDoc.Text.Trim());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El Cliente ingresado no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_NumeroDoc.Text = "";
                    this.cmb_TipoDoc.SelectedIndex = -1;
                    this.txt_NumeroDoc.Focus();
                }
                else
                {
                    this.txt_Apellido.Text = tabla.Rows[0]["apellido"].ToString();
                    this.txt_Nombre.Text = tabla.Rows[0]["nombres"].ToString();
                    this.txt_Cod_Pod.Enabled = true;
                    this.txt_cuil.Enabled = true;
                    this.btn_agregar.Enabled = true;
                    this.btn_Buscar_Prod.Enabled = true;
                    this.button9.Enabled = true;
                    this.btn_quitar.Enabled = true;
                    
                    this.btn_busc_loc.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Faltan datos. Para buscar al cliente primero debe ingresar el Numero y Tipo de Documento.");
                this.txt_NumeroDoc.Text = "";
                this.cmb_TipoDoc.SelectedIndex = -1;
                this.txt_NumeroDoc.Focus();
            }
        }

        private void btn_Buscar_Prod_Click(object sender, EventArgs e)
        {
            if (this.txt_Cod_Pod.Text != "")
            {
                DataTable tabla = new DataTable();
                tabla = this.Selec_producto.buscar_ProdCodigo(this.txt_Cod_Pod.Text.Trim());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El producto ingresado no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_Cod_Pod.Text = "";
                    this.txt_Cod_Pod.Focus();
                }
                else
                {
                    this.txt_Nom_Prod.Text = tabla.Rows[0]["nombre"].ToString();
                    this.txt_Precio_Prod.Text = tabla.Rows[0]["precio"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos. Para buscar el producto primero debe ingresar el Codigo del mimso.");
                this.txt_Cod_Pod.Text = "";
                this.txt_Cod_Pod.Focus();
            }

            }

        private void button9_Click(object sender, EventArgs e)
        {
            btn_Buscar_Prod.Enabled = false;
            txt_Cod_Pod.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = _BD.consulta("SELECT * FROM productos");
            if(tabla.Rows.Count != 0)
            {
                grid_product.DataSource = tabla;
            }
            else
            {
                return;
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid_product.SelectedRows)
            {
                cod = this.grid_product.CurrentRow.Cells[0].Value.ToString();
                nom = this.grid_product.CurrentRow.Cells[1].Value.ToString();
                precioUnidad = this.grid_product.CurrentRow.Cells[2].Value.ToString();
                cantidad = txt_cantidad.Value.ToString();
                precioTotal = Convert.ToString(int.Parse(precioUnidad) * int.Parse(cantidad));
                loc = this.txt_nom_loc.Text;

                if (cod != "" && nom !="" && precioUnidad != "" && loc != "")
                {
                    grid_compra.AutoGenerateColumns = false;
                    grid_compra.Rows.Add(cod, nom, precioUnidad, loc, cantidad, precioTotal);
                    this.compras.agregar_detalle(this.num_factur.Text, cod, precioUnidad, this.txt_cuil.Text, cantidad);
                    txt_Total.Text = calcularTotal();
                }
                else
                {
                    MessageBox.Show("Faltan Datos", "importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public string calcularTotal()
        {
            int suma = 0;
            for (int i = 0; i < grid_compra.RowCount ; i++)
            {
                suma += int.Parse(grid_compra.Rows[i].Cells[5].Value.ToString());
            }
            return suma.ToString();
        }

        private void btn_busc_loc_Click(object sender, EventArgs e)
        {
            if(this.txt_cuil.Text != "")
            {
                DataTable tabla_loc = new DataTable();
                tabla_loc = this.Selec_local.buscar_local(this.txt_cuil.Text.Trim());
                if (tabla_loc.Rows.Count == 0)
                {
                    MessageBox.Show("El local no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_cuil.Focus();
                }
                else
                {
                    DataTable tabla_tipo = new DataTable();
                    tabla_tipo = this.Selec_tipo_com.Buscar_tipo_com(tabla_loc.Rows[0]["tipo_Comercio1"].ToString());
                    this.txt_nom_loc.Text = tabla_loc.Rows[0]["nombre"].ToString();
                    this.txt_tipo_loc.Text = tabla_tipo.Rows[0]["descripcion"].ToString();

                    string pk_Factura = this.compras.Numero_Factura(this.txt_cuil.Text.Trim());
                    this.num_factur.Text = pk_Factura;
                    this.btn_busc_loc.Enabled = false;
                    this.num_factur.Enabled = false;
                    this.txt_cuil.Enabled = false;
                    this._BD.iniciar_transaccion();
                    this.compras.agregar_compra_vacia(pk_Factura, this.txt_cuil.Text.Trim(), this.cmb_TipoDoc.SelectedValue.ToString().Trim(),
                                                        this.txt_NumeroDoc.Text.Trim());
                    MessageBox.Show("Inicio la transaccion");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos. Para Buscar el local primero debe ingresar el numero CUIT del mismo");
            }
        }

     
        private void rbt_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmb_TipoDoc.SelectedIndex != -1 || txt_NumeroDoc.Text != "")
            {
                this.cmb_tarjeta.DataSource = tarjetas.buscar_Tarjeta(this.cmb_TipoDoc.SelectedValue.ToString(), this.txt_NumeroDoc.Text.ToString().Trim());
                this.cmb_tarjeta.DisplayMember = "Numero";
                this.cmb_tarjeta.ValueMember = "Codigo";
                this.cmb_tarjeta.Enabled = true;
                this.cmb_tarjeta.SelectedIndex = -1;
                this.txt_cod_seg.Text = "";
                this.btn_finalizar.Enabled = true;
            }
            else
            {
                rbt_tar.Checked = false;
                MessageBox.Show("Por favor ingrese los datos de un cliente");
            }
        }



        private void cmb_tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_tarjeta.SelectedIndex != -1)
            {
                this.txt_cod_seg.Text = this.cmb_tarjeta.SelectedValue.ToString();
            }
        }

        private void rbt_eft_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_tarjeta.SelectedIndex = -1;
            this.cmb_tarjeta.Enabled = false;
            this.txt_cod_seg.Text = "";
            this.btn_finalizar.Enabled = true;
            
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            int fila = grid_compra.CurrentRow.Index;
            
            string cod = grid_compra.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(cod);
            this.compras.eliminar_detalle(this.num_factur.Text, cod , this.txt_cuil.Text);
            MessageBox.Show("Se elimino correctamente el item!");
            grid_compra.Rows.RemoveAt(fila);
            txt_Total.Text = calcularTotal();
        }


        private void btn_caclularTotal_Click(object sender, EventArgs e)
        {
    
        }

        

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (rbt_tar.Checked == true || rbt_eft.Checked == true)
            {
                this._BD.cerrar_transaccion();
                MessageBox.Show("Se finalizo la compra con exito");
                this.Dispose();                
            }
            else
            {
                MessageBox.Show("No se Selecciono el metodo de pago. Para finalizar la compra debe seleccionar uno.");
                return;

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

