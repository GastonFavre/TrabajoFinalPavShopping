﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Reporte : Form
    {
        public frm_Reporte()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            frm_ReporteProductos frm_ReporteProductos = new frm_ReporteProductos();
           
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
            frm_ReporteLocalesxTipo form_Locales = new frm_ReporteLocalesxTipo();
            AddOwnedForm(form_Locales);
            form_Locales.FormBorderStyle = FormBorderStyle.None;
            form_Locales.TopLevel = false;
            form_Locales.Dock = DockStyle.Fill;
            this.Controls.Add(form_Locales);
            this.Tag = form_Locales;
            form_Locales.BringToFront();
            form_Locales.Show();
        }

        private void btn_Estacionamiento_Click(object sender, EventArgs e)
        {
            frm_EstacXCliente form_Est = new frm_EstacXCliente();
            AddOwnedForm(form_Est);
            form_Est.FormBorderStyle = FormBorderStyle.None;
            form_Est.TopLevel = false;
            form_Est.Dock = DockStyle.Fill;
            this.Controls.Add(form_Est);
            this.Tag = form_Est;
            form_Est.BringToFront();
            form_Est.Show();
        }

        private void btn_Automoviles_Click(object sender, EventArgs e)
        {
            frm_ReporteAutomoviles form_repo_comp = new frm_ReporteAutomoviles();
            AddOwnedForm(form_repo_comp);
            form_repo_comp.FormBorderStyle = FormBorderStyle.None;
            form_repo_comp.TopLevel = false;
            form_repo_comp.Dock = DockStyle.Fill;
            this.Controls.Add(form_repo_comp);
            this.Tag = form_repo_comp;
            form_repo_comp.BringToFront();
            form_repo_comp.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
        
            ReporteCompras form_repo_comp = new ReporteCompras();
            AddOwnedForm(form_repo_comp);
            form_repo_comp.FormBorderStyle = FormBorderStyle.None;
            form_repo_comp.TopLevel = false;
            form_repo_comp.Dock = DockStyle.Fill;
            this.Controls.Add(form_repo_comp);
            this.Tag = form_repo_comp;
            form_repo_comp.BringToFront();
            form_repo_comp.Show();
        }
    }
}
