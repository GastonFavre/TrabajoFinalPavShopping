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

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_ReporteLocalesxTipo : Form
    {
        public frm_ReporteLocalesxTipo()
        {
            InitializeComponent();
        }

        private void frm_ListadoProductos_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        Locales obj_local = new Locales();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_FechaDesde.Text != "" && txt_FechaHasta.Text != "")
            {
                string sql = "WHERE C.fecha_compra BETWEEN CONVERT(char(10),'" + txt_FechaDesde.Text.Trim() + "',103) AND CONVERT(char(10),'" + txt_FechaHasta.Text.Trim() + "',103)";
                DataTable tabla = obj_local.ventasXLocal(sql);
                dSLocalesBindingSource.DataSource = tabla;
                reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport(); ;
            }
            else
            {
                MessageBox.Show("Por favor complete los campos");
            }
        }
    }
}
