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
    public partial class salida_estacionamiento : Form
    {
        //nuevo objeto de la clase Estacionamiento

       

        Estacionamiento autoCliente = new Estacionamiento();
        Validar _val = new Validar();
        Estacionamiento estacionamiento = new Estacionamiento();

        public salida_estacionamiento()
        {
            InitializeComponent();
        }

        //se carga el formulario
      

        // en el formulario de salida busca un auto por patente 
        private void btn_Buscar_patente_Click(object sender, EventArgs e)
        {

            if (this.txt_patente.Text == "")
            {
                MessageBox.Show("No ingreso una patente");
                txt_patente.Focus();
            }
            else
            {
                DataTable tabla = new DataTable();
                DataTable tabla1 = new DataTable();

                tabla = autoCliente.consultar_lugar_playa(txt_patente.Text);

                //si no devuelve nada es porque el auto no ingreso al estacionamiento
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("Ingreso una patente que no esta en el estacionamiento");
                    this.txt_patente.Text = "";
                    this.txt_patente.Focus();
                }
                else
                { //encuentra el auto del estacionamiento y trae la informacion del auto y
                  //la informacion de su ingreso

                    txt_nroDoc.Text = tabla.Rows[0]["nro_doc2"].ToString();
                    cmb_tipoDoc.Text = tabla.Rows[0]["tipo_doc2"].ToString();
                    dt_fecha_entrada.Text = tabla.Rows[0]["fecha"].ToString();
                    txt_horaDesde.Text = tabla.Rows[0]["hora_desde"].ToString();
                    txt_idPlaya.Text = tabla.Rows[0]["id_playa1"].ToString();
                    txt_Estacionamiento.Text = tabla.Rows[0]["nro_estac"].ToString();
                    //en el id_playa devuelve null porque nunca se cargo en la tabla EstacXCliente
                    //ese error esta comentado en agregar_enEstacionamiento()

                    //calcular las horas totales 
                    txt_horaSalida.Focus();


                }
            }
        }

        //sale y cierra el formulario
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        

        //aca se elimina el auto de la tabla EstacXCliente
        //se habilitan de nuevo los lugares de la playa
        //tambien se dejan calculadas las horas total de estadia
        //se blanquean los objetos para la salida de un nuevo vehiculo

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (estacionamiento.validar_Automovil(this.Controls) == Validar.estado_validacion.correcta)
            {
                 AccesoBD _BD = new AccesoBD();
                _BD.auto_modificar(this.Controls, "EstacXCliente");
                MessageBox.Show("Se registro correctamente la salida del Vehiculo!");
                _val.blanquear_objetos(this.Controls);
            }
            

        }

        private void salida_estacionamiento_Load(object sender, EventArgs e)
        {

        }
    }
}
