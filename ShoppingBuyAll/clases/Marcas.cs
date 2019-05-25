using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Data;
using System.Windows.Forms;


namespace ShoppingBuyAll.clases
{
    class Marcas
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_Marcas()
        {
            return _BD.consulta("SELECT * FROM Marcas");
        }

        public void Agregar_Marca(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = _BD.consulta("SELECT MAX(id_marca) FROM Marcas");
            string id;
            id = tabla.Rows[0]["Column1"].ToString();
            int id_nuevo = int.Parse(id) + 1;
            string sql = "";
            sql = "INSERT INTO Marcas (id_marca, descripcion) VALUES (" + id_nuevo.ToString() + ", ' " + descripcion + "')";
            MessageBox.Show(sql);
            _BD.grabar_modificar(sql);
        }

    }
}
