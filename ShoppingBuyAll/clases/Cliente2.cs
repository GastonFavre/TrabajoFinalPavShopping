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
                DataTable tabla_verificar_compras_cliente = new DataTable();
                string sql_verificar_compras_cliente = "SELECT * FROM ComprasXCliente WHERE tipo_doc1 = " + tipoDoc + " AND num_doc1 = " + NumDoc;
                tabla_verificar_compras_cliente = _BD.consulta(sql_verificar_compras_cliente);
                if (tabla_verificar_compras_cliente.Rows.Count == 0)
                {
                    string sql_eliminar_tarjetas = "DELETE FROM TarjetaXCliente WHERE tipo_doc3 = " + tipoDoc + " AND num_doc3 = " + NumDoc;
                    _BD.grabar_modificar(sql_eliminar_tarjetas);
                    MessageBox.Show("Las Tarjetas vinculadas al cliente fueron eliminado correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sql_eliminar = "DELETE FROM clientes WHERE tipo_doc1 = " + tipoDoc + " AND num_doc = " + NumDoc;
                    _BD.grabar_modificar(sql_eliminar);
                    MessageBox.Show("El Cliente ingresado fue eliminado correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Cliente tiene asociadas compras por lo tanto no se puede eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
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

        public DataTable clientesXSexo()
        {
            string sql = @"SELECT Sexo.nombre as descriptor
                 , count(*) as dato
                 FROM clientes join Sexo ON 
                        clientes.sexo1 = Sexo.id_sex
                 GROUP BY Sexo.nombre";
            return _BD.consulta(sql);
        }

    }
}
