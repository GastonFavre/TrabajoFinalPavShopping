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
    public partial class frm_LocalPorTipo : Form
    {
        public frm_LocalPorTipo()
        {
            InitializeComponent();
        }
        Locales obj_local = new Locales();

        private void frm_LocalPorTipo_Load(object sender, EventArgs e)
        {
            this.cmb_tipo_com.cargar("Tipo_Comercio", "id_tipoC", "descripcion");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (this.cmb_tipo_com.SelectedValue.ToString() != "1")
            {
                this.dataGrid_LocXTipo.DataSource = this.obj_local.local_por_rubro(this.cmb_tipo_com.SelectedValue.ToString());
            }
        }
    }
}
