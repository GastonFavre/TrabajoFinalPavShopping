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
    class Modelo
    {
        int _tipo_marca;

        public int tipo_marca
        {
            get { return this._tipo_marca; }
            set { this._tipo_marca = value; }
        }


        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_Modelos()
        {
            this._tipo_marca += 1;
            return _BD.consulta("SELECT * FROM Modelo WHERE id_marca1=" + _tipo_marca.ToString());
        }

        public void Agregar_Modelo(string nombre, string marca)
        {
            DataTable tabla = new DataTable();
            tabla = _BD.consulta("SELECT MAX(id_modelo) FROM Modelo");
            string id;
            id = tabla.Rows[0]["Column1"].ToString();
            int id_nuevo = int.Parse(id) + 1;
            string sql = "";
            sql = "INSERT INTO Modelo (id_modelo, nombre, id_marca1) VALUES (" + id_nuevo.ToString() + ", ' " + nombre + "', " + marca + ")";
            _BD.grabar_modificar(sql);

        }


    }
}
