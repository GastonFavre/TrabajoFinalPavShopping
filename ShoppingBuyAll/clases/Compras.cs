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

        public void agregar_compra_vacia(string pk, string local, string tipo_D, string nro_Doc, string fecha)
        {
            string sql = "INSERT INTO ComprasXCliente (nro_factura, cuil_local1, tipo_doc1, num_doc1, fecha_compra)" +
                          " VALUES (" + pk + " , " + local + " , " + tipo_D + " , " + nro_Doc + " , " +  fecha + ")";
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

        public void agregar_Tarjeta_Factura(string nro_factura, string cod_Tarjeta, string num_Tarjeta, string tipoDoc, string numDoc)
        {
            string sql = @"UPDATE ComprasXCliente 
                            SET tipo_doc1 = " + tipoDoc + ", num_doc1 = " + numDoc + ", cod_tarjeta1 = " + cod_Tarjeta + ", num_tarjeta1 = " + num_Tarjeta +
                            " WHERE nro_factura =" + nro_factura;
            MessageBox.Show(sql);
            this._BD.grabar_modificar(sql);
        }

        public string obtenerIDCodigoTarejta(string codigo)
        {
            if (codigo != "")
            {
                string sql = @"SELECT cod_tarje FROM MarcaTarjetas WHERE nombre = '" + codigo + "'";
                DataTable tabla = new DataTable();
                tabla = this._BD.consulta(sql);
                if (tabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    return tabla.Rows[0][0].ToString();
                }
            }
            else
            {
                return null;
            }
            
            
        }

        public DataTable verificarItemSeleccionado(string nroFactura, string cuilLocal, string cod_prod)
        {
            string sql = @"SELECt * FROM DetalleCompras
                            WHERE nro_factura1 = " + nroFactura + " AND cuil_Local2 = " + cuilLocal + " AND cod_prod1  = " + cod_prod;
            return _BD.consulta(sql);
        }
    }
}
