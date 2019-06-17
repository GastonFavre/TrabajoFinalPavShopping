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
    public partial class frm_ReporteClientes : Form
    {
        AccesoBD _BD = new AccesoBD();
        public frm_ReporteClientes()
        {
            InitializeComponent();
        }

        private void frm_ReporteClientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM clientes";
            DataTable tabla = new DataTable();
            tabla = _BD.consulta(sql);
            dSInfromeClientesBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
