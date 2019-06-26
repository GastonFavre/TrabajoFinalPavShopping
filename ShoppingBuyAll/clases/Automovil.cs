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

        public DataTable auto_de_cliente(string doc, string tipo)
        {
            string sql = @"SELECT A.patente as Patente, MO.nombre as Modelo, T.descripcion as 'Tipo Doc', A.num_doc1 as 'Nro Doc', TA.nombre as 'Tipo Auto', M.descripcion as Marca 
                          FROM automoviles A JOIN Marcas M ON M.id_marca = A.id_marca1 
                          JOIN Tipo_Documento T ON A.tipo_doc2 = T.id_doc
                          JOIN Tipo_Auto TA ON TA.cod_tipo = A.cod_tipo1
                          JOIN Modelo MO ON A.modelo = MO.id_modelo
                          WHERE tipo_doc2 = " + tipo + " AND num_doc1 = " + doc;
            return _BD.consulta(sql);
        }

        public DataTable Consultar_Auto_Marca(string marca, string modelo)
        {
            string sql = @"SELECT A.patente as Patente, MO.nombre as Modelo, T.descripcion as 'Tipo Doc', A.num_doc1 as 'Nro Doc', TA.nombre as 'Tipo Auto', M.descripcion as Marca 
                          FROM automoviles A JOIN Marcas M ON M.id_marca = A.id_marca1 
                          JOIN Tipo_Documento T ON A.tipo_doc2 = T.id_doc
                          JOIN Tipo_Auto TA ON TA.cod_tipo = A.cod_tipo1
                          JOIN Modelo MO ON A.modelo = MO.id_modelo
                          WHERE A.modelo = " + modelo + " AND A.id_marca1 = " + marca;
            return _BD.consulta(sql);
        }

        public DataTable autoXcliente()
        {
            string sql = @" SELECT TOP(5) C.nombres as descriptor, count(*) as dato FROM clientes C JOIN
                         automoviles A ON A.num_doc1 = C.num_doc AND A.tipo_doc2 = C.tipo_doc1
                         GROUP BY C.nombres, C.num_doc, C.tipo_doc1";
            return _BD.consulta(sql);
        }
    }
}
