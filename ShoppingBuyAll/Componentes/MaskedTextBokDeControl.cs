using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingBuyAll.Componentes
{
    public partial class MaskedTextBokDeControl : MaskedTextBox
    {
        public MaskedTextBokDeControl()
        {
            InitializeComponent();
        }

        public enum Tipo_dato { texto, numero, fecha, hora }

        string nombre_tabla;
        string campo;
        string mensaje_error;
        bool validable;
        bool pk;

        Tipo_dato tipo;

        public Tipo_dato _tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                if (tipo == Tipo_dato.fecha)
                {
                    this.Mask = "00/00/0000";
                }
                if (tipo == Tipo_dato.hora)
                {
                    this.Mask = "00:00";
                }
            }
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

        public MaskedTextBokDeControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
