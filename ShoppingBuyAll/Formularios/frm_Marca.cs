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
    public partial class frm_Marca : Form
    {
        public frm_Marca()
        {
            InitializeComponent();
        }

        AccesoBD _BD = new AccesoBD();
        Marcas obj_Marcas = new Marcas();

        public bool act = false;
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (this.txt_Desc_Marca.Text.Trim() != "")
            {
                this.obj_Marcas.Agregar_Marca(this.txt_Desc_Marca.Text);
                MessageBox.Show("Se agrego la marca correctamente");
            }
            else
            {
                MessageBox.Show("Porfavor ingrese un nombre para la marca");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.act = true;
            this.Close();
        }
    }
}
