using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBuyAll.clases;
using System.Windows.Forms;
using ShoppingBuyAll.Componentes;
using System.Data;

namespace ShoppingBuyAll.clases
{
    class Estacionamiento

    {
        //se crea un objeto de la clase AccesoBD
        AccesoBD _BD = new AccesoBD();

        //validar cliente
        public Validar.estado_validacion validar_Cliente(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        //validar automovil
        public Validar.estado_validacion validar_Automovil(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        //consulta que la patente este la tabla automoviles es decir que ya este asignada
        //a un cliente registrado

        public DataTable Consultar_Automovil_Cliente(string patente)
        {
            //string SqlBuscar = "SELECT * FROM automoviles WHERE patente = '" + patente + "'";
            string SqlBuscar = "SELECT * FROM automoviles WHERE patente = '" + patente + "'";
            return _BD.consulta(SqlBuscar);

        }
        //consulta el nombre y apellido del dueño del automovil que se esta ingresando
        //al estacionamiento

        public DataTable Consultar_Cliente(string num_doc)
        {
            //string SqlBuscar = "SELECT * FROM automoviles WHERE patente = '" + patente + "'";
            string SqlBuscar = "SELECT nombres, apellido FROM clientes WHERE num_doc = '" + num_doc + "'";
            return _BD.consulta(SqlBuscar);

        }
        
        //se usa para validar que no se ingrese dos veces la misma patente al estacionamiento
        public DataTable consultar_lugar_playa(string patente)
        {
            string SqlBuscar = "SELECT * FROM EstacXCliente WHERE patente_1 = '" + patente + "' AND hora_hasta IS NULL";
            return _BD.consulta(SqlBuscar);

        }

        //validar el objeto autoCliente
        public Validar.estado_validacion validar_autoCliente(Control.ControlCollection controles)
        {
            Validar validacion = new Validar();
            return validacion.validar_Form(controles);
        }

        //se usa el auto_insert para insertar los datos en la tabla "EstacXCliente"
        // no se carga id_playa1 , el txt de control si se usa para agregarla a esta tabla tira
        //un error con la clave foranea
        public void agregar_enEstacionamiento(Control.ControlCollection controles)
        {
            MessageBox.Show(controles.ToString());
            _BD.auto_insert(controles, "EstacXCliente");
        }

        public DataTable buscar_estacionamiento_filtrado(Control.ControlCollection controles)
        {
            return _BD.buscar_filtrado(controles, "EstacXCliente");
        }


    }
}
