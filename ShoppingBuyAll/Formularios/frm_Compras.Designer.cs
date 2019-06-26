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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_bucarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_busc_loc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grid_compra = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rbt_eft = new System.Windows.Forms.RadioButton();
            this.rbt_tar = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Buscar_Prod = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_Nombre = new System.Windows.Forms.RadioButton();
            this.rb_codigo = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.grid_product = new System.Windows.Forms.DataGridView();
            this.num_factur = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.dtp_compra = new ShoppingBuyAll.Componentes.DateTimePickerDeControl(this.components);
            this.cb_NombreTarjeta = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.cmb_NumTarjeta = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.txt_tipo_loc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_nom_loc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_cuil = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Precio_Prod = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Nom_Prod = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Cod_Pod = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmb_TipoDoc = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.txt_Apellido = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Nombre = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_NumeroDoc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_compra)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
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
            this.groupBox3.Size = new System.Drawing.Size(297, 181);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local";
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
            // btn_busc_loc
            // 
            this.btn_busc_loc.Enabled = false;
            this.btn_busc_loc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_busc_loc.Location = new System.Drawing.Point(202, 37);
            this.btn_busc_loc.Name = "btn_busc_loc";
            this.btn_busc_loc.Size = new System.Drawing.Size(86, 26);
            this.btn_busc_loc.TabIndex = 49;
            this.btn_busc_loc.Text = "Buscar";
            this.btn_busc_loc.UseVisualStyleBackColor = true;
            this.btn_busc_loc.Click += new System.EventHandler(this.btn_busc_loc_Click);
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
            this.groupBox4.Location = new System.Drawing.Point(12, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(653, 214);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compra";
            // 
            // grid_compra
            // 
            this.grid_compra.AllowUserToAddRows = false;
            this.grid_compra.AllowUserToDeleteRows = false;
            this.grid_compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_compra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.grid_compra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_compra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_compra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_compra.ColumnHeadersHeight = 40;
            this.grid_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.grid_compra.EnableHeadersVisualStyles = false;
            this.grid_compra.GridColor = System.Drawing.Color.SteelBlue;
            this.grid_compra.Location = new System.Drawing.Point(14, 28);
            this.grid_compra.Name = "grid_compra";
            this.grid_compra.ReadOnly = true;
            this.grid_compra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_compra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_compra.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grid_compra.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_compra.Size = new System.Drawing.Size(618, 177);
            this.grid_compra.TabIndex = 76;
            this.grid_compra.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grid_compra_RowStateChanged);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID Producto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nombre";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Precio";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Local";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Cantidad";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Precio Total";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
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
            this.groupBox5.Controls.Add(this.cb_NombreTarjeta);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cmb_NumTarjeta);
            this.groupBox5.Controls.Add(this.rbt_eft);
            this.groupBox5.Controls.Add(this.rbt_tar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(671, 429);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 214);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pago";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(6, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 62;
            this.label15.Text = "Nombre Tarjeta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(6, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 61;
            this.label14.Text = "Numero Tarjeta";
            // 
            // rbt_eft
            // 
            this.rbt_eft.AutoSize = true;
            this.rbt_eft.Enabled = false;
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
            this.rbt_tar.Enabled = false;
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
            this.label11.Location = new System.Drawing.Point(436, 659);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total:  $";
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(551, 656);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(93, 26);
            this.txt_Total.TabIndex = 48;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_agregar.Location = new System.Drawing.Point(590, 394);
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
            this.btn_cancelar.Location = new System.Drawing.Point(671, 654);
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
            this.btn_finalizar.Location = new System.Drawing.Point(893, 654);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(75, 28);
            this.btn_finalizar.TabIndex = 53;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
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
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio   $";
            // 
            // btn_Buscar_Prod
            // 
            this.btn_Buscar_Prod.Enabled = false;
            this.btn_Buscar_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Buscar_Prod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Buscar_Prod.Location = new System.Drawing.Point(90, 147);
            this.btn_Buscar_Prod.Name = "btn_Buscar_Prod";
            this.btn_Buscar_Prod.Size = new System.Drawing.Size(58, 28);
            this.btn_Buscar_Prod.TabIndex = 51;
            this.btn_Buscar_Prod.Text = "Buscar";
            this.btn_Buscar_Prod.UseVisualStyleBackColor = true;
            this.btn_Buscar_Prod.Click += new System.EventHandler(this.btn_Buscar_Prod_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rb_Nombre);
            this.groupBox2.Controls.Add(this.rb_codigo);
            this.groupBox2.Controls.Add(this.txt_Precio_Prod);
            this.groupBox2.Controls.Add(this.txt_Nom_Prod);
            this.groupBox2.Controls.Add(this.btn_Buscar_Prod);
            this.groupBox2.Controls.Add(this.txt_Cod_Pod);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(159, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 28);
            this.button1.TabIndex = 76;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_Nombre
            // 
            this.rb_Nombre.AutoSize = true;
            this.rb_Nombre.Location = new System.Drawing.Point(223, 77);
            this.rb_Nombre.Name = "rb_Nombre";
            this.rb_Nombre.Size = new System.Drawing.Size(14, 13);
            this.rb_Nombre.TabIndex = 62;
            this.rb_Nombre.TabStop = true;
            this.rb_Nombre.UseVisualStyleBackColor = true;
            this.rb_Nombre.CheckedChanged += new System.EventHandler(this.rb_Nombre_CheckedChanged);
            // 
            // rb_codigo
            // 
            this.rb_codigo.AutoSize = true;
            this.rb_codigo.Location = new System.Drawing.Point(223, 44);
            this.rb_codigo.Name = "rb_codigo";
            this.rb_codigo.Size = new System.Drawing.Size(14, 13);
            this.rb_codigo.TabIndex = 61;
            this.rb_codigo.TabStop = true;
            this.rb_codigo.UseVisualStyleBackColor = true;
            this.rb_codigo.CheckedChanged += new System.EventHandler(this.rb_codigo_CheckedChanged);
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
            // grid_product
            // 
            this.grid_product.AllowUserToAddRows = false;
            this.grid_product.AllowUserToDeleteRows = false;
            this.grid_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.grid_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_product.ColumnHeadersHeight = 30;
            this.grid_product.EnableHeadersVisualStyles = false;
            this.grid_product.GridColor = System.Drawing.Color.SteelBlue;
            this.grid_product.Location = new System.Drawing.Point(264, 216);
            this.grid_product.Name = "grid_product";
            this.grid_product.ReadOnly = true;
            this.grid_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_product.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_product.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.grid_product.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_product.Size = new System.Drawing.Size(401, 172);
            this.grid_product.TabIndex = 75;
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
            // cb_NombreTarjeta
            // 
            this.cb_NombreTarjeta._campo = "cod_tarjeta1";
            this.cb_NombreTarjeta._mensaje_error = null;
            this.cb_NombreTarjeta._nombre_tabla = "ComprasXCliente";
            this.cb_NombreTarjeta._pk = false;
            this.cb_NombreTarjeta._validable = false;
            this.cb_NombreTarjeta.Enabled = false;
            this.cb_NombreTarjeta.FormattingEnabled = true;
            this.cb_NombreTarjeta.Location = new System.Drawing.Point(144, 160);
            this.cb_NombreTarjeta.Name = "cb_NombreTarjeta";
            this.cb_NombreTarjeta.Size = new System.Drawing.Size(144, 28);
            this.cb_NombreTarjeta.TabIndex = 63;
            // 
            // cmb_NumTarjeta
            // 
            this.cmb_NumTarjeta._campo = "num_tarjeta1";
            this.cmb_NumTarjeta._mensaje_error = null;
            this.cmb_NumTarjeta._nombre_tabla = "ComprasXCliente";
            this.cmb_NumTarjeta._pk = false;
            this.cmb_NumTarjeta._validable = false;
            this.cmb_NumTarjeta.Enabled = false;
            this.cmb_NumTarjeta.FormattingEnabled = true;
            this.cmb_NumTarjeta.Location = new System.Drawing.Point(144, 126);
            this.cmb_NumTarjeta.Name = "cmb_NumTarjeta";
            this.cmb_NumTarjeta.Size = new System.Drawing.Size(144, 28);
            this.cmb_NumTarjeta.TabIndex = 2;
            this.cmb_NumTarjeta.SelectedIndexChanged += new System.EventHandler(this.cmb_tarjeta_SelectedIndexChanged);
            this.cmb_NumTarjeta.SelectedValueChanged += new System.EventHandler(this.cmb_NumTarjeta_SelectedValueChanged);
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
            this.txt_tipo_loc.Size = new System.Drawing.Size(195, 26);
            this.txt_tipo_loc.TabIndex = 61;
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
            this.txt_nom_loc.Size = new System.Drawing.Size(195, 26);
            this.txt_nom_loc.TabIndex = 62;
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
            // txt_Precio_Prod
            // 
            this.txt_Precio_Prod._campo = null;
            this.txt_Precio_Prod._mensaje_error = null;
            this.txt_Precio_Prod._nombre_tabla = null;
            this.txt_Precio_Prod._pk = false;
            this.txt_Precio_Prod._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Precio_Prod._validable = false;
            this.txt_Precio_Prod.Enabled = false;
            this.txt_Precio_Prod.Location = new System.Drawing.Point(90, 102);
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
            this.txt_Nom_Prod.Location = new System.Drawing.Point(90, 70);
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
            this.txt_Cod_Pod.Location = new System.Drawing.Point(90, 37);
            this.txt_Cod_Pod.Name = "txt_Cod_Pod";
            this.txt_Cod_Pod.Size = new System.Drawing.Size(127, 26);
            this.txt_Cod_Pod.TabIndex = 60;
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
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1035, 776);
            this.Controls.Add(this.grid_product);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.num_factur);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp_compra);
            this.Controls.Add(this.button9);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Compras_FormClosing);
            this.Load += new System.EventHandler(this.frm_Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_compra)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
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
        private Componentes.ComboBoxDeControl cmb_NumTarjeta;
        private Componentes.DateTimePickerDeControl dtp_compra;
        private System.Windows.Forms.Label label13;
        private Componentes.TextBoxDeControl num_factur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView grid_product;
        private System.Windows.Forms.DataGridView grid_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label label15;
        private Componentes.ComboBoxDeControl cb_NombreTarjeta;
        private System.Windows.Forms.RadioButton rb_Nombre;
        private System.Windows.Forms.RadioButton rb_codigo;
        private System.Windows.Forms.Button button1;
    }
}