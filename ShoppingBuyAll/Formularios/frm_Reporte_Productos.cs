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

namespace ShoppingBuyAll
{
    public partial class frm_Reporte_Productos : Form
    {
        AccesoBD _BD = new AccesoBD();
        public frm_Reporte_Productos()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_TopProductos.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.DS_TopProductos.Productos);
            // TODO: esta línea de código carga datos en la tabla 'DS_InfromeClientes.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.DS_InfromeClientes.clientes);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT P.cod_prod, P.nombre, SUM(D.cantidad)
                            FROM Productos P JOIN DetalleCompras D ON P.cod_prod = D.cod_prod1
                            GROUP BY P.cod_prod, P.nombre";
            DataTable tabla = new DataTable();
            tabla = _BD.consulta(sql);
            ProductosBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
