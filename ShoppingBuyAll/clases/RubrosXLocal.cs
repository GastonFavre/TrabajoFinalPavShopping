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
            MessageBox.Show(controles.ToString());
            _BD.auto_insert(controles, "LocalesXRubro");
        }

        public DataTable buscar_Rubro(string cuil)
        {
            string sql_Buscar = @"SELECT cuil_local1 as 'CUIL', cod_rub1 as 'RUBRO' FROM LocalesXRubro WHERE
                                    cuil_local1= " + cuil;
            return this._BD.consulta(sql_Buscar);
        }

    }
}

