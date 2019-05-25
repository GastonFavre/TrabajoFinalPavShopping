using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class sexo
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_sexo()
        {
            return _BD.consulta("SELECT * FROM Sexo");
        }
    }
}
