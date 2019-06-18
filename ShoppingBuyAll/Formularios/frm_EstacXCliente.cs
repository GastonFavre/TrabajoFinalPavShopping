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
    public partial class frm_EstacXCliente : Form
    {
        public frm_EstacXCliente()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Estacionamiento obj_Estac = new Estacionamiento();

        private void frm_EstacXCliente_Load(object sender, EventArgs e)
        {
            DataTable tabla = this.obj_Estac.buscar_EstacionamientoClientes();
            this.dSEstacClienteBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
