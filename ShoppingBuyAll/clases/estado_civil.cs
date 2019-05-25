using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class estado_civil
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_estado_civil()
        {
            return _BD.consulta("SELECT * FROM Estado_Civil");
        }
    }
}
