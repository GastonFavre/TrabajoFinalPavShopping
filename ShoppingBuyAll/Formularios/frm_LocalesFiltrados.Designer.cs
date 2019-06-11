namespace ShoppingBuyAll.Formularios
{
    partial class frm_LocalesFiltrados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LocalesFiltrados));
            this.Barra_De_Titulo = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_rest = new System.Windows.Forms.PictureBox();
            this.txt_cuil = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_Nom = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipoCom = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datagrid_filtro = new System.Windows.Forms.DataGridView();
            this.Barra_De_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_filtro)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_De_Titulo
            // 
            this.Barra_De_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.Barra_De_Titulo.Controls.Add(this.btn_min);
            this.Barra_De_Titulo.Controls.Add(this.btn_max);
            this.Barra_De_Titulo.Controls.Add(this.btn_close);
            this.Barra_De_Titulo.Controls.Add(this.btn_rest);
            this.Barra_De_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_De_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_De_Titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Barra_De_Titulo.Name = "Barra_De_Titulo";
            this.Barra_De_Titulo.Size = new System.Drawing.Size(1420, 46);
            this.Barra_De_Titulo.TabIndex = 147;
            this.Barra_De_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_De_Titulo_MouseDown);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(1326, 5);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(24, 25);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_min.TabIndex = 5;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(1292, 5);
            this.btn_max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(24, 25);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_max.TabIndex = 8;
            this.btn_max.TabStop = false;
            this.btn_max.Visible = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1392, 5);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close.TabIndex = 7;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_rest
            // 
            this.btn_rest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rest.Image = ((System.Drawing.Image)(resources.GetObject("btn_rest.Image")));
            this.btn_rest.Location = new System.Drawing.Point(1358, 5);
            this.btn_rest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(24, 25);
            this.btn_rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_rest.TabIndex = 6;
            this.btn_rest.TabStop = false;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
            // 
            // txt_cuil
            // 
            this.txt_cuil._campo = "cuil";
            this.txt_cuil._mensaje_error = "";
            this.txt_cuil._nombre_tabla = "Locales";
            this.txt_cuil._pk = true;
            this.txt_cuil._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_cuil._validable = true;
            this.txt_cuil.Enabled = false;
            this.txt_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuil.Location = new System.Drawing.Point(276, 147);
            this.txt_cuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cuil.MaxLength = 8;
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(221, 35);
            this.txt_cuil.TabIndex = 148;
            this.txt_cuil.TextChanged += new System.EventHandler(this.txt_cuil_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(198, 153);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 29);
            this.label20.TabIndex = 149;
            this.label20.Text = "CUIL";
            // 
            // txt_Nom
            // 
            this.txt_Nom._campo = "nombre";
            this.txt_Nom._mensaje_error = "";
            this.txt_Nom._nombre_tabla = "Locales";
            this.txt_Nom._pk = false;
            this.txt_Nom._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nom._validable = true;
            this.txt_Nom.Enabled = false;
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.Location = new System.Drawing.Point(276, 217);
            this.txt_Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nom.MaxLength = 50;
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(221, 35);
            this.txt_Nom.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(91, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 151;
            this.label1.Text = "Nombre Local";
            // 
            // cmb_tipoCom
            // 
            this.cmb_tipoCom._campo = "tipo_Comercio1";
            this.cmb_tipoCom._mensaje_error = "";
            this.cmb_tipoCom._nombre_tabla = "Locales";
            this.cmb_tipoCom._pk = false;
            this.cmb_tipoCom._validable = true;
            this.cmb_tipoCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoCom.Enabled = false;
            this.cmb_tipoCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoCom.FormattingEnabled = true;
            this.cmb_tipoCom.Location = new System.Drawing.Point(276, 290);
            this.cmb_tipoCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_tipoCom.Name = "cmb_tipoCom";
            this.cmb_tipoCom.Size = new System.Drawing.Size(290, 37);
            this.cmb_tipoCom.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 153;
            this.label2.Text = "Tipo de Comercio";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(514, 153);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 154;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(514, 223);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 155;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(586, 301);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 156;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(352, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 157;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagrid_filtro
            // 
            this.datagrid_filtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_filtro.Location = new System.Drawing.Point(676, 103);
            this.datagrid_filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagrid_filtro.Name = "datagrid_filtro";
            this.datagrid_filtro.Size = new System.Drawing.Size(706, 379);
            this.datagrid_filtro.TabIndex = 158;
            // 
            // frm_LocalesFiltrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1420, 602);
            this.Controls.Add(this.datagrid_filtro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipoCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.Barra_De_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LocalesFiltrados";
            this.Text = "frm_LocalPorTipo";
            this.Load += new System.EventHandler(this.frm_LocalPorTipo_Load);
            this.Barra_De_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_filtro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Barra_De_Titulo;
        private System.Windows.Forms.PictureBox btn_min;
        private System.Windows.Forms.PictureBox btn_max;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_rest;
        private Componentes.TextBoxDeControl txt_cuil;
        private System.Windows.Forms.Label label20;
        private Componentes.TextBoxDeControl txt_Nom;
        private System.Windows.Forms.Label label1;
        private Componentes.ComboBoxDeControl cmb_tipoCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagrid_filtro;
    }
}