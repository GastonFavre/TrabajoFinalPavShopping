using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class RubrosXLocal
    {
        AccesoBD _BD = new AccesoBD();
        public Validar.estado_validacion validar_Rubro(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        public void agregar_Rubro(string cuil, string id)
        {
            string sql_agregar = @"INSERT INTO RubrosXLocal(cuil_Local, id_rubro) VALUES ('" + cuil + "', "
                + id + " ')";
          
        }

        public DataTable buscar_Rubro(string cuil_Local, string id_rubro)
        {
            string sql_Buscar = @"SELECT cuil_Local as 'Cuil', id_rubro as 'Rubro' FROM RubrosXLocal WHERE
                                    cuil_Local= " + cuil_Local + "AND id_rubro = " + id_rubro;
            return this._BD.consulta(sql_Buscar);
        }
    }
}

