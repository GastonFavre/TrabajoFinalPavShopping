using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class tipos_documento
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_tipos_documento()
        {
            return _BD.consulta("SELECT * FROM Tipo_Documento");
        }
    }
}
