namespace ShoppingBuyAll
{
    partial class frm_Compras
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_bucarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_TipoDoc = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.txt_Apellido = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Nombre = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_NumeroDoc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_tipo_loc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nom_loc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.btn_busc_loc = new System.Windows.Forms.Button();
            this.txt_cuil = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grid_compra = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cod_seg = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmb_tarjeta = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.rbt_eft = new System.Windows.Forms.RadioButton();
            this.rbt_tar = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.grid_product = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Buscar_Prod = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Precio_Prod = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Nom_Prod = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Cod_Pod = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.num_factur = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.dtp_compra = new ShoppingBuyAll.Componentes.DateTimePickerDeControl(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_compra)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bucarCliente
            // 
            this.btn_bucarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bucarCliente.Location = new System.Drawing.Point(518, 76);
            this.btn_bucarCliente.Name = "btn_bucarCliente";
            this.btn_bucarCliente.Size = new System.Drawing.Size(75, 28);
            this.btn_bucarCliente.TabIndex = 1;
            this.btn_bucarCliente.Text = "Buscar";
            this.btn_bucarCliente.UseVisualStyleBackColor = true;
            this.btn_bucarCliente.Click += new System.EventHandler(this.btn_bucarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_TipoDoc);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_NumeroDoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_bucarCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc._campo = "tipo_doc1";
            this.cmb_TipoDoc._mensaje_error = "No selecciono tipo documento";
            this.cmb_TipoDoc._nombre_tabla = "ComprasXCliente";
            this.cmb_TipoDoc._pk = true;
            this.cmb_TipoDoc._validable = true;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(408, 44);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(185, 28);
            this.cmb_TipoDoc.TabIndex = 58;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido._campo = null;
            this.txt_Apellido._mensaje_error = null;
            this.txt_Apellido._nombre_tabla = null;
            this.txt_Apellido._pk = false;
            this.txt_Apellido._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Apellido._validable = false;
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(408, 78);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(101, 26);
            this.txt_Apellido.TabIndex = 57;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre._campo = null;
            this.txt_Nombre._mensaje_error = null;
            this.txt_Nombre._nombre_tabla = null;
            this.txt_Nombre._pk = false;
            this.txt_Nombre._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nombre._validable = false;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(83, 82);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(143, 26);
            this.txt_Nombre.TabIndex = 55;
            // 
            // txt_NumeroDoc
            // 
            this.txt_NumeroDoc._campo = "num_doc1";
            this.txt_NumeroDoc._mensaje_error = "Numero no ingresado";
            this.txt_NumeroDoc._nombre_tabla = "ComprasXCliente";
            this.txt_NumeroDoc._pk = true;
            this.txt_NumeroDoc._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_NumeroDoc._validable = true;
            this.txt_NumeroDoc.Location = new System.Drawing.Point(83, 48);
            this.txt_NumeroDoc.Name = "txt_NumeroDoc";
            this.txt_NumeroDoc.Size = new System.Drawing.Size(143, 26);
            this.txt_NumeroDoc.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(359, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(329, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Apellido";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_tipo_loc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_nom_loc);
            this.groupBox3.Controls.Add(this.btn_busc_loc);
            this.groupBox3.Controls.Add(this.txt_cuil);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(671, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 181);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local";
            // 
            // txt_tipo_loc
            // 
            this.txt_tipo_loc._campo = null;
            this.txt_tipo_loc._mensaje_error = null;
            this.txt_tipo_loc._nombre_tabla = null;
            this.txt_tipo_loc._pk = false;
            this.txt_tipo_loc._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_tipo_loc._validable = false;
            this.txt_tipo_loc.Enabled = false;
            this.txt_tipo_loc.Location = new System.Drawing.Point(93, 102);
            this.txt_tipo_loc.Name = "txt_tipo_loc";
            this.txt_tipo_loc.Size = new System.Drawing.Size(138, 26);
            this.txt_tipo_loc.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Tipo";
            // 
            // txt_nom_loc
            // 
            this.txt_nom_loc._campo = null;
            this.txt_nom_loc._mensaje_error = null;
            this.txt_nom_loc._nombre_tabla = null;
            this.txt_nom_loc._pk = false;
            this.txt_nom_loc._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_nom_loc._validable = false;
            this.txt_nom_loc.Enabled = false;
            this.txt_nom_loc.Location = new System.Drawing.Point(93, 70);
            this.txt_nom_loc.Name = "txt_nom_loc";
            this.txt_nom_loc.Size = new System.Drawing.Size(138, 26);
            this.txt_nom_loc.TabIndex = 62;
            // 
            // btn_busc_loc
            // 
            this.btn_busc_loc.Enabled = false;
            this.btn_busc_loc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_busc_loc.Location = new System.Drawing.Point(202, 37);
            this.btn_busc_loc.Name = "btn_busc_loc";
            this.btn_busc_loc.Size = new System.Drawing.Size(27, 26);
            this.btn_busc_loc.TabIndex = 49;
            this.btn_busc_loc.Text = "Buscar";
            this.btn_busc_loc.UseVisualStyleBackColor = true;
            this.btn_busc_loc.Click += new System.EventHandler(this.btn_busc_loc_Click);
            // 
            // txt_cuil
            // 
            this.txt_cuil._campo = "cuil_local1";
            this.txt_cuil._mensaje_error = null;
            this.txt_cuil._nombre_tabla = "ComprasXCliente";
            this.txt_cuil._pk = false;
            this.txt_cuil._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_cuil._validable = false;
            this.txt_cuil.Enabled = false;
            this.txt_cuil.Location = new System.Drawing.Point(93, 37);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(105, 26);
            this.txt_cuil.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cuil";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grid_compra);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(12, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(666, 179);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compra";
            // 
            // grid_compra
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_compra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_compra.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid_compra.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_compra.Location = new System.Drawing.Point(12, 22);
            this.grid_compra.Name = "grid_compra";
            this.grid_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_compra.Size = new System.Drawing.Size(644, 150);
            this.grid_compra.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Local";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio Total";
            this.Column6.Name = "Column6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txt_cod_seg);
            this.groupBox5.Controls.Add(this.cmb_tarjeta);
            this.groupBox5.Controls.Add(this.rbt_eft);
            this.groupBox5.Controls.Add(this.rbt_tar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(700, 464);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 179);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pago";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(133, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 61;
            this.label14.Text = "Cod. Seg.";
            // 
            // txt_cod_seg
            // 
            this.txt_cod_seg._campo = "cod_tarjeta1";
            this.txt_cod_seg._mensaje_error = null;
            this.txt_cod_seg._nombre_tabla = "ComprasXCliente";
            this.txt_cod_seg._pk = false;
            this.txt_cod_seg._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_cod_seg._validable = false;
            this.txt_cod_seg.Enabled = false;
            this.txt_cod_seg.Location = new System.Drawing.Point(227, 136);
            this.txt_cod_seg.MaxLength = 3;
            this.txt_cod_seg.Multiline = true;
            this.txt_cod_seg.Name = "txt_cod_seg";
            this.txt_cod_seg.Size = new System.Drawing.Size(48, 28);
            this.txt_cod_seg.TabIndex = 3;
            // 
            // cmb_tarjeta
            // 
            this.cmb_tarjeta._campo = "num_tarjeta1";
            this.cmb_tarjeta._mensaje_error = null;
            this.cmb_tarjeta._nombre_tabla = "ComprasXCliente";
            this.cmb_tarjeta._pk = false;
            this.cmb_tarjeta._validable = false;
            this.cmb_tarjeta.Enabled = false;
            this.cmb_tarjeta.FormattingEnabled = true;
            this.cmb_tarjeta.Location = new System.Drawing.Point(6, 136);
            this.cmb_tarjeta.Name = "cmb_tarjeta";
            this.cmb_tarjeta.Size = new System.Drawing.Size(121, 28);
            this.cmb_tarjeta.TabIndex = 2;
            this.cmb_tarjeta.SelectedIndexChanged += new System.EventHandler(this.cmb_tarjeta_SelectedIndexChanged);
            // 
            // rbt_eft
            // 
            this.rbt_eft.AutoSize = true;
            this.rbt_eft.Location = new System.Drawing.Point(16, 39);
            this.rbt_eft.Name = "rbt_eft";
            this.rbt_eft.Size = new System.Drawing.Size(92, 24);
            this.rbt_eft.TabIndex = 1;
            this.rbt_eft.TabStop = true;
            this.rbt_eft.Text = "Efectivo";
            this.rbt_eft.UseVisualStyleBackColor = true;
            this.rbt_eft.CheckedChanged += new System.EventHandler(this.rbt_eft_CheckedChanged);
            // 
            // rbt_tar
            // 
            this.rbt_tar.AutoSize = true;
            this.rbt_tar.Location = new System.Drawing.Point(16, 79);
            this.rbt_tar.Name = "rbt_tar";
            this.rbt_tar.Size = new System.Drawing.Size(83, 24);
            this.rbt_tar.TabIndex = 0;
            this.rbt_tar.TabStop = true;
            this.rbt_tar.Text = "Tarjeta";
            this.rbt_tar.UseVisualStyleBackColor = true;
            this.rbt_tar.CheckedChanged += new System.EventHandler(this.rbt_tar_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(484, 662);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total:  $";
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(575, 659);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(93, 26);
            this.txt_Total.TabIndex = 48;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_agregar.Location = new System.Drawing.Point(577, 394);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 28);
            this.btn_agregar.TabIndex = 48;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Enabled = false;
            this.btn_quitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_quitar.Location = new System.Drawing.Point(24, 657);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 28);
            this.btn_quitar.TabIndex = 49;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(700, 662);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 28);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_finalizar.Location = new System.Drawing.Point(922, 662);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(75, 28);
            this.btn_finalizar.TabIndex = 53;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // grid_product
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_product.DefaultCellStyle = dataGridViewCellStyle16;
            this.grid_product.Location = new System.Drawing.Point(264, 216);
            this.grid_product.Name = "grid_product";
            this.grid_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_product.Size = new System.Drawing.Size(401, 172);
            this.grid_product.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio     $";
            // 
            // btn_Buscar_Prod
            // 
            this.btn_Buscar_Prod.Enabled = false;
            this.btn_Buscar_Prod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Buscar_Prod.Location = new System.Drawing.Point(96, 147);
            this.btn_Buscar_Prod.Name = "btn_Buscar_Prod";
            this.btn_Buscar_Prod.Size = new System.Drawing.Size(69, 28);
            this.btn_Buscar_Prod.TabIndex = 51;
            this.btn_Buscar_Prod.Text = "Buscar";
            this.btn_Buscar_Prod.UseVisualStyleBackColor = true;
            this.btn_Buscar_Prod.Click += new System.EventHandler(this.btn_Buscar_Prod_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Precio_Prod);
            this.groupBox2.Controls.Add(this.txt_Nom_Prod);
            this.groupBox2.Controls.Add(this.txt_Cod_Pod);
            this.groupBox2.Controls.Add(this.btn_Buscar_Prod);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 181);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // txt_Precio_Prod
            // 
            this.txt_Precio_Prod._campo = null;
            this.txt_Precio_Prod._mensaje_error = null;
            this.txt_Precio_Prod._nombre_tabla = null;
            this.txt_Precio_Prod._pk = false;
            this.txt_Precio_Prod._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Precio_Prod._validable = false;
            this.txt_Precio_Prod.Enabled = false;
            this.txt_Precio_Prod.Location = new System.Drawing.Point(96, 102);
            this.txt_Precio_Prod.Name = "txt_Precio_Prod";
            this.txt_Precio_Prod.Size = new System.Drawing.Size(69, 26);
            this.txt_Precio_Prod.TabIndex = 58;
            // 
            // txt_Nom_Prod
            // 
            this.txt_Nom_Prod._campo = null;
            this.txt_Nom_Prod._mensaje_error = null;
            this.txt_Nom_Prod._nombre_tabla = null;
            this.txt_Nom_Prod._pk = false;
            this.txt_Nom_Prod._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nom_Prod._validable = false;
            this.txt_Nom_Prod.Enabled = false;
            this.txt_Nom_Prod.Location = new System.Drawing.Point(96, 70);
            this.txt_Nom_Prod.Name = "txt_Nom_Prod";
            this.txt_Nom_Prod.Size = new System.Drawing.Size(127, 26);
            this.txt_Nom_Prod.TabIndex = 59;
            // 
            // txt_Cod_Pod
            // 
            this.txt_Cod_Pod._campo = null;
            this.txt_Cod_Pod._mensaje_error = null;
            this.txt_Cod_Pod._nombre_tabla = null;
            this.txt_Cod_Pod._pk = false;
            this.txt_Cod_Pod._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Cod_Pod._validable = false;
            this.txt_Cod_Pod.Enabled = false;
            this.txt_Cod_Pod.Location = new System.Drawing.Point(96, 37);
            this.txt_Cod_Pod.Name = "txt_Cod_Pod";
            this.txt_Cod_Pod.Size = new System.Drawing.Size(127, 26);
            this.txt_Cod_Pod.TabIndex = 60;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(264, 395);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 28);
            this.button9.TabIndex = 55;
            this.button9.Text = "Ver todo";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(463, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "N°Factura";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_cantidad.Location = new System.Drawing.Point(526, 395);
            this.txt_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(45, 26);
            this.txt_cantidad.TabIndex = 62;
            this.txt_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(434, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 61;
            this.label16.Text = "Cantidad:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // num_factur
            // 
            this.num_factur._campo = "nro_factura";
            this.num_factur._mensaje_error = "Numero no ingresado";
            this.num_factur._nombre_tabla = "ComprasXCliente";
            this.num_factur._pk = true;
            this.num_factur._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.num_factur._validable = true;
            this.num_factur.Enabled = false;
            this.num_factur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.num_factur.Location = new System.Drawing.Point(566, 9);
            this.num_factur.Name = "num_factur";
            this.num_factur.Size = new System.Drawing.Size(100, 26);
            this.num_factur.TabIndex = 59;
            // 
            // dtp_compra
            // 
            this.dtp_compra._campo = "fecha_compra";
            this.dtp_compra._nombre_tabla = "ComprasXCliente";
            this.dtp_compra._pk = false;
            this.dtp_compra._validable = false;
            this.dtp_compra.Enabled = false;
            this.dtp_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_compra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_compra.Location = new System.Drawing.Point(87, 8);
            this.dtp_compra.Name = "dtp_compra";
            this.dtp_compra.Size = new System.Drawing.Size(116, 26);
            this.dtp_compra.TabIndex = 56;
            // 
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.num_factur);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp_compra);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.grid_product);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Compras";
            this.Text = "frm_Compras";
            this.Load += new System.EventHandler(this.frm_Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_compra)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_bucarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grid_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbt_eft;
        private System.Windows.Forms.RadioButton rbt_tar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DataGridView grid_product;
        private Componentes.ComboBoxDeControl cmb_TipoDoc;
        private Componentes.TextBoxDeControl txt_Apellido;
        private Componentes.TextBoxDeControl txt_Nombre;
        private Componentes.TextBoxDeControl txt_NumeroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Buscar_Prod;
        private System.Windows.Forms.GroupBox groupBox2;
        private Componentes.TextBoxDeControl txt_Precio_Prod;
        private Componentes.TextBoxDeControl txt_Nom_Prod;
        private Componentes.TextBoxDeControl txt_Cod_Pod;
        private Componentes.TextBoxDeControl txt_tipo_loc;
        private System.Windows.Forms.Label label12;
        private Componentes.TextBoxDeControl txt_nom_loc;
        private System.Windows.Forms.Button btn_busc_loc;
        private Componentes.TextBoxDeControl txt_cuil;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Componentes.ComboBoxDeControl cmb_tarjeta;
        private Componentes.TextBoxDeControl txt_cod_seg;
        private Componentes.DateTimePickerDeControl dtp_compra;
        private System.Windows.Forms.Label label13;
        private Componentes.TextBoxDeControl num_factur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}