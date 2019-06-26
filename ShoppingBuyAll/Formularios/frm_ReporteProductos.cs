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
    public partial class frm_ReporteProductos : Form
    {
        public frm_ReporteProductos()
        {
            InitializeComponent();
        }
        Producto obj_producto = new Producto();


        private void frm_ReporteProductos_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_FechaDesde.Text != "" && txt_FechaHasta.Text != "")
            {
                string sql = "WHERE C.fecha_compra BETWEEN CONVERT(char(10),'" + txt_FechaDesde.Text.Trim() + "',103) AND CONVERT(char(10),'" + txt_FechaHasta.Text.Trim() +"',103)";
                DataTable tabla = obj_producto.topProductos(sql);
                this.topProductosBindingSource.DataSource = tabla;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Por favor complete los campos");
            }
        }
    }
}
