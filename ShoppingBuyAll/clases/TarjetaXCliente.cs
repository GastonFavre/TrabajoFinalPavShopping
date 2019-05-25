using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.Componentes;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class TarjetaXCliente
    {
        AccesoBD _BD = new AccesoBD();
        public Validar.estado_validacion validar_Tarjeta(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        public void agregar_Tarjeta(Control.ControlCollection controles)
        {
            MessageBox.Show(controles.ToString());
            _BD.auto_insert(controles, "TarjetaXCliente");
        }

        public DataTable buscar_Tarjeta(string tipoDoc, string numero)
        {
            string sql_Buscar = @"SELECT cod_tarje3 as 'Codigo', nro_tarje3 as 'Numero', fecha_venc as 'Vencimiento' FROM TarjetaXCliente WHERE
                                    tipo_doc3= " + tipoDoc + "AND num_doc3 = " + numero;
            return this._BD.consulta(sql_Buscar);
        }

       
    }
}
