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
using ShoppingBuyAll.Formularios;

namespace ShoppingBuyAll.Formularios
{
    public partial class frm_Barrio : Form
    {
        public frm_Barrio()
        {
            InitializeComponent();
        }
        AccesoBD _BD = new AccesoBD();
        Barrio obj_barrio = new Barrio();

        public bool actualizar = false;

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (this.txt_Desc_Barrio.Text.Trim() != "")
            {
                this.obj_barrio.Agregar_Barrio(this.txt_Desc_Barrio.Text.Trim());
                MessageBox.Show("Se agrego el Barrio correctamente");
            }
            else
            {
                MessageBox.Show("Porfavor ingrese un nombre para el Barrio");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            actualizar = true;
            this.Close();
        }
    }
    

   
    
}


