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
    class Barrio
    {

        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_barrio()
        {

            return _BD.consulta("SELECT * FROM Barrio");
        }
        public void Agregar_Barrio(string descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = _BD.consulta("SELECT MAX(id_barrio) FROM Barrio");
            string id;
            id = tabla.Rows[0]["Column1"].ToString();
            int id_nuevo = int.Parse(id) + 1;
            string sql = "";
            sql = "INSERT INTO Barrio (id_barrio, nombre) VALUES (" + id_nuevo.ToString() + ", ' " + descripcion + "')";
            _BD.grabar_modificar(sql);
        }
    }
}
