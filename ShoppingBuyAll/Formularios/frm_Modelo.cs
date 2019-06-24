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
    public partial class frm_Modelo : Form
    {
        public frm_Modelo()
        {
            InitializeComponent();
        }

        Marcas obj_marca = new Marcas();
        AccesoBD _BD = new AccesoBD();
        Modelo obj_modelo = new Modelo();

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (this.txt_Nombre_Modelo.Text.Trim() != "" && this.cmb_Marca.SelectedIndex != -1)
            {
                this.obj_modelo.Agregar_Modelo(this.txt_Nombre_Modelo.Text.Trim(),
                                                this.cmb_Marca.SelectedValue.ToString());
                MessageBox.Show("Se agrego correctamente el modelo");
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
        }

        private void frm_Modelo_Load(object sender, EventArgs e)
        {
            this.cmb_Marca.DataSource = this.obj_marca.Recuperar_Marcas();
            this.cmb_Marca.DisplayMember = "descripcion";
            this.cmb_Marca.ValueMember = "id_marca";
            this.cmb_Marca.SelectedValue = -1;

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
