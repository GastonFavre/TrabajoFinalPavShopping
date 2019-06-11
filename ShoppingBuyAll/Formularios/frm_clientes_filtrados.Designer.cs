namespace ShoppingBuyAll.Formularios
{
    partial class frm_clientes_filtrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_clientes_filtrados));
            this.Barra_De_Titulo = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_rest = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCalle = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Nom = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Ape = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_NumDoc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmbSexo = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.cmbEstadoCivil = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.cmbBarrio = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.cmb_tipoDoc = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.Barra_De_Titulo.Name = "Barra_De_Titulo";
            this.Barra_De_Titulo.Size = new System.Drawing.Size(1032, 30);
            this.Barra_De_Titulo.TabIndex = 146;
            this.Barra_De_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_De_Titulo_Paint);
            this.Barra_De_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_De_Titulo_MouseDown);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(969, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(16, 16);
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
            this.btn_max.Location = new System.Drawing.Point(947, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(16, 16);
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
            this.btn_close.Location = new System.Drawing.Point(1013, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
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
            this.btn_rest.Location = new System.Drawing.Point(991, 3);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(16, 16);
            this.btn_rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_rest.TabIndex = 6;
            this.btn_rest.TabStop = false;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
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
            this.button1.Location = new System.Drawing.Point(210, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 145;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(339, 323);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 144;
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(339, 289);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 143;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(339, 254);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 142;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(339, 218);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 141;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(339, 186);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 140;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(339, 154);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 139;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(339, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 138;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(339, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 137;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(68, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 20);
            this.label20.TabIndex = 136;
            this.label20.Text = "Nro Documento";
            // 
            // txtCalle
            // 
            this.txtCalle._campo = "calle";
            this.txtCalle._mensaje_error = "";
            this.txtCalle._nombre_tabla = "clientes";
            this.txtCalle._pk = false;
            this.txtCalle._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txtCalle._validable = true;
            this.txtCalle.Enabled = false;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(210, 213);
            this.txtCalle.MaxLength = 20;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(123, 26);
            this.txtCalle.TabIndex = 125;
            // 
            // txt_Nom
            // 
            this.txt_Nom._campo = "nombres";
            this.txt_Nom._mensaje_error = "";
            this.txt_Nom._nombre_tabla = "clientes";
            this.txt_Nom._pk = false;
            this.txt_Nom._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nom._validable = true;
            this.txt_Nom.Enabled = false;
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.Location = new System.Drawing.Point(210, 181);
            this.txt_Nom.MaxLength = 50;
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(123, 26);
            this.txt_Nom.TabIndex = 124;
            // 
            // txt_Ape
            // 
            this.txt_Ape._campo = "apellido";
            this.txt_Ape._mensaje_error = "";
            this.txt_Ape._nombre_tabla = "clientes";
            this.txt_Ape._pk = false;
            this.txt_Ape._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Ape._validable = true;
            this.txt_Ape.Enabled = false;
            this.txt_Ape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ape.Location = new System.Drawing.Point(210, 149);
            this.txt_Ape.MaxLength = 30;
            this.txt_Ape.Name = "txt_Ape";
            this.txt_Ape.Size = new System.Drawing.Size(123, 26);
            this.txt_Ape.TabIndex = 123;
            // 
            // txt_NumDoc
            // 
            this.txt_NumDoc._campo = "num_doc";
            this.txt_NumDoc._mensaje_error = "";
            this.txt_NumDoc._nombre_tabla = "clientes";
            this.txt_NumDoc._pk = true;
            this.txt_NumDoc._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_NumDoc._validable = true;
            this.txt_NumDoc.Enabled = false;
            this.txt_NumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumDoc.Location = new System.Drawing.Point(210, 117);
            this.txt_NumDoc.MaxLength = 8;
            this.txt_NumDoc.Name = "txt_NumDoc";
            this.txt_NumDoc.Size = new System.Drawing.Size(123, 26);
            this.txt_NumDoc.TabIndex = 122;
            // 
            // cmbSexo
            // 
            this.cmbSexo._campo = "sexo1";
            this.cmbSexo._mensaje_error = "";
            this.cmbSexo._nombre_tabla = "clientes";
            this.cmbSexo._pk = false;
            this.cmbSexo._validable = true;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Enabled = false;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(210, 316);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(123, 28);
            this.cmbSexo.TabIndex = 128;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil._campo = "estado_civil1";
            this.cmbEstadoCivil._mensaje_error = "";
            this.cmbEstadoCivil._nombre_tabla = "clientes";
            this.cmbEstadoCivil._pk = false;
            this.cmbEstadoCivil._validable = true;
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.Enabled = false;
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(210, 282);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(123, 28);
            this.cmbEstadoCivil.TabIndex = 127;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio._campo = "id_Barrio1";
            this.cmbBarrio._mensaje_error = "";
            this.cmbBarrio._nombre_tabla = "clientes";
            this.cmbBarrio._pk = false;
            this.cmbBarrio._validable = true;
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(210, 247);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(123, 28);
            this.cmbBarrio.TabIndex = 126;
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc._campo = "tipo_doc1";
            this.cmb_tipoDoc._mensaje_error = "";
            this.cmb_tipoDoc._nombre_tabla = "clientes";
            this.cmb_tipoDoc._pk = true;
            this.cmb_tipoDoc._validable = true;
            this.cmb_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoDoc.Enabled = false;
            this.cmb_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(210, 84);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(123, 28);
            this.cmb_tipoDoc.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(153, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 135;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(102, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 134;
            this.label3.Text = "Estado civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(145, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 133;
            this.label4.Text = "Barrio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(153, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 132;
            this.label6.Text = "Calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(133, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 131;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(129, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 130;
            this.label8.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(42, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 129;
            this.label10.Text = "Tipo de documento";
            // 
            // datagrid_filtro
            // 
            this.datagrid_filtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_filtro.Location = new System.Drawing.Point(418, 84);
            this.datagrid_filtro.Name = "datagrid_filtro";
            this.datagrid_filtro.Size = new System.Drawing.Size(545, 260);
            this.datagrid_filtro.TabIndex = 120;
            // 
            // frm_clientes_filtrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.Barra_De_Titulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Ape);
            this.Controls.Add(this.txt_NumDoc);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.cmb_tipoDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datagrid_filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_clientes_filtrados";
            this.Text = "frm_clientes_filtrados";
            this.Load += new System.EventHandler(this.frm_clientes_filtrados_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label20;
        private Componentes.TextBoxDeControl txtCalle;
        private Componentes.TextBoxDeControl txt_Nom;
        private Componentes.TextBoxDeControl txt_Ape;
        private Componentes.TextBoxDeControl txt_NumDoc;
        private Componentes.ComboBoxDeControl cmbSexo;
        private Componentes.ComboBoxDeControl cmbEstadoCivil;
        private Componentes.ComboBoxDeControl cmbBarrio;
        private Componentes.ComboBoxDeControl cmb_tipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datagrid_filtro;
    }
}