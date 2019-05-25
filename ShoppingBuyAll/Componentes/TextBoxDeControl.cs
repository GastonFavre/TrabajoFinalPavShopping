using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Windows.Forms;

namespace ShoppingBuyAll.Componentes
{
    public partial class TextBoxDeControl : TextBox
    {
        public enum Tipo_dato { texto, numero }

        string nombre_tabla;
        string campo;
        string mensaje_error;
        bool validable;
        bool pk;

        Tipo_dato tipo;

        public Tipo_dato _tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
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

        [Browsable(true), DefaultValue(true)]
        public new bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }
    }
}
