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
            this.btn_nuevoFiltrado = new System.Windows.Forms.Button();
            this.checkFechaIngreso = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkPatente = new System.Windows.Forms.CheckBox();
            this.checkNroDNI = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GrillaFiltrados = new System.Windows.Forms.DataGridView();
            this.dt_fecha_entradaFiltrado = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_patenteFiltrado = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_NumDocFiltrado = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmb_tipoDocFiltrado = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPlayaFiltrado = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.checkPlaya = new System.Windows.Forms.CheckBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFiltrados)).BeginInit();
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
            this.btn_buscarFiltrado.Location = new System.Drawing.Point(451, 455);
            this.btn_buscarFiltrado.Name = "btn_buscarFiltrado";
            this.btn_buscarFiltrado.Size = new System.Drawing.Size(136, 30);
            this.btn_buscarFiltrado.TabIndex = 171;
            this.btn_buscarFiltrado.Text = "Buscar";
            this.btn_buscarFiltrado.UseVisualStyleBackColor = false;
            this.btn_buscarFiltrado.Click += new System.EventHandler(this.btn_buscarFiltrado_Click);
            // 
            // btn_nuevoFiltrado
            // 
            this.btn_nuevoFiltrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_nuevoFiltrado.FlatAppearance.BorderSize = 0;
            this.btn_nuevoFiltrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_nuevoFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_nuevoFiltrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nuevoFiltrado.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevoFiltrado.Image")));
            this.btn_nuevoFiltrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoFiltrado.Location = new System.Drawing.Point(593, 455);
            this.btn_nuevoFiltrado.Name = "btn_nuevoFiltrado";
            this.btn_nuevoFiltrado.Size = new System.Drawing.Size(136, 30);
            this.btn_nuevoFiltrado.TabIndex = 172;
            this.btn_nuevoFiltrado.Text = "Nuevo";
            this.btn_nuevoFiltrado.UseVisualStyleBackColor = false;
            this.btn_nuevoFiltrado.Click += new System.EventHandler(this.btn_nuevoFiltrado_Click);
            // 
            // checkFechaIngreso
            // 
            this.checkFechaIngreso.AutoSize = true;
            this.checkFechaIngreso.Location = new System.Drawing.Point(115, 195);
            this.checkFechaIngreso.Name = "checkFechaIngreso";
            this.checkFechaIngreso.Size = new System.Drawing.Size(15, 14);
            this.checkFechaIngreso.TabIndex = 258;
            this.checkFechaIngreso.UseVisualStyleBackColor = true;
            this.checkFechaIngreso.CheckedChanged += new System.EventHandler(this.checkFechaIngreso_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(136, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 254;
            this.label2.Text = "Fecha de ingreso";
            // 
            // checkPatente
            // 
            this.checkPatente.AutoSize = true;
            this.checkPatente.Location = new System.Drawing.Point(115, 94);
            this.checkPatente.Name = "checkPatente";
            this.checkPatente.Size = new System.Drawing.Size(15, 14);
            this.checkPatente.TabIndex = 245;
            this.checkPatente.UseVisualStyleBackColor = true;
            this.checkPatente.CheckedChanged += new System.EventHandler(this.checkPatente_CheckedChanged);
            // 
            // checkNroDNI
            // 
            this.checkNroDNI.AutoSize = true;
            this.checkNroDNI.Location = new System.Drawing.Point(115, 126);
            this.checkNroDNI.Name = "checkNroDNI";
            this.checkNroDNI.Size = new System.Drawing.Size(15, 14);
            this.checkNroDNI.TabIndex = 242;
            this.checkNroDNI.UseVisualStyleBackColor = true;
            this.checkNroDNI.CheckedChanged += new System.EventHandler(this.checkNroDNI_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(136, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 16);
            this.label20.TabIndex = 240;
            this.label20.Text = "Nro Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(136, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 239;
            this.label6.Text = "Patente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(136, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 236;
            this.label10.Text = "Tipo de documento";
            // 
            // GrillaFiltrados
            // 
            this.GrillaFiltrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaFiltrados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.GrillaFiltrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.GrillaFiltrados.Location = new System.Drawing.Point(451, 82);
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
            this.dt_fecha_entradaFiltrado.Location = new System.Drawing.Point(304, 184);
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
            this.txt_patenteFiltrado.Location = new System.Drawing.Point(304, 82);
            this.txt_patenteFiltrado.MaxLength = 20;
            this.txt_patenteFiltrado.Name = "txt_patenteFiltrado";
            this.txt_patenteFiltrado.Size = new System.Drawing.Size(122, 26);
            this.txt_patenteFiltrado.TabIndex = 235;
            // 
            // txt_NumDocFiltrado
            // 
            this.txt_NumDocFiltrado._campo = "num_doc";
            this.txt_NumDocFiltrado._mensaje_error = "";
            this.txt_NumDocFiltrado._nombre_tabla = "clientes";
            this.txt_NumDocFiltrado._pk = true;
            this.txt_NumDocFiltrado._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_NumDocFiltrado._validable = true;
            this.txt_NumDocFiltrado.Enabled = false;
            this.txt_NumDocFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumDocFiltrado.Location = new System.Drawing.Point(304, 152);
            this.txt_NumDocFiltrado.MaxLength = 8;
            this.txt_NumDocFiltrado.Name = "txt_NumDocFiltrado";
            this.txt_NumDocFiltrado.Size = new System.Drawing.Size(123, 26);
            this.txt_NumDocFiltrado.TabIndex = 232;
            // 
            // cmb_tipoDocFiltrado
            // 
            this.cmb_tipoDocFiltrado._campo = "tipo_doc1";
            this.cmb_tipoDocFiltrado._mensaje_error = "";
            this.cmb_tipoDocFiltrado._nombre_tabla = "clientes";
            this.cmb_tipoDocFiltrado._pk = true;
            this.cmb_tipoDocFiltrado._validable = true;
            this.cmb_tipoDocFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoDocFiltrado.Enabled = false;
            this.cmb_tipoDocFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoDocFiltrado.FormattingEnabled = true;
            this.cmb_tipoDocFiltrado.Location = new System.Drawing.Point(304, 118);
            this.cmb_tipoDocFiltrado.Name = "cmb_tipoDocFiltrado";
            this.cmb_tipoDocFiltrado.Size = new System.Drawing.Size(122, 28);
            this.cmb_tipoDocFiltrado.TabIndex = 231;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(136, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 247;
            this.label4.Text = "Playa";
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
            this.cmbPlayaFiltrado.Location = new System.Drawing.Point(304, 216);
            this.cmbPlayaFiltrado.Name = "cmbPlayaFiltrado";
            this.cmbPlayaFiltrado.Size = new System.Drawing.Size(123, 28);
            this.cmbPlayaFiltrado.TabIndex = 246;
            // 
            // checkPlaya
            // 
            this.checkPlaya.AutoSize = true;
            this.checkPlaya.Location = new System.Drawing.Point(115, 225);
            this.checkPlaya.Name = "checkPlaya";
            this.checkPlaya.Size = new System.Drawing.Size(15, 14);
            this.checkPlaya.TabIndex = 248;
            this.checkPlaya.UseVisualStyleBackColor = true;
            this.checkPlaya.CheckedChanged += new System.EventHandler(this.checkPlaya_CheckedChanged);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(903, 456);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 29);
            this.btn_Salir.TabIndex = 262;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_EstacionamientoFiltrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1005, 536);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.GrillaFiltrados);
            this.Controls.Add(this.checkFechaIngreso);
            this.Controls.Add(this.dt_fecha_entradaFiltrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkPlaya);
            this.Controls.Add(this.cmbPlayaFiltrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkPatente);
            this.Controls.Add(this.checkNroDNI);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_patenteFiltrado);
            this.Controls.Add(this.txt_NumDocFiltrado);
            this.Controls.Add(this.cmb_tipoDocFiltrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_nuevoFiltrado);
            this.Controls.Add(this.btn_buscarFiltrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EstacionamientoFiltrado";
            this.Text = "frm_EstacionamientoFiltrado";
            this.Load += new System.EventHandler(this.frm_EstacionamientoFiltrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFiltrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscarFiltrado;
        private System.Windows.Forms.Button btn_nuevoFiltrado;
        private System.Windows.Forms.CheckBox checkFechaIngreso;
        private Componentes.MaskedTextBokDeControl dt_fecha_entradaFiltrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkPatente;
        private System.Windows.Forms.CheckBox checkNroDNI;
        private System.Windows.Forms.Label label20;
        private Componentes.TextBoxDeControl txt_patenteFiltrado;
        private Componentes.TextBoxDeControl txt_NumDocFiltrado;
        private Componentes.ComboBoxDeControl cmb_tipoDocFiltrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GrillaFiltrados;
        private System.Windows.Forms.Label label4;
        private Componentes.ComboBoxDeControl cmbPlayaFiltrado;
        private System.Windows.Forms.CheckBox checkPlaya;
        private System.Windows.Forms.Button btn_Salir;
    }
}