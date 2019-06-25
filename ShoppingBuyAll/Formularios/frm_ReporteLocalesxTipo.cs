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
            DataTable tabla = obj_local.ventasXLocal();
            dSLocalesBindingSource.DataSource = tabla;
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        Locales obj_local = new Locales();

       
    }
}
