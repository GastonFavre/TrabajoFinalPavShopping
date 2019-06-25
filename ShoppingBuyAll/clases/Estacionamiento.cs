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

        //public DataTable buscar_estacionamiento_filtrado(Control.ControlCollection controles)
        //{
        //    return _BD.buscar_filtrado(controles, "EstacXCliente");
        //}

        public DataTable buscar_porPatente(string patente)
        {
            string sql = @"SELECT E.patente_1 AS 'Patente',E.nro_doc2 AS 'Numero Documento',E.fecha AS 'Fecha de Ingreso',E.hora_desde as 'Hora Ingreso',E.hora_hasta AS 'Hora Egreso',
                           P.nombre AS 'Playa',E.nro_estac AS 'Lugar numero'
                           FROM EstacXCliente E JOIN Playa P ON P.id_playa = E.id_playa1
                           WHERE E.patente_1 = '" +patente + "'";

            return _BD.consulta(sql);
        }

        public DataTable buscar_porDNI(string numeroDoc)
        {
            string sql = @"SELECT E.patente_1 AS 'Patente',E.nro_doc2 AS 'Numero Documento',T.descripcion AS 'Tipo Documento',E.fecha AS 'Fecha de Ingreso',E.hora_desde as 'Hora Ingreso',E.hora_hasta AS 'Hora Egreso',
                           P.nombre AS 'Playa',E.nro_estac AS 'Lugar numero'
                           FROM EstacXCliente E JOIN Playa P ON P.id_playa = E.id_playa1  JOIN Tipo_Documento T ON E.tipo_doc2 = T.id_doc
                           WHERE E.nro_doc2 =  '" + numeroDoc + "'";

            return _BD.consulta(sql);
        }

        public DataTable buscar_porFecha(string fecha)
        {
            string sql = @"SELECT E.patente_1 AS 'Patente',E.nro_doc2 AS 'Numero Documento',E.fecha AS 'Fecha de Ingreso',E.hora_desde as 'Hora Ingreso',E.hora_hasta AS 'Hora Egreso',
                           P.nombre AS 'Playa',E.nro_estac AS 'Lugar numero'
                           FROM EstacXCliente E JOIN Playa P ON P.id_playa = E.id_playa1 
                           WHERE E.fecha = '" + fecha + "'";

            return _BD.consulta(sql);

        }

        public DataTable buscar_porPlaya(string Playa)
        {
            string sql = @"SELECT E.patente_1 AS 'Patente',E.nro_doc2 AS 'Numero Documento',E.fecha AS 'Fecha de Ingreso',E.hora_desde as 'Hora Ingreso',E.hora_hasta AS 'Hora Egreso',
                           P.nombre AS 'Playa',E.nro_estac AS 'Lugar numero'
                           FROM EstacXCliente E JOIN Playa P ON P.id_playa = E.id_playa1 
                           WHERE E.id_playa1 =  '" + Playa + "'";

            return _BD.consulta(sql);

        }

        public DataTable buscar_EstacionamientoClientes()
        {
            string sql = @"SELECT CONCAT(C.apellido, ' ', C.nombres) as descriptor, count(*) as dato
                           FROM clientes C JOIN automoviles A ON A.tipo_doc2 = C.tipo_doc1 AND A.num_doc1 = C.num_doc
                           JOIN EstacXCliente E ON A.patente = E.patente_1
                           GROUP BY C.apellido, C.nombres, C.num_doc";
            return _BD.consulta(sql);
        }

        public DataTable buscar_EstacionamientoFiltadoAuto(string comando)
        {
            string sql = @"SELECT E.patente_1 AS 'Patente',E.nro_doc2 AS 'Numero Documento',E.fecha AS 'Fecha de Ingreso',E.hora_desde as 'Hora Ingreso',E.hora_hasta AS 'Hora Egreso',
                           P.nombre AS 'Playa',E.nro_estac AS 'Lugar numero'
                           FROM EstacXCliente E JOIN Playa P ON P.id_playa = E.id_playa1" + comando;
            MessageBox.Show(sql);
            return _BD.consulta(sql);
        }

        public DataTable descripcion_TIPODOC(string tipoDoc)
        {
            string sql = @"SELECT T.descripcion AS 'descripcion' FROM Tipo_Documento T WHERE T.id_doc = '" + tipoDoc + "';"; 

            return _BD.consulta(sql);
        }
    }
}
