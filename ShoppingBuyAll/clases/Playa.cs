using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class Playa
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_playa()
        {
            return _BD.consulta("SELECT * FROM Playa");
        }
    }
}
