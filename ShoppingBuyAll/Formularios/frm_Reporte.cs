using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Reporte : Form
    {
        public frm_Reporte()
        {
            InitializeComponent();
        }

        //INTERFAZ NO HAY FUNCIONAMIENTO EN ESTA PARTE
        private void btn_Automoviles_MouseHover(object sender, EventArgs e)
        {
            btn_Automoviles.BackColor = Color.FromArgb(0, 30, 82);
        }
        private void btn_Automoviles_MouseLeave(object sender, EventArgs e)
        {
            btn_Automoviles.BackColor = Color.FromArgb(49, 66, 82);
        }
        private void btn_Estacionamiento_MouseHover(object sender, EventArgs e)
        {
            btn_Estacionamiento.BackColor = Color.FromArgb(0, 30, 82);
        }
        private void btn_Estacionamiento_MouseLeave(object sender, EventArgs e)
        {
            btn_Estacionamiento.BackColor = Color.FromArgb(49, 66, 82);
        }
        private void btn_Productos_MouseHover(object sender, EventArgs e)
        {
            btn_Productos.BackColor = Color.FromArgb(0, 30, 82);
        }
        private void btn_Productos_MouseLeave(object sender, EventArgs e)
        {
            btn_Productos.BackColor = Color.FromArgb(49, 66, 82);
        }
        private void btn_Clientes_MouseHover(object sender, EventArgs e)
        {
            btn_Clientes.BackColor = Color.FromArgb(0, 30, 82);
        }
        private void btn_Clientes_MouseLeave(object sender, EventArgs e)
        {
            btn_Clientes.BackColor = Color.FromArgb(49, 66, 82);
        }
        private void btn_Locales_MouseHover(object sender, EventArgs e)
        {
            btn_Locales.BackColor = Color.FromArgb(0, 30, 82);
        }
        private void btn_Locales_MouseLeave(object sender, EventArgs e)
        {
            btn_Locales.BackColor = Color.FromArgb(49, 66, 82);
        }
        private void btn_Ventas_MouseHover_1(object sender, EventArgs e)
        {
            btn_Ventas.BackColor = Color.FromArgb(0, 30, 82);
        }
        private void btn_Ventas_MouseLeave(object sender, EventArgs e)
        {
            btn_Ventas.BackColor = Color.FromArgb(49, 66, 82);
        }
        //------------------------------------------------------------------------

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            frm_Reporte_Productos frm_ReporteProductos = new frm_Reporte_Productos();
           
            AddOwnedForm(frm_ReporteProductos);
            frm_ReporteProductos.FormBorderStyle = FormBorderStyle.None;
            frm_ReporteProductos.TopLevel = false;
            frm_ReporteProductos.Dock = DockStyle.Fill;
            this.Controls.Add(frm_ReporteProductos);
            this.Tag = frm_ReporteProductos;
            frm_ReporteProductos.BringToFront();
            frm_ReporteProductos.Show();

        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            //frm_ReporteClientes frm_ReporteClientes = new frm_ReporteClientes();
            frm_InformeClientesXSexo frm_ReporteClientes = new frm_InformeClientesXSexo();
            AddOwnedForm(frm_ReporteClientes);
            frm_ReporteClientes.FormBorderStyle = FormBorderStyle.None;
            frm_ReporteClientes.TopLevel = false;
            frm_ReporteClientes.Dock = DockStyle.Fill;
            this.Controls.Add(frm_ReporteClientes);
            this.Tag = frm_ReporteClientes;
            frm_ReporteClientes.BringToFront();
            frm_ReporteClientes.Show();
        }

        private void btn_Locales_Click(object sender, EventArgs e)
        {
            frm_ListadoProductos form_Locales = new frm_ListadoProductos();
            AddOwnedForm(form_Locales);
            form_Locales.FormBorderStyle = FormBorderStyle.None;
            form_Locales.TopLevel = false;
            form_Locales.Dock = DockStyle.Fill;
            this.Controls.Add(form_Locales);
            this.Tag = form_Locales;
            form_Locales.BringToFront();
            form_Locales.Show();
        }
    }
}
