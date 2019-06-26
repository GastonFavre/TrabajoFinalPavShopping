namespace ShoppingBuyAll.Formularios
{
    partial class frm_FiltrosProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FiltrosProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Nombre = new System.Windows.Forms.CheckBox();
            this.cb_Precio = new System.Windows.Forms.CheckBox();
            this.cb_Codigo = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txt_Nombre = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_PrecioHasta = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_PrecioDesde = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Codigo = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.btn_buscar);
            this.groupBoxFiltros.Controls.Add(this.label2);
            this.groupBoxFiltros.Controls.Add(this.label1);
            this.groupBoxFiltros.Controls.Add(this.txt_Nombre);
            this.groupBoxFiltros.Controls.Add(this.txt_PrecioHasta);
            this.groupBoxFiltros.Controls.Add(this.txt_PrecioDesde);
            this.groupBoxFiltros.Controls.Add(this.txt_Codigo);
            this.groupBoxFiltros.Controls.Add(this.cb_Nombre);
            this.groupBoxFiltros.Controls.Add(this.cb_Precio);
            this.groupBoxFiltros.Controls.Add(this.cb_Codigo);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 40);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(204, 265);
            this.groupBoxFiltros.TabIndex = 75;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "FILTROS";
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buscar.Location = new System.Drawing.Point(43, 225);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(123, 34);
            this.btn_buscar.TabIndex = 146;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Desde";
            // 
            // cb_Nombre
            // 
            this.cb_Nombre.AutoSize = true;
            this.cb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nombre.Location = new System.Drawing.Point(6, 175);
            this.cb_Nombre.Name = "cb_Nombre";
            this.cb_Nombre.Size = new System.Drawing.Size(77, 19);
            this.cb_Nombre.TabIndex = 77;
            this.cb_Nombre.Text = "Nombre";
            this.cb_Nombre.UseVisualStyleBackColor = true;
            this.cb_Nombre.CheckedChanged += new System.EventHandler(this.cb_Nombre_CheckedChanged);
            // 
            // cb_Precio
            // 
            this.cb_Precio.AutoSize = true;
            this.cb_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Precio.Location = new System.Drawing.Point(6, 101);
            this.cb_Precio.Name = "cb_Precio";
            this.cb_Precio.Size = new System.Drawing.Size(67, 19);
            this.cb_Precio.TabIndex = 76;
            this.cb_Precio.Text = "Precio";
            this.cb_Precio.UseVisualStyleBackColor = true;
            this.cb_Precio.CheckedChanged += new System.EventHandler(this.cb_Precio_CheckedChanged);
            // 
            // cb_Codigo
            // 
            this.cb_Codigo.AutoSize = true;
            this.cb_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Codigo.Location = new System.Drawing.Point(6, 43);
            this.cb_Codigo.Name = "cb_Codigo";
            this.cb_Codigo.Size = new System.Drawing.Size(71, 19);
            this.cb_Codigo.TabIndex = 75;
            this.cb_Codigo.Text = "Codigo";
            this.cb_Codigo.UseVisualStyleBackColor = true;
            this.cb_Codigo.CheckedChanged += new System.EventHandler(this.cb_Codigo_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(222, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 316);
            this.dataGridView1.TabIndex = 76;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(658, 367);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(129, 29);
            this.btn_Salir.TabIndex = 149;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Location = new System.Drawing.Point(222, 367);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(129, 29);
            this.btn_Limpiar.TabIndex = 150;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre._campo = "nombre";
            this.txt_Nombre._mensaje_error = null;
            this.txt_Nombre._nombre_tabla = null;
            this.txt_Nombre._pk = false;
            this.txt_Nombre._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nombre._validable = false;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(83, 174);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(108, 20);
            this.txt_Nombre.TabIndex = 81;
            // 
            // txt_PrecioHasta
            // 
            this.txt_PrecioHasta._campo = "precio";
            this.txt_PrecioHasta._mensaje_error = null;
            this.txt_PrecioHasta._nombre_tabla = null;
            this.txt_PrecioHasta._pk = false;
            this.txt_PrecioHasta._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_PrecioHasta._validable = false;
            this.txt_PrecioHasta.Enabled = false;
            this.txt_PrecioHasta.Location = new System.Drawing.Point(116, 126);
            this.txt_PrecioHasta.Name = "txt_PrecioHasta";
            this.txt_PrecioHasta.Size = new System.Drawing.Size(75, 20);
            this.txt_PrecioHasta.TabIndex = 80;
            this.txt_PrecioHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioHasta_KeyPress);
            // 
            // txt_PrecioDesde
            // 
            this.txt_PrecioDesde._campo = "precio";
            this.txt_PrecioDesde._mensaje_error = null;
            this.txt_PrecioDesde._nombre_tabla = null;
            this.txt_PrecioDesde._pk = false;
            this.txt_PrecioDesde._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_PrecioDesde._validable = false;
            this.txt_PrecioDesde.Enabled = false;
            this.txt_PrecioDesde.Location = new System.Drawing.Point(116, 100);
            this.txt_PrecioDesde.Name = "txt_PrecioDesde";
            this.txt_PrecioDesde.Size = new System.Drawing.Size(75, 20);
            this.txt_PrecioDesde.TabIndex = 79;
            this.txt_PrecioDesde.TextChanged += new System.EventHandler(this.txt_PrecioDesde_TextChanged_1);
            this.txt_PrecioDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioDesde_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo._campo = "cod_prod";
            this.txt_Codigo._mensaje_error = null;
            this.txt_Codigo._nombre_tabla = null;
            this.txt_Codigo._pk = false;
            this.txt_Codigo._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Codigo._validable = false;
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(83, 43);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(108, 20);
            this.txt_Codigo.TabIndex = 78;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // frm_FiltrosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FiltrosProductos";
            this.Text = "frm_FiltrosProductos";
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Componentes.TextBoxDeControl txt_Nombre;
        private Componentes.TextBoxDeControl txt_PrecioHasta;
        private Componentes.TextBoxDeControl txt_PrecioDesde;
        private Componentes.TextBoxDeControl txt_Codigo;
        private System.Windows.Forms.CheckBox cb_Nombre;
        private System.Windows.Forms.CheckBox cb_Precio;
        private System.Windows.Forms.CheckBox cb_Codigo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}