using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoppingBuyAll.clases;
using System.Windows.Forms;

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

        public DataTable buscar_Factura_Cliente(string nombreCli)
        {
            string sql = @"SELECT C.nro_factura AS 'Nro Factura', L.nombre AS 'Local', p.nombre AS 'Producto', P.precio AS 'Precio Prod', D.cantidad AS 'Cantidad', P.precio* D.cantidad AS 'Monto Total'
                         FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura
                                                JOIN clientes CL ON C.tipo_doc1 = CL.tipo_doc1 AND CL.num_doc = C.num_doc1
                                                JOIN Locales L ON L.cuil = D.cuil_local2
                                                JOIN Productos P ON P.cod_prod = D.cod_prod1
                         WHERE CL.nombres = '" + nombreCli + "'";
            return _BD.consulta(sql);
        }

        public DataTable buscar_Factura_Numero(string numeroFactura)
        {
            string sql = @"SELECT C.nro_factura AS 'Nro Factura', CL.nombres AS 'Nombre Cliente', CL.apellido AS 'Apellido Cliente', L.nombre AS 'Local', p.nombre AS 'Producto', P.precio AS 'Precio Prod', D.cantidad AS 'Cantidad', P.precio*D.cantidad AS 'Monto Total'
                            FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura 
                                    JOIN clientes CL ON C.tipo_doc1 = CL.tipo_doc1 AND  CL.num_doc = C.num_doc1
					                JOIN Locales L ON L.cuil = D.cuil_local2
					                JOIN Productos P ON P.cod_prod=D.cod_prod1
                            WHERE C.nro_factura = " + numeroFactura;
            return _BD.consulta(sql);
        }

        public DataTable buscar_Factura_Fecha(string fecha)
        {
            string sql = @"SELECT C.nro_factura AS 'Nro Factura', CL.nombres AS 'Nombre Cliente', CL.apellido AS 'Apellido Cliente', L.nombre AS 'Local', p.nombre AS 'Producto', P.precio AS 'Precio Prod', D.cantidad AS 'Cantidad', P.precio*D.cantidad AS 'Monto Total'
                           FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura 
                                    JOIN clientes CL ON C.tipo_doc1 = CL.tipo_doc1 AND  CL.num_doc = C.num_doc1
					                JOIN Locales L ON L.cuil = D.cuil_local2
					                JOIN Productos P ON P.cod_prod=D.cod_prod1
                           WHERE C.fecha_compra = '" + fecha + "'";
            return _BD.consulta(sql);
        }

        public DataTable buscar_Factura_precio(string precio)
        {
            string sql = @"SELECT C.nro_factura AS 'Nro Factura', CL.nombres AS 'Nombre Cliente', CL.apellido AS 'Apellido Cliente', COUNT(C.nro_factura) AS 'Cantidad De Artiuculos', SUM(P.precio*D.cantidad) AS 'Monto Total'
                           FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura 
                                JOIN clientes CL ON C.tipo_doc1 = CL.tipo_doc1 AND  CL.num_doc = C.num_doc1
					            JOIN Locales L ON L.cuil = D.cuil_local2
					            JOIN Productos P ON P.cod_prod=D.cod_prod1
                           GROUP BY C.nro_factura, CL.nombres, CL.apellido
                           HAVING SUM(P.precio*D.cantidad) > " + precio;
            return _BD.consulta(sql);
        }
        public DataTable buscar_facturaFiltrado(string comandoWhere, string comandoHaving)
        {
            if (comandoHaving != "")
            {
                string sql = @"SELECT C.nro_factura AS 'Nro Factura', CL.nombres AS 'Nombre Cliente', CL.apellido AS 'Apellido Cliente', COUNT(C.nro_factura) AS 'Cantidad De Artiuculos', SUM(P.precio*D.cantidad) AS 'Monto Total'
                             FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura
                                                JOIN clientes CL ON C.tipo_doc1 = CL.tipo_doc1 AND CL.num_doc = C.num_doc1
                                                JOIN Locales L ON L.cuil = D.cuil_local2
                                                JOIN Productos P ON P.cod_prod = D.cod_prod1 " + comandoWhere + " " + comandoHaving;
                MessageBox.Show(sql);
                return _BD.consulta(sql);
            }
            else
            {
                string sql = @"SELECT C.nro_factura AS 'Nro Factura', CL.nombres AS 'Nombre Cliente', CL.apellido AS 'Apellido Cliente', L.nombre AS 'Local', p.nombre AS 'Producto', P.precio AS 'Precio Prod', D.cantidad AS 'Cantidad', P.precio*D.cantidad AS 'Monto Total'
                         FROM ComprasXCliente C JOIN  DetalleCompras D ON D.nro_factura1 = C.nro_factura
                                                JOIN clientes CL ON C.tipo_doc1 = CL.tipo_doc1 AND CL.num_doc = C.num_doc1
                                                JOIN Locales L ON L.cuil = D.cuil_local2
                                                JOIN Productos P ON P.cod_prod = D.cod_prod1 " + comandoWhere;
                MessageBox.Show(sql);
                return _BD.consulta(sql);
            }
            
        }


    }
}
