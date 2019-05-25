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
    public partial class DateTimePickerDeControl : DateTimePicker
    {
        public DateTimePickerDeControl()
        {
            InitializeComponent();
        }
        string nombre_tabla;
        string campo;
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

        public DateTimePickerDeControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
