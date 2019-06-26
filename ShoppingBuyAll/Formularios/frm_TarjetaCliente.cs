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
    public partial class frm_TarjetaCliente : Form
    {
        public frm_TarjetaCliente()
        {
            InitializeComponent();
        }


        private void boton_Modi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            TarjetaXCliente tarjeta = new TarjetaXCliente();
            
            if (tarjeta.validar_Tarjeta(this.Controls) == Validar.estado_validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = tarjeta.verificarTarjetaCliente(this.cmb_TipoDoc.SelectedValue.ToString(), this.txt_NumDocu.Text.Trim(), this.cmb_CodTarjeta.SelectedValue.ToString());
                if (tabla.Rows.Count == 0)
                {
                    tarjeta.agregar_Tarjeta(this.Controls);
                    MessageBox.Show("Tarjeta Agregada Correctamente.");
                }
                else
                {
                    MessageBox.Show("La tarjeta que se desea agregar ya se encuentra registrada.");
                }
                
            }

        }

        private void frm_TarjetaCliente_Load(object sender, EventArgs e)
        {
            frm_Clientes2 cliente = new frm_Clientes2();
            this.cmb_CodTarjeta.cargar("MarcaTarjetas", "cod_Tarje", "nombre");
        }
    }
}
