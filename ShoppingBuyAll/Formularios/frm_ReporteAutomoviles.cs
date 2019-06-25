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
    public partial class frm_ReporteAutomoviles : Form
    {
        public frm_ReporteAutomoviles()
        {
            InitializeComponent();
        }
        Automovil obj_auto = new Automovil();

        private void frm_ReporteAutomoviles_Load(object sender, EventArgs e)
        {
            DataTable tabla = this.obj_auto.autoXcliente();
            this.autoXClienteBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
