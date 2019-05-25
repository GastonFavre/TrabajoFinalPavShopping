using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ShoppingBuyAll.clases
{
    class usuarios
    {
        AccesoBD _BD = new AccesoBD();
        string _n_usuario;
        string _password;
        string _email;
        

        public string n_usuario
        {
            get { return this._n_usuario; }
            set { this._n_usuario = value; }
        }
        public string password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }
       

        public DataTable buscar_por_id(string id)
        {
            return this._BD.consulta("SELECT * FROM Usuarios WHERE id_usu =" + id);
        }

        public DataTable consulta_login(string usuario, string contraseña)
        {
            string sqltext = @"SELECT * FROM Usuarios
                               WHERE nombre = '"+usuario+"'"
                               + "AND contraseña = '"+contraseña+"'";
            return _BD.consulta(sqltext);
        }

        public Boolean validar_usuario()
        {
            if(this._n_usuario=="")
            {
                MessageBox.Show("El usuario no ha sido cargado vuelva a intenarlo");
            }
            return true;
        }

    }
}
