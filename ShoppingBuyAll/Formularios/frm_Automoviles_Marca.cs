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
    public partial class frm_Automoviles_Marca : Form
    {
        public frm_Automoviles_Marca()
        {
            InitializeComponent();
        }

        int _tipo_marca;
        int _tipo_modelo;


        public int tipo_marca
        {
            get { return this._tipo_marca; }
            set { this._tipo_marca = value; }
        }

        public int tipo_modelo
        {
            get { return this._tipo_modelo; }
            set { this._tipo_modelo = value; }
        }

        Automovil obj_automovil = new Automovil();

        private void frm_Automoviles_Marca_Load(object sender, EventArgs e)
        {
            this.dataGrid_MarcaAuto.DataSource = this.obj_automovil.Consultar_Auto_Marca(this._tipo_marca.ToString(), this._tipo_modelo.ToString());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_rest.Visible = true;
        }

        private void btn_rest_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_rest.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
