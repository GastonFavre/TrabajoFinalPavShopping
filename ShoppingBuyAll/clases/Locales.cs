using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoppingBuyAll.clases;
using System.Windows.Forms;

namespace ShoppingBuyAll.Formularios
{
    class Locales
    {
        AccesoBD _BD = new AccesoBD();
        public Validar.estado_validacion validar_local(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        public void agregar_local(Control.ControlCollection controles)
        {
            MessageBox.Show(controles.ToString());
            _BD.auto_insert(controles, "Locales");
        }

        public void modificar_local(Control.ControlCollection controles, string cuil)
        {
            DataTable tabla = new DataTable();
            tabla = buscar_local(cuil);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El Local ingresado para Modificar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _BD.auto_modificar(controles, "Locales");
                MessageBox.Show("El Local ingresado fue modificado correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void eliminar_local(string cuil)
        {
            DataTable tabla = new DataTable();
            tabla = buscar_local(cuil);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El Local ingresado para Eliminar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql_eliminar = "DELETE FROM clientes WHERE cuil = " + cuil;
                _BD.grabar_modificar(sql_eliminar);
                MessageBox.Show("El Local ingresado fue eliminado correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable buscar_local(string cuil)
        {
            string sql_Buscar = @"SELECT * FROM Locales WHERE
                                    cuil= " + cuil;
            return this._BD.consulta(sql_Buscar);
        }
    }
}
