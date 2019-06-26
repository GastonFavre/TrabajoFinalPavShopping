namespace ShoppingBuyAll.Formularios
{
    partial class frm_EstacionamientoFiltrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EstacionamientoFiltrado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_buscarFiltrado = new System.Windows.Forms.Button();
            this.GrillaFiltrados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.checkPatente = new System.Windows.Forms.CheckBox();
            this.checkNroDNI = new System.Windows.Forms.CheckBox();
            this.checkPlaya = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkFechaIngreso = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEstacActual = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipoDocFiltrado = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.txt_NumDocFiltrado = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.dt_fecha_entradaFiltrado = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_patenteFiltrado = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmbPlayaFiltrado = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.btn_nuevoFiltrado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFiltrados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscarFiltrado
            // 
            this.btn_buscarFiltrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_buscarFiltrado.FlatAppearance.BorderSize = 0;
            this.btn_buscarFiltrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_buscarFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_buscarFiltrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscarFiltrado.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarFiltrado.Image")));
            this.btn_buscarFiltrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarFiltrado.Location = new System.Drawing.Point(108, 283);
            this.btn_buscarFiltrado.Name = "btn_buscarFiltrado";
            this.btn_buscarFiltrado.Size = new System.Drawing.Size(136, 30);
            this.btn_buscarFiltrado.TabIndex = 171;
            this.btn_buscarFiltrado.Text = "Buscar";
            this.btn_buscarFiltrado.UseVisualStyleBackColor = false;
            this.btn_buscarFiltrado.Click += new System.EventHandler(this.btn_buscarFiltrado_Click);
            // 
            // GrillaFiltrados
            // 
            this.GrillaFiltrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaFiltrados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.GrillaFiltrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrillaFiltrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaFiltrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaFiltrados.ColumnHeadersHeight = 30;
            this.GrillaFiltrados.EnableHeadersVisualStyles = false;
            this.GrillaFiltrados.GridColor = System.Drawing.Color.SteelBlue;
            this.GrillaFiltrados.Location = new System.Drawing.Point(423, 81);
            this.GrillaFiltrados.Name = "GrillaFiltrados";
            this.GrillaFiltrados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaFiltrados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaFiltrados.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.GrillaFiltrados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaFiltrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaFiltrados.Size = new System.Drawing.Size(542, 323);
            this.GrillaFiltrados.TabIndex = 261;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(54, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 247;
            this.label4.Text = "Playa";
            this.toolTip1.SetToolTip(this.label4, "Busqueda por nombre de la playa");
            // 
            // checkPatente
            // 
            this.checkPatente.AutoSize = true;
            this.checkPatente.Location = new System.Drawing.Point(33, 30);
            this.checkPatente.Name = "checkPatente";
            this.checkPatente.Size = new System.Drawing.Size(15, 14);
            this.checkPatente.TabIndex = 245;
            this.toolTip1.SetToolTip(this.checkPatente, "Realiza una busqueda por patente");
            this.checkPatente.UseVisualStyleBackColor = true;
            this.checkPatente.CheckedChanged += new System.EventHandler(this.checkPatente_CheckedChanged);
            // 
            // checkNroDNI
            // 
            this.checkNroDNI.AutoSize = true;
            this.checkNroDNI.Location = new System.Drawing.Point(33, 75);
            this.checkNroDNI.Name = "checkNroDNI";
            this.checkNroDNI.Size = new System.Drawing.Size(15, 14);
            this.checkNroDNI.TabIndex = 242;
            this.toolTip1.SetToolTip(this.checkNroDNI, "Busqueda por tipo y numero de documento");
            this.checkNroDNI.UseVisualStyleBackColor = true;
            this.checkNroDNI.CheckedChanged += new System.EventHandler(this.checkNroDNI_CheckedChanged);
            // 
            // checkPlaya
            // 
            this.checkPlaya.AutoSize = true;
            this.checkPlaya.Location = new System.Drawing.Point(33, 204);
            this.checkPlaya.Name = "checkPlaya";
            this.checkPlaya.Size = new System.Drawing.Size(15, 14);
            this.checkPlaya.TabIndex = 248;
            this.checkPlaya.UseVisualStyleBackColor = true;
            this.checkPlaya.CheckedChanged += new System.EventHandler(this.checkPlaya_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(54, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 16);
            this.label20.TabIndex = 240;
            this.label20.Text = "Nro Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 254;
            this.label2.Text = "Fecha de ingreso";
            this.toolTip1.SetToolTip(this.label2, "Busqueda por fecha de ingreso");
            // 
            // checkFechaIngreso
            // 
            this.checkFechaIngreso.AutoSize = true;
            this.checkFechaIngreso.Location = new System.Drawing.Point(33, 155);
            this.checkFechaIngreso.Name = "checkFechaIngreso";
            this.checkFechaIngreso.Size = new System.Drawing.Size(15, 14);
            this.checkFechaIngreso.TabIndex = 258;
            this.toolTip1.SetToolTip(this.checkFechaIngreso, "Busqueda por fecha de ingreso");
            this.checkFechaIngreso.UseVisualStyleBackColor = true;
            this.checkFechaIngreso.CheckedChanged += new System.EventHandler(this.checkFechaIngreso_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(54, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 16);
            this.label10.TabIndex = 236;
            this.label10.Text = "Tipo de documento";
            this.toolTip1.SetToolTip(this.label10, "Busqueda por tipo y numero de documento");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(54, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 239;
            this.label6.Text = "Patente";
            this.toolTip1.SetToolTip(this.label6, "Realiza una busqueda por patente");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEstacActual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_tipoDocFiltrado);
            this.groupBox1.Controls.Add(this.checkFechaIngreso);
            this.groupBox1.Controls.Add(this.txt_NumDocFiltrado);
            this.groupBox1.Controls.Add(this.btn_buscarFiltrado);
            this.groupBox1.Controls.Add(this.dt_fecha_entradaFiltrado);
            this.groupBox1.Controls.Add(this.txt_patenteFiltrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.checkPlaya);
            this.groupBox1.Controls.Add(this.checkNroDNI);
            this.groupBox1.Controls.Add(this.cmbPlayaFiltrado);
            this.groupBox1.Controls.Add(this.checkPatente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(59, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 329);
            this.groupBox1.TabIndex = 263;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por filtros";
            // 
            // checkEstacActual
            // 
            this.checkEstacActual.AutoSize = true;
            this.checkEstacActual.Location = new System.Drawing.Point(33, 248);
            this.checkEstacActual.Name = "checkEstacActual";
            this.checkEstacActual.Size = new System.Drawing.Size(15, 14);
            this.checkEstacActual.TabIndex = 260;
            this.toolTip1.SetToolTip(this.checkEstacActual, "Muestra todos los automoviles\r\nque estan en el estacionamiento\r\nen este momento");
            this.checkEstacActual.UseVisualStyleBackColor = true;
            this.checkEstacActual.CheckedChanged += new System.EventHandler(this.checkEstacActual_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 259;
            this.label1.Text = "Todos los estacionados actualmente";
            this.toolTip1.SetToolTip(this.label1, "Muestra todos los automoviles\r\nque estan en el estacionamiento\r\nen este momento");
            // 
            // cmb_tipoDocFiltrado
            // 
            this.cmb_tipoDocFiltrado._campo = "tipo_doc2";
            this.cmb_tipoDocFiltrado._mensaje_error = "";
            this.cmb_tipoDocFiltrado._nombre_tabla = "clientes";
            this.cmb_tipoDocFiltrado._pk = true;
            this.cmb_tipoDocFiltrado._validable = true;
            this.cmb_tipoDocFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoDocFiltrado.Enabled = false;
            this.cmb_tipoDocFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoDocFiltrado.FormattingEnabled = true;
            this.cmb_tipoDocFiltrado.Location = new System.Drawing.Point(196, 67);
            this.cmb_tipoDocFiltrado.Name = "cmb_tipoDocFiltrado";
            this.cmb_tipoDocFiltrado.Size = new System.Drawing.Size(122, 28);
            this.cmb_tipoDocFiltrado.TabIndex = 231;
            // 
            // txt_NumDocFiltrado
            // 
            this.txt_NumDocFiltrado._campo = "nro_doc2";
            this.txt_NumDocFiltrado._mensaje_error = "";
            this.txt_NumDocFiltrado._nombre_tabla = "clientes";
            this.txt_NumDocFiltrado._pk = true;
            this.txt_NumDocFiltrado._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_NumDocFiltrado._validable = true;
            this.txt_NumDocFiltrado.Enabled = false;
            this.txt_NumDocFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumDocFiltrado.Location = new System.Drawing.Point(196, 100);
            this.txt_NumDocFiltrado.MaxLength = 8;
            this.txt_NumDocFiltrado.Name = "txt_NumDocFiltrado";
            this.txt_NumDocFiltrado.Size = new System.Drawing.Size(123, 26);
            this.txt_NumDocFiltrado.TabIndex = 232;
            this.txt_NumDocFiltrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumDocFiltrado_KeyPress);
            // 
            // dt_fecha_entradaFiltrado
            // 
            this.dt_fecha_entradaFiltrado._campo = "fecha";
            this.dt_fecha_entradaFiltrado._mensaje_error = "Fecha de ingreso no ingresada";
            this.dt_fecha_entradaFiltrado._nombre_tabla = "EstacXCliente";
            this.dt_fecha_entradaFiltrado._pk = true;
            this.dt_fecha_entradaFiltrado._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.fecha;
            this.dt_fecha_entradaFiltrado._validable = true;
            this.dt_fecha_entradaFiltrado.Enabled = false;
            this.dt_fecha_entradaFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_entradaFiltrado.Location = new System.Drawing.Point(196, 147);
            this.dt_fecha_entradaFiltrado.Mask = "00/00/0000";
            this.dt_fecha_entradaFiltrado.Name = "dt_fecha_entradaFiltrado";
            this.dt_fecha_entradaFiltrado.Size = new System.Drawing.Size(88, 26);
            this.dt_fecha_entradaFiltrado.TabIndex = 253;
            this.dt_fecha_entradaFiltrado.ValidatingType = typeof(System.DateTime);
            // 
            // txt_patenteFiltrado
            // 
            this.txt_patenteFiltrado._campo = "patente_1";
            this.txt_patenteFiltrado._mensaje_error = "";
            this.txt_patenteFiltrado._nombre_tabla = "EstacXCliente";
            this.txt_patenteFiltrado._pk = true;
            this.txt_patenteFiltrado._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_patenteFiltrado._validable = true;
            this.txt_patenteFiltrado.Enabled = false;
            this.txt_patenteFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patenteFiltrado.Location = new System.Drawing.Point(196, 22);
            this.txt_patenteFiltrado.MaxLength = 20;
            this.txt_patenteFiltrado.Name = "txt_patenteFiltrado";
            this.txt_patenteFiltrado.Size = new System.Drawing.Size(122, 26);
            this.txt_patenteFiltrado.TabIndex = 235;
            // 
            // cmbPlayaFiltrado
            // 
            this.cmbPlayaFiltrado._campo = "id_playa1";
            this.cmbPlayaFiltrado._mensaje_error = "";
            this.cmbPlayaFiltrado._nombre_tabla = "EstacXCliente";
            this.cmbPlayaFiltrado._pk = false;
            this.cmbPlayaFiltrado._validable = true;
            this.cmbPlayaFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayaFiltrado.Enabled = false;
            this.cmbPlayaFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayaFiltrado.FormattingEnabled = true;
            this.cmbPlayaFiltrado.Location = new System.Drawing.Point(196, 196);
            this.cmbPlayaFiltrado.Name = "cmbPlayaFiltrado";
            this.cmbPlayaFiltrado.Size = new System.Drawing.Size(123, 28);
            this.cmbPlayaFiltrado.TabIndex = 246;
            // 
            // btn_nuevoFiltrado
            // 
            this.btn_nuevoFiltrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nuevoFiltrado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_nuevoFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_nuevoFiltrado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_nuevoFiltrado.Location = new System.Drawing.Point(423, 422);
            this.btn_nuevoFiltrado.Name = "btn_nuevoFiltrado";
            this.btn_nuevoFiltrado.Size = new System.Drawing.Size(90, 29);
            this.btn_nuevoFiltrado.TabIndex = 264;
            this.btn_nuevoFiltrado.Text = "Limpiar";
            this.btn_nuevoFiltrado.UseVisualStyleBackColor = true;
            this.btn_nuevoFiltrado.Click += new System.EventHandler(this.btn_nuevoFiltrado_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(875, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 265;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_EstacionamientoFiltrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1005, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nuevoFiltrado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrillaFiltrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EstacionamientoFiltrado";
            this.Text = "frm_EstacionamientoFiltrado";
            this.Load += new System.EventHandler(this.frm_EstacionamientoFiltrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFiltrados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_buscarFiltrado;
        private System.Windows.Forms.DataGridView GrillaFiltrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkPatente;
        private Componentes.ComboBoxDeControl cmbPlayaFiltrado;
        private System.Windows.Forms.CheckBox checkNroDNI;
        private System.Windows.Forms.CheckBox checkPlaya;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private Componentes.TextBoxDeControl txt_patenteFiltrado;
        private Componentes.MaskedTextBokDeControl dt_fecha_entradaFiltrado;
        private Componentes.TextBoxDeControl txt_NumDocFiltrado;
        private System.Windows.Forms.CheckBox checkFechaIngreso;
        private Componentes.ComboBoxDeControl cmb_tipoDocFiltrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_nuevoFiltrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEstacActual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}