using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using ShoppingBuyAll.clases;
using ShoppingBuyAll.Componentes;

namespace ShoppingBuyAll.clases
{
    class AccesoBD
    {
        public enum resultado_acceso { error, correcto }
        public enum tipo_conexion { simple, transaccion }
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        resultado_acceso control_transaccion = resultado_acceso.correcto;
        tipo_conexion _tipo_trans = tipo_conexion.simple;
        OleDbTransaction transaccion;


        //Cadena del Dueño del pabellon: Provider=SQLNCLI11;Data Source=DESKTOP-81G4FGU\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Shopping_Buy_All
        //la cadena de tu hermana Provider=SQLNCLI11;Data Source=DESKTOP-IE9SHP6\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Shopping_Buy_All
        //Cadena conexion Diego Provider=SQLNCLI11;Data Source=LAPTOP-N1RR57MI;Integrated Security=SSPI;Initial Catalog=Shopping_Buy_All
        //cadena conexion Juancito Cuello Provider=SQLNCLI11;Data Source=DESKTOP-Q1570T7;Integrated Security=SSPI;Initial Catalog=Shopping_Buy_All

        string cadena_conexion = "Provider=SQLNCLI11;Data Source=DESKTOP-IE9SHP6\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Shopping_Buy_All";

        public void iniciar_transaccion()
        {
            _tipo_trans = tipo_conexion.transaccion;
            control_transaccion = resultado_acceso.correcto;
        }

        public void cerrar_transaccion()
        {
            if (_tipo_trans == tipo_conexion.simple)
                return;
            if (control_transaccion == resultado_acceso.correcto)
            {
                transaccion.Commit();
            }
            else
            {
                transaccion.Rollback();
            }
            _tipo_trans = tipo_conexion.simple;
            cerrar();

        }

        private void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                if (_tipo_trans == tipo_conexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadUncommitted);
                    cmd.Transaction = transaccion;
                }
            }
        }

        private void cerrar()
        {
            if (_tipo_trans == tipo_conexion.simple)
            {
                conexion.Close();
            }
           
        }

        public resultado_acceso insert_update_delete(string comando)
        {
            conectar();
            cmd.CommandText = comando;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la base de datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return resultado_acceso.error;
                throw;
            }
            cerrar();
            return resultado_acceso.correcto;
        }

        public DataTable consulta(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();

            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch(Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la base de datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return tabla;
                throw;
            }
            cerrar();
            return tabla;
        }

        public void grabar_modificar(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            cmd.ExecuteNonQuery();
            cerrar();
        }

        public bool auto_insert(Control.ControlCollection controles, string nombre_tabla)
        {
            string columnas = "";
            string valores = "";
            string sqlinsert = "";

            foreach (Control item in controles)
            {
                switch (item.GetType().Name)
                {
                    case "TextBoxDeControl":

                        if (((TextBoxDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((TextBoxDeControl)item)._campo != "")
                            {
                                if (columnas == "")
                                {
                                    MessageBox.Show(((TextBoxDeControl)item)._campo);
                                    columnas = columnas + ((TextBoxDeControl)item)._campo;
                                    valores = valores + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo); ;
                                }
                                else
                                {
                                    columnas = columnas + "," + ((TextBoxDeControl)item)._campo;
                                    valores = valores + "," + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo); ;
                                }

                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "ComboBoxDeControl":
                        if (((ComboBoxDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((ComboBoxDeControl)item)._campo != "")
                            {

                                if (columnas == "")
                                {
                                    columnas = columnas + ((ComboBoxDeControl)item)._campo;
                                    valores = valores + ((ComboBoxDeControl)item).SelectedValue.ToString(); ;
                                }
                                else
                                {
                                    columnas = columnas + "," + ((ComboBoxDeControl)item)._campo;
                                    valores = valores + "," + ((ComboBoxDeControl)item).SelectedValue.ToString(); ;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "DateTimePickerDeControl":
                        if (((DateTimePickerDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((DateTimePickerDeControl)item)._campo != "")
                            {
                                if (columnas == "")
                                {
                                    columnas = columnas + ((DateTimePickerDeControl)item)._campo;
                                    valores = valores + "'" + ((DateTimePickerDeControl)item).Value.ToShortDateString() + "'";
                                }
                                else
                                {
                                    columnas = columnas + "," + ((DateTimePickerDeControl)item)._campo;
                                    valores = valores + ", '" + ((DateTimePickerDeControl)item).Value.ToShortDateString() + "'";
                                }
                            }
                        }

                        else
                        {
                            continue;
                        }
                        break;
                    case "MaskedTextBokDeControl":
                        if (((MaskedTextBokDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((MaskedTextBokDeControl)item)._campo != "")
                            {
                                if (columnas == "")
                                {
                                    columnas = columnas + ((MaskedTextBokDeControl)item)._campo;
                                    valores = valores + "'" + ((MaskedTextBokDeControl)item).Text + "'";
                                }
                                else
                                {
                                    columnas = columnas + "," + ((MaskedTextBokDeControl)item)._campo;
                                    valores = valores + ", '" + ((MaskedTextBokDeControl)item).Text + "'";
                                }
                            }
                        }

                        else
                        {
                            continue;
                        }
                        break;
                    default:
                        break;
                }
            }

            sqlinsert = @"INSERT INTO " + nombre_tabla
                        + "(" + columnas + ") VALUES (" + valores + ")";
            MessageBox.Show(sqlinsert);
            if (this.insert_update_delete(sqlinsert) == resultado_acceso.error)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void auto_modificar(Control.ControlCollection controles, string nombre_tabla)
        {

            string sqlComand = "";
            string cuerpo = "";
            string condicion = "";
            foreach (Control item in controles)
            {
                switch (item.GetType().Name)
                {
                    case "TextBoxDeControl":

                        if (((TextBoxDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((TextBoxDeControl)item)._campo != "")
                            {
                                if (cuerpo == "")
                                {
                                    cuerpo = cuerpo + ((TextBoxDeControl)item)._campo + "= " + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo);
                                }
                                else
                                {
                                    cuerpo = cuerpo + " , " + ((TextBoxDeControl)item)._campo + "= " + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo);
                                }

                            }
                            if (((TextBoxDeControl)item)._pk == true)
                            {
                                if (condicion == "")
                                {
                                    condicion = condicion + ((TextBoxDeControl)item)._campo + "= " + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo);
                                }
                                else
                                {
                                    condicion = condicion + " AND " + ((TextBoxDeControl)item)._campo + "= " + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo);
                                }

                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "ComboBoxDeControl":
                        if (((ComboBoxDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((ComboBoxDeControl)item)._campo != "")
                            {

                                if (cuerpo == "")
                                {
                                    cuerpo = cuerpo + ((ComboBoxDeControl)item)._campo + "= " + ((ComboBoxDeControl)item).SelectedValue.ToString();
                                }
                                else
                                {
                                    cuerpo = cuerpo + " , " + ((ComboBoxDeControl)item)._campo + "= " + ((ComboBoxDeControl)item).SelectedValue.ToString();
                                }
                            }
                            if (((ComboBoxDeControl)item)._pk == true)
                            {
                                if (condicion == "")
                                {
                                    condicion = condicion + ((ComboBoxDeControl)item)._campo + "= " + ((ComboBoxDeControl)item).SelectedValue.ToString();
                                }
                                else
                                {
                                    condicion = condicion + " AND " + ((ComboBoxDeControl)item)._campo + "= " + ((ComboBoxDeControl)item).SelectedValue.ToString();
                                }

                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "DateTimePickerDeControl":
                        if (((DateTimePickerDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((DateTimePickerDeControl)item)._campo != "")
                            {
                                if (cuerpo == "")
                                {
                                    cuerpo = cuerpo + ((DateTimePickerDeControl)item)._campo + "= '" + ((DateTimePickerDeControl)item).Value.ToShortDateString() + "'";
                                }
                                else
                                {
                                    cuerpo = cuerpo + " , " + ((DateTimePickerDeControl)item)._campo + "= '" + ((DateTimePickerDeControl)item).Value.ToShortDateString() + "'";
                                }
                            }
                            if (((DateTimePickerDeControl)item)._pk == true)
                            {
                                if (condicion == "")
                                {
                                    condicion = condicion + ((DateTimePickerDeControl)item)._campo + "= '" + ((DateTimePickerDeControl)item).Value.ToShortDateString() + "'";
                                }
                                else
                                {
                                    condicion = condicion + " AND " + ((DateTimePickerDeControl)item)._campo + "= '" + ((DateTimePickerDeControl)item).Value.ToShortDateString() + "'";
                                }

                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "MaskedTextBokDeControl":
                        if (((MaskedTextBokDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((MaskedTextBokDeControl)item)._campo != "")
                            {
                                if (cuerpo == "")
                                {
                                    cuerpo = cuerpo + ((MaskedTextBokDeControl)item)._campo + "= '" + ((MaskedTextBokDeControl)item).Text + "'";
                                }
                                else
                                {
                                    cuerpo = cuerpo + " , " + ((MaskedTextBokDeControl)item)._campo + "= '" + ((MaskedTextBokDeControl)item).Text + "'";
                                }
                            }
                            if (((MaskedTextBokDeControl)item)._pk == true)
                            {
                                if (condicion == "")
                                {
                                    condicion = condicion + ((MaskedTextBokDeControl)item)._campo + "= '" + ((MaskedTextBokDeControl)item).Text + "'";
                                }
                                else
                                {
                                    condicion = condicion + " AND " + ((MaskedTextBokDeControl)item)._campo + "= '" + ((MaskedTextBokDeControl)item).Text + "'";
                                }

                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    default:
                        break;
                }
            }

            sqlComand = @"UPDATE " + nombre_tabla + " SET " + cuerpo + " WHERE " + condicion;
            MessageBox.Show(sqlComand);

            this.insert_update_delete(sqlComand);
        }

        public DataTable buscar_filtrado(Control.ControlCollection controles, string nombre_tabla)
        {
            string columnasComp = "";

            foreach (Control item in controles)
            {
                switch (item.GetType().Name)
                {
                    case "TextBoxDeControl":

                        if (((TextBoxDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((TextBoxDeControl)item)._campo != "")
                            {
                                if (((TextBoxDeControl)item).Text != "")
                                {
                                    if (columnasComp == "")
                                    {
                                        columnasComp = columnasComp + ((TextBoxDeControl)item)._campo + "= " + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo); ;

                                    }
                                    else
                                    {
                                        columnasComp = columnasComp + " AND " + ((TextBoxDeControl)item)._campo + "= " + this.formatear_dato(((TextBoxDeControl)item).Text, ((TextBoxDeControl)item)._tipo); ;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "ComboBoxDeControl":
                        if (((ComboBoxDeControl)item)._nombre_tabla == nombre_tabla)
                        {
                            if (((ComboBoxDeControl)item)._campo != "")
                            {

                                if (((ComboBoxDeControl)item).SelectedIndex != -1)
                                {
                                    if (columnasComp == "")
                                    {
                                        columnasComp = columnasComp + ((ComboBoxDeControl)item)._campo + "= " + ((ComboBoxDeControl)item).SelectedValue.ToString(); ;
                                    }
                                    else
                                    {
                                        columnasComp = columnasComp + " AND " + ((ComboBoxDeControl)item)._campo + "= " + ((ComboBoxDeControl)item).SelectedValue.ToString(); ;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    default:
                        break;
                }
            }

            string sql_buscar = @"SELECT * FROM " + nombre_tabla + " WHERE " + columnasComp;
            return this.consulta(sql_buscar);

        }


        private string formatear_dato(string dato, TextBoxDeControl.Tipo_dato tipo)
        {
            switch (tipo)
            {
                case TextBoxDeControl.Tipo_dato.texto:
                    return "'" + dato.Trim() + "'";

                case TextBoxDeControl.Tipo_dato.numero:
                    return dato.Trim();

            }
            return dato.Trim();
        }

    }
}
