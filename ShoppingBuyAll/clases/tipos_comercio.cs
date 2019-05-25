using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class tipos_comercio
    {
        AccesoBD _BD = new AccesoBD();

        public DataTable Recuperar_tipos_comercio()
        {
            return _BD.consulta("SELECT * FROM Tipo_Comercio");
        }

        public DataTable Buscar_tipo_com(string tipoC)
        {
            string sql_Buscar = @"SELECT * FROM Tipo_Comercio WHERE
                                    id_tipoC= " + tipoC;
            return this._BD.consulta(sql_Buscar);
        }
    }
}
