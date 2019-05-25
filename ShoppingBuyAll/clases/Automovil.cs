using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Data;
using System.Windows.Forms;
using ShoppingBuyAll.Componentes;

namespace ShoppingBuyAll.clases
{
    class Automovil
    {

        AccesoBD _BD = new AccesoBD();


        int _tipo_marca;




        public int tipo_marca
        {
            get { return this._tipo_marca; }
            set { this._tipo_marca = value; }
        }


        public DataTable Consultar_Automovil(string patente)
        {
            string SqlBuscar = "SELECT * FROM automoviles WHERE patente = '" + patente + "'";
            return _BD.consulta(SqlBuscar);

        }

        public void Eliminar_automovil(string patente)
        {

            DataTable tabla = new DataTable();
            tabla = Consultar_Automovil(patente);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("La Patente ingresada para Eliminar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string SqlEliminar;
                SqlEliminar = "DELETE FROM automoviles WHERE patente= '" + patente + "'";
                MessageBox.Show("Se elimino correctamente el automovil con patente " + patente);
                _BD.grabar_modificar(SqlEliminar);
            }
            
        }

        public void auto_Insert_A(Control.ControlCollection controles)
        {
           
            _BD.auto_insert(controles, "automoviles");
        }

        public void auto_modificar_A(Control.ControlCollection controles)
        {
            _BD.auto_modificar(controles, "automoviles");
        }

        public Validar.estado_validacion validar_automovil(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }


    }
}
