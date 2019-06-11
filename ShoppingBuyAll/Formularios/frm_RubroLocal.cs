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
    public partial class frm_RubroLocal : Form
    {
        public frm_RubroLocal()
        {
            InitializeComponent();
        }

        private void frm_RubroLocal_Load(object sender, EventArgs e)
        {
            this.cmb_Rubro.cargar("Rubros", "cod_rub", "nombre");
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            RubrosXLocal locxrub = new RubrosXLocal();
            if (locxrub.validar_Rubro(this.Controls) == Validar.estado_validacion.correcta)
            {
                locxrub.agregar_Rubro(this.Controls);
                MessageBox.Show("Rubro Agregado Correctamente", "Mensaje"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Modi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
