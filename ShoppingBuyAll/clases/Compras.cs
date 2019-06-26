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
    class Compras
    {
        AccesoBD _BD = new AccesoBD();

        public void agregar_compra_Cliente(Control.ControlCollection controles)
        {
            MessageBox.Show(controles.ToString());
            _BD.auto_insert(controles, "ComprasXCliente");
        }

        public void agregar_compra_vacia(string pk, string local, string tipo_D, string nro_Doc)
        {
            string sql = "INSERT INTO ComprasXCliente (nro_factura, cuil_local1, tipo_doc1, num_doc1)" +
                          " VALUES (" + pk + " , " + local + " , " + tipo_D + " , " + nro_Doc + ")";
            this._BD.insert_update_delete(sql);
        }

        public void agregar_detalle(string factura, string cod, string precioUnidad, string loc, string cantidad)
        {
            string sql = "INSERT INTO DetalleCompras (nro_factura1, cuil_local2, cod_prod1, cantidad, precio) VALUES (" + factura +
                    " , " + loc + " , " + cod + " , " + cantidad + " , " + precioUnidad + ")";
            this._BD.insert_update_delete(sql);
        }

        public void eliminar_detalle(string factura, string cod, string loc)
        {
            string sql = "DELETE FROM DetalleCompras WHERE nro_factura1 = " + factura + " AND cuil_local2= " + loc + " AND cod_prod1= " + cod;
            this._BD.insert_update_delete(sql);
        }


        public string Numero_Factura(string cuil)
        {
            string pk;
            string pk_nueva;
            string sql = "";
            sql = "SELECT MAX(C.nro_factura) FROM ComprasXCliente C WHERE C.cuil_local1 = " + cuil;
            DataTable tabla = _BD.consulta(sql);
            pk = tabla.Rows[0]["Column1"].ToString();
            if (pk == "")
            {
                pk_nueva = "1";
            }
            else
            {
                pk_nueva = (int.Parse(pk) + 1).ToString();
            }
            
            return pk_nueva;
        }

    }
}
