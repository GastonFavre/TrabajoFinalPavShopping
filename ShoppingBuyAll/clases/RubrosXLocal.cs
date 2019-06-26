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

        public void agregar_Rubro(Control.ControlCollection controles)
        {
            _BD.auto_insert(controles, "LocalesXRubro");
        }

        public DataTable buscar_Rubro(string cuil)
        {
            string sql_Buscar = @"SELECT L.cuil_local1 as 'CUIL', R.nombre as 'RUBRO' FROM LocalesXRubro L JOIN Rubros R ON L.cod_rub1 = R.cod_rub WHERE
                                    cuil_local1= " + cuil;
            return this._BD.consulta(sql_Buscar);
        }

        public DataTable buscar_rubro_local(string cuil, string rubro)
        {
            string sql_Buscar = @"SELECT * FROM LocalesXRubro WHERE cuil_local1= " + cuil + " AND cod_rub1= " + rubro;
            return this._BD.consulta(sql_Buscar);
        }
    }
}

