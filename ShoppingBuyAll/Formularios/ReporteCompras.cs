using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.Formularios;
using ShoppingBuyAll.clases;


namespace ShoppingBuyAll.Formularios
{
    public partial class ReporteCompras : Form
    {
        public ReporteCompras()
        {
            InitializeComponent();
        }


        private void ReporteCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DetalleCompras' Puede moverla o quitarla según sea necesario.
            //this.detalleComprasTableAdapter.Fill(this.dataSet1.DetalleCompras);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.dataSet1.clientes);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.ComprasXCliente' Puede moverla o quitarla según sea necesario.
            //this.comprasXClienteTableAdapter.Fill(this.dataSet1.ComprasXCliente);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_repCompra_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccesoBD _BD = new AccesoBD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT V.nro_factura, V.cuil_local1, V.num_tarjeta1, 
                   V.fecha_compra, C.num_doc, C.nombres, C.apellido,
                   SUM(D.precio * D.cantidad) as 'precio'
                   FROM ComprasXCliente V JOIN DetalleCompras D ON 
                                V.nro_factura = D.nro_factura1 AND
                                V.cuil_local1 = D.cuil_local2 JOIN
                        clientes C ON
                                     V.tipo_doc1 = C.tipo_doc1 AND
                                     V.num_doc1 = C.num_doc
                   WHERE V.fecha_compra BETWEEN " + txt_FechaDesde.Text.Trim() + " AND " + txt_FechaHasta.Text.Trim()+
                   @" GROUP BY V.nro_factura, V.cuil_local1, V.num_tarjeta1, 
                            V.fecha_compra, C.num_doc, C.nombres, C.apellido";
            tabla = _BD.consulta(sql);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            comprasXClienteBindingSource.DataSource = tabla;
            clientesBindingSource.DataSource = tabla;
            detalleComprasBindingSource.DataSource = tabla;
            reportViewer1.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
