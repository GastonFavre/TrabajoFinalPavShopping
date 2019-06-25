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
    public partial class frm_ReporteProductos : Form
    {
        public frm_ReporteProductos()
        {
            InitializeComponent();
        }

        private void frm_ReporteProductos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
