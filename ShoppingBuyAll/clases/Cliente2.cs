using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoppingBuyAll.clases;
using System.Windows.Forms;
using ShoppingBuyAll.Componentes;


namespace ShoppingBuyAll.clases
{
    class Cliente2
    {
        AccesoBD _BD = new AccesoBD();
        public Validar.estado_validacion validar_Cliente(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        public bool agregar_cliente(Control.ControlCollection controles)
        {
            return _BD.auto_insert(controles, "clientes");
        }

        public void modificar_cliente(Control.ControlCollection controles)
        {
            _BD.auto_modificar(controles, "clientes");
        }

        public void eliminar(string tipoDoc, string NumDoc)
        {
            DataTable tabla = new DataTable();
            tabla = buscar_cliente(tipoDoc, NumDoc);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El Cliente ingresado para Eliminar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql_eliminar = "DELETE FROM clientes WHERE tipo_doc1 = " + tipoDoc + " AND num_doc = " + NumDoc;
                _BD.grabar_modificar(sql_eliminar);
                MessageBox.Show("El Cliente ingresado fue eliminado correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public DataTable buscar_cliente(string tipoDoc, string numero)
        {
            string sql_Buscar = @"SELECT * FROM clientes WHERE
                                    tipo_doc1= " + tipoDoc + "AND num_doc = " + numero;
            return this._BD.consulta(sql_Buscar);
        }

        public DataTable buscar_cliente_filtrado(Control.ControlCollection controles)
        {
            return _BD.buscar_filtrado(controles, "clientes");
        }


    }
}
