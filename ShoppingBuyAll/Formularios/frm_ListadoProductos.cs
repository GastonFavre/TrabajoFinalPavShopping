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
    public partial class frm_ListadoProductos : Form
    {
        public frm_ListadoProductos()
        {
            InitializeComponent();
        }

        private void frm_ListadoProductos_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Locales obj_local = new Locales();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = obj_local.localXTipo();
            localXtipoBindingSource.DataSource = tabla;
            reportViewer1.RefreshReport();

        }
    }
}
