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
            DataTable tabla_ClienteExistente = new DataTable();
            tabla_ClienteExistente = buscar_cliente(tipoDoc, NumDoc);
            if (tabla_ClienteExistente.Rows.Count == 0)
            {
                MessageBox.Show("El Cliente que desea eliminar no existe.", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable tabla_ClienteConCompras = new DataTable();
                tabla_ClienteConCompras = this._BD.consulta("SELECT C.* FROM ComprasXCliente C WHERE tipo_doc1=" + tipoDoc + " AND num_doc1=" + NumDoc);
                if (tabla_ClienteConCompras.Rows.Count == 0)
                {
                    DataTable tabla_ClienteConEstacionamiento = new DataTable();
                    string sql = @"SELECT * FROM EstacXCliente WHERE tipo_doc2=" + tipoDoc + " AND nro_doc2=" + NumDoc;
                    tabla_ClienteConEstacionamiento = this._BD.consulta(sql);
                    if (tabla_ClienteConEstacionamiento.Rows.Count == 0)
                    {
                        this._BD.grabar_modificar("DELETE FROM TarjetaXCliente WHERE tipo_doc3=" + tipoDoc + " AND num_doc3=" + NumDoc);
                        this._BD.grabar_modificar("DELETE FROM automoviles WHERE tipo_doc2=" + tipoDoc + " AND num_doc1=" + NumDoc);
                        this._BD.grabar_modificar("DELETE FROM clientes WHERE tipo_doc1=" + tipoDoc + " AND num_doc=" + NumDoc);
                        MessageBox.Show("El Cliente se ha eliminado correctamente junto a sus tarjetas asociadas y sus vehiculos.", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El Cliente a utilizado el estacionamiento, por ese motivo no se puede eliminar.", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("El Cliente posee compras asociadas, por ese motivo no se puede eliminar.", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
