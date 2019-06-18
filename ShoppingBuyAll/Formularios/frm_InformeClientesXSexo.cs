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
    public partial class frm_InformeClientesXSexo : Form
    {
        public frm_InformeClientesXSexo()
        {
            InitializeComponent();
        }

        Cliente2 obj_Cliente = new Cliente2();

        private void frm_InformeClientesXSexo_Load(object sender, EventArgs e)
        {
            DataTable tabla = this.obj_Cliente.clientesXSexo();
            this.clientesXSexoBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
