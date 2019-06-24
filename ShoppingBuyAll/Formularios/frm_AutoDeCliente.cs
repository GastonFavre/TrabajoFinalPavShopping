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
    public partial class frm_AutoDeCliente : Form
    {
        public frm_AutoDeCliente()
        {
            InitializeComponent();
        }

        Automovil obj_Automovil = new Automovil();
        tipos_documento obj_tipo_doc = new tipos_documento();

        private void frm_AutoDeCliente_Load(object sender, EventArgs e)
        {
            this.cmb_Tipo_Doc.DataSource = this.obj_tipo_doc.Recuperar_tipos_documento();
            this.cmb_Tipo_Doc.DisplayMember = "descripcion";
            this.cmb_Tipo_Doc.ValueMember = "id_doc";
            this.cmb_Tipo_Doc.SelectedValue = -1;


            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (this.txt_nroDoc.Text != "" && this.cmb_Tipo_Doc.SelectedValue.ToString() != "-1")
            {
                this.dataGrid_Automoviles.DataSource = this.obj_Automovil.auto_de_cliente(this.txt_nroDoc.Text, this.cmb_Tipo_Doc.SelectedValue.ToString());
            }
        }
    }
}
