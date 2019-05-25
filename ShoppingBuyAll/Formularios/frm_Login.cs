using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShoppingBuyAll.clases;

namespace ShoppingBuyAll
{
    public partial class Login : Form
    {
        int _id = 0;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Usuario
        {
            get { return this.txt_usuario.Text; }
            set { this.txt_usuario.Text = value; }
        }

        public string Password
        {
            get { return this.txt_pass.Text; }
            set { this.txt_pass.Text = value; }
        }



        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_rest.Visible = true;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_rest.Visible = false;
            btn_max.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if ((this.txt_usuario.Text =="") || (this.txt_usuario.Text == "Usuario"))
            {
                MessageBox.Show("El usuario no ha sido cargado");
                txt_pass.Text = "";
                txt_usuario.Text = "";
                this.txt_usuario.Focus();
                return;
            }
            if ((this.txt_pass.Text == "") || (this.txt_pass.Text == "Contraseña"))
            {
                MessageBox.Show("El password no ha sido cargado");
                this.txt_pass.Focus();
                txt_pass.Text = "";
                txt_usuario.Text = "";
                return;
            }

            usuarios nuevo_ingreso = new usuarios();
            DataTable nueva_tabla = new DataTable();

            nueva_tabla = nuevo_ingreso.consulta_login(this.txt_usuario.Text.Trim(), this.txt_pass.Text.Trim());

            if (nueva_tabla.Rows.Count==1)
            {
                this._id = int.Parse(nueva_tabla.Rows[0][0].ToString());
                frm_Menu menu = new frm_Menu();
                this.Visible = false;
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha podido iniciar sesion, usuario o contraseña incorrecta");
                this.txt_pass.Focus();
                txt_pass.Text = "";
                txt_usuario.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Importante",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void txt_usuario_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.usuario;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txt_usuario.ForeColor = Color.FromArgb(78, 184, 206);


            pictureBox4.BackgroundImage = Properties.Resources.Seguridad;
            panel2.ForeColor = Color.WhiteSmoke;
            txt_pass.ForeColor = Color.WhiteSmoke;

        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            txt_pass.Clear();
            txt_pass.PasswordChar = '*';
            pictureBox4.BackgroundImage = Properties.Resources.Seguridad;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txt_pass.ForeColor = Color.FromArgb(78, 184, 206);


            pictureBox3.BackgroundImage = Properties.Resources.usuario;
            panel1.BackColor = Color.WhiteSmoke;
            txt_usuario.ForeColor = Color.WhiteSmoke;
        }

        private void btn_verContra_Click(object sender, EventArgs e)
        {
            
            
            if (txt_pass.PasswordChar == '*')
            {
                txt_pass.PasswordChar = '\0';
                return;
            }
            else
            {
                txt_pass.PasswordChar = '*';
                return;
            }

        }
    }
}
