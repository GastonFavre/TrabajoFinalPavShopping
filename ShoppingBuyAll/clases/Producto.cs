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
    class Producto
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable buscar_ProdCodigo(string cod_prod)
        {
            string sql_Buscar = @"SELECT * FROM Productos WHERE
                                    cod_prod= " + cod_prod;
            return this._BD.consulta(sql_Buscar);
        }

        public DataTable buscar_x_nombre(string patron)
        {
            string sqlpatron = "";

            sqlpatron = @"SELECT * FROM Productos WHERE nombre like ' %" + patron.Trim() + "%'";
            return _BD.consulta(sqlpatron);
        }
        public Validar.estado_validacion validar_Producto(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        public bool agregar_producto(Control.ControlCollection controles)
        {
            return _BD.auto_insert(controles, "Productos");
        }

        public void modificar_producto(Control.ControlCollection controles)
        {
            _BD.auto_modificar(controles, "Productos");
        }

        public void eliminar(string codProducto)
        {
            DataTable tabla = new DataTable();
            tabla = buscar_producto(codProducto);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El codigo ingresado no existe", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _BD.grabar_modificar("DELETE FROM Productos WHERE cod_prod = " + codProducto);
                MessageBox.Show("Producto Eliminado Correctamente", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        public DataTable buscar_producto(string codProducto)
        {
            string sql_Buscar = @"SELECT * FROM Productos WHERE cod_prod = " + codProducto;
            return this._BD.consulta(sql_Buscar);
        }
        public DataTable buscar_producto_precio(string precio)
        {
            string sql_Buscar = "SELECT * FROM Productos WHERE precio = " + precio;
            return this._BD.consulta(sql_Buscar);
        }
        public DataTable buscar_producto_nombre(string nombre)
        {
            string sql_Buscar = "SELECT * FROM Productos WHERE nombre = '" + nombre + "'";
            return this._BD.consulta(sql_Buscar);
        }

        public DataTable buscar_productos_filtrado(string comando)
        {
            string sql = "SELECT cod_prod AS 'Codigo Producto', nombre AS 'Nombre Producto', precio 'Precio en $' FROM Productos" + comando;
            return _BD.consulta(sql);
        }

        public DataTable topProductos(string where)
        {
            string sql = @"SELECT TOP(5) p.nombre as descriptor, SUM (D.cantidad) as dato FROM
                         Productos p JOIN DetalleCompras D ON D.cod_prod1 = p.cod_prod JOIN ComprasXCliente C ON C.nro_factura = D.nro_factura1 " + where + 
                         " GROUP BY p.nombre, p.cod_prod " ;
            return _BD.consulta(sql);
        }
    }
}
