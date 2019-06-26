using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoppingBuyAll.clases;
using System.Windows.Forms;
using ShoppingBuyAll.Componentes;

namespace ShoppingBuyAll.Formularios
{
    class Locales
    {
        AccesoBD _BD = new AccesoBD();
        public Validar.estado_validacion validar_local(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        public bool agregar_local(Control.ControlCollection controles)
        {
            return _BD.auto_insert(controles, "Locales");
        }

        public void modificar_local(Control.ControlCollection controles)
        {
            
           _BD.auto_modificar(controles, "Locales");
            
        }

        public void eliminar_local(string cuil)
        {
            DataTable tabla = new DataTable();
            tabla = buscar_local(cuil);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("El Local ingresado para Eliminar no existe!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql_eliminar_rubrosLocal = "DELETE FROM LocalesXRubro WHERE cuil_local1 = " + cuil;
                _BD.grabar_modificar(sql_eliminar_rubrosLocal);
                MessageBox.Show("Los Rubros vinculados al local fueron eliminados correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sql_eliminar = "DELETE FROM Locales WHERE cuil = " + cuil;
                _BD.grabar_modificar(sql_eliminar);
                MessageBox.Show("El Local ingresado fue eliminado correctamente!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable buscar_local(string cuil)
        {
            string sql_Buscar = @"SELECT * FROM Locales WHERE
                                    cuil= " + cuil;
            return this._BD.consulta(sql_Buscar);
        }

        public DataTable buscar_local_filtrado(Control.ControlCollection controles)
        {
                return _BD.buscar_filtrado(controles, "Locales");
        }

        public DataTable localXTipo()
        {
            string sql = @"SELECT T.descripcion, L.cuil, L.nombre FROM Locales L JOIN Tipo_Comercio T ON T.id_tipoC = tipo_Comercio1
                          GROUP BY T.descripcion, L.cuil, L.nombre
                          ORDER BY T.descripcion";
            return _BD.consulta(sql);
        }


        public DataTable ventasXLocal()
        {
            string sql = @"SELECT L.nombre as descriptor,  COUNT(*) as dato FROM Locales L JOIN ComprasXCliente C ON C.cuil_local1 = L.cuil
                          GROUP BY L.nombre, L.cuil";

            return _BD.consulta(sql);
        }

        public DataTable buscar_Locales_Filtrado(string comando)
        {
            string sql = "SELECT cuil AS 'CUIL', nombre AS 'Nombre Local', tipo_Comercio1 AS 'Tipo Comercio' FROM Locales" + comando;
            return _BD.consulta(sql);
        }
    }  
}
