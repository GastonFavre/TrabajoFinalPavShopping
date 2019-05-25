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
    public partial class frm_Facturas : Form
    {
        
        public frm_Facturas()
        {
            InitializeComponent();
        }

        Facturas factura = new Facturas();
        private void btn_CargarGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = factura.buscar_Factura(textBoxDeControl1.Text.Trim());
        }
    }
}
