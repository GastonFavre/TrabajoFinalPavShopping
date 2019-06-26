﻿using System;
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
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Productos : Form
    {
        Producto producto = new Producto();
        AccesoBD _BD = new AccesoBD();
        public frm_Productos()
        {
            InitializeComponent();
        }
        private void blanquear_objetos()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().Name == "TextBoxDeControl")
                {
                    item.Text = "";
                }
                if (item.GetType().Name == "ComboBoxDeControl")
                {
                    ((ComboBoxDeControl)item).SelectedIndex = -1;
                }
            }
        }
        private void boton_Nuevo_Click(object sender, EventArgs e)
        {
            groupBoxFiltros.Visible = false;
            btn_BuscarCod.Visible = false;
            this.blanquear_objetos();
            txt_CodigoProducto.Enabled = true;
            this.txt_CodigoProducto.Focus();
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            btn_BuscarCod.Visible = false;

            if (producto.validar_Producto(this.Controls) == Validar.estado_validacion.correcta)
            {
                if (producto.agregar_producto(this.Controls))
                {
                    MessageBox.Show("Producto agregado correctamente", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void boton_Modi_Click(object sender, EventArgs e)
        {

            if (producto.validar_Producto(this.Controls) == Validar.estado_validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = producto.buscar_ProdCodigo(this.txt_CodigoProducto.Text.Trim());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("El Producto ingresado para Modificar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    producto.modificar_producto(this.Controls);
                    MessageBox.Show("Producto Modificado Correctamente", "Mensaje"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
           
           
        }


 

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            btn_BuscarCod.Visible = false;


            if (this.txt_CodigoProducto.Text != "") 
            {
                producto.eliminar(txt_CodigoProducto.Text.ToString().Trim());
                this.blanquear_objetos();
            }
            else
            {
                MessageBox.Show("Debe Ingresar el codigo del producto para eliminar un producto", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            groupBoxFiltros.Visible = true;
            dataGridBusqueda.DataSource = "";
            
            txt_CodigoProducto.Enabled = false;
            txt_PrecioProducto.Enabled = false;
            txt_NombreProducto.Enabled = false;
         
          
            

           
        }

        
        private void btn_BuscarCod_Click(object sender, EventArgs e)
        {
           

            if (txt_CodigoProducto.Text == "")
            {
                MessageBox.Show("Codigo de producto no ingresado");
                return;
            }

            DataTable tabla = new DataTable();
            tabla = this.producto.buscar_producto(this.txt_CodigoProducto.Text.Trim());
            if (tabla.Rows.Count == 1)
            {
                //Esta linea de codigo de abajo es para cuando modificamos el producto

                dataGridBusqueda.DataSource = tabla;
                //txt_CodigoProducto.Text = tabla.Rows[0]["cod_prod"].ToString();
                //txt_NombreProducto.Text = tabla.Rows[0]["nombre"].ToString();
                //txt_PrecioProducto.Text = tabla.Rows[0]["precio"].ToString();
                //txt_CodigoProducto.Enabled = false;
            }
            else
            {
                MessageBox.Show("El producto solicitado no se encuentra en el sistema");
            }
            txt_NombreProducto.Enabled = true;
            txt_PrecioProducto.Enabled = true;
            btn_BuscarCod.Visible = false;
            radioButtonCodigo.Checked = false;
            txt_CodigoProducto.Text = "";
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm_Productos_Load(object sender, EventArgs e)
        {
           
        }

        private void cmb_Rubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCodigo.Checked == true)
            {
                btn_BuscarCod.Visible = true;
                txt_CodigoProducto.Enabled = true;
                btnBuscarPrecio.Visible = false;
                txt_PrecioProducto.Enabled = false;
                txt_NombreProducto.Enabled = false;
                dataGridBusqueda.DataSource = "";
                txt_PrecioProducto.Text = "";
                btnBuscarNombre.Visible = false;
            }
        }

        private void radioButtonPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrecio.Checked == true)
            {
                btnBuscarPrecio.Visible = true;
                txt_PrecioProducto.Enabled = true;
                btn_BuscarCod.Visible = false;
                txt_NombreProducto.Enabled = false;
                txt_CodigoProducto.Enabled = false;
                dataGridBusqueda.DataSource = "";
                txt_CodigoProducto.Text = "";
                btnBuscarNombre.Visible = false;

            }
        }

        private void btnBuscarPrecio_Click(object sender, EventArgs e)
        {
            if (txt_PrecioProducto.Text == "")
            {
                MessageBox.Show("Precio de producto no ingresado");
                return;
            }

            DataTable tabla = new DataTable();
            tabla = this.producto.buscar_producto_precio(this.txt_PrecioProducto.Text.Trim());
            if (tabla.Rows.Count == 1)
            {
                //Esta linea de codigo de abajo es para cuando modificamos el producto
                dataGridBusqueda.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("No existen productos con el precio ingresado");
            }
            txt_NombreProducto.Enabled = true;
            txt_PrecioProducto.Enabled = true;
            btn_BuscarCod.Visible = false;
            radioButtonPrecio.Checked = false;

        }

        private void radioButtonNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNombre.Checked == true)
            {
                btnBuscarPrecio.Visible = false;
                txt_PrecioProducto.Enabled = false;
                btn_BuscarCod.Visible = false;
                txt_NombreProducto.Enabled = true;
                txt_CodigoProducto.Enabled = false;
                btnBuscarNombre.Visible = true;
                dataGridBusqueda.DataSource = "";
                txt_NombreProducto.Text = "";

            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (txt_NombreProducto.Text == "")
            {
                MessageBox.Show("Nombre de producto no ingresado");
                return;
            }

            DataTable tabla = new DataTable();
            tabla = this.producto.buscar_producto_nombre(this.txt_NombreProducto.Text.Trim());
            if (tabla.Rows.Count == 1)
            {
                //Esta linea de codigo de abajo es para cuando modificamos el producto
                dataGridBusqueda.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("No existen productos con el nombre ingresado");
            }
            txt_NombreProducto.Enabled = true;
            txt_PrecioProducto.Enabled = true;
            btnBuscarNombre.Visible = false;
            radioButtonNombre.Checked = false;
            
        }

        private void btn_filtros_Click(object sender, EventArgs e)
        {
            frm_FiltrosProductos filtroProducto= new frm_FiltrosProductos();
            AddOwnedForm(filtroProducto);
            filtroProducto.FormBorderStyle = FormBorderStyle.None;
            filtroProducto.TopLevel = false;
            filtroProducto.Dock = DockStyle.Fill;
            this.Controls.Add(filtroProducto);
            this.Tag = filtroProducto;
            filtroProducto.BringToFront();
            filtroProducto.Show();
        }
    }
    }
