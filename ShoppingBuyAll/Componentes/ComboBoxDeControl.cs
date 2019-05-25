using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoppingBuyAll.clases;
using System.Windows.Forms;

namespace ShoppingBuyAll.Componentes
{
    public partial class ComboBoxDeControl : ComboBox
    {
        string nombre_tabla;
        string campo;
        string mensaje_error;
        bool validable;
        bool pk;


        public string _nombre_tabla
        {
            get { return nombre_tabla; }
            set { nombre_tabla = value; }
        }
        public string _campo
        {
            get { return campo; }
            set { campo = value; }
        }
        public string _mensaje_error
        {
            get { return mensaje_error; }
            set { mensaje_error = value; }
        }
        public bool _validable
        {
            get { return validable; }
            set { validable = value; }
        }
        public bool _pk
        {
            get { return pk; }
            set { pk = value; }
        }

        public void cargar(string nombre_tabla, string pk, string descriptor)
        {
            AccesoBD _BD = new AccesoBD();
            this.DataSource = _BD.consulta("SELECT * FROM " + nombre_tabla);
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
        }

        public void cargar(DataTable tabla, string pk, string descriptor)
        {
            this.DataSource = tabla;
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
        }
    }
}