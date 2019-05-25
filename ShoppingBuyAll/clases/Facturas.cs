using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoppingBuyAll.clases;

namespace ShoppingBuyAll.clases
{
    class Facturas
    {
        AccesoBD _BD = new AccesoBD();
        public DataTable buscar_Factura(string pk)
        {
            string sql = "SELECT * FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura";
            return _BD.consulta(sql);
        }
    }
}
