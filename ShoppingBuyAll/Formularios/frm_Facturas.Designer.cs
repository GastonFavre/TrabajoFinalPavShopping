namespace ShoppingBuyAll.Formularios
{
    partial class frm_Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Facturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PrecioHasta = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.rb_MontoFactura = new System.Windows.Forms.CheckBox();
            this.rb_Fecha = new System.Windows.Forms.CheckBox();
            this.rb_Cliente = new System.Windows.Forms.CheckBox();
            this.rb_numFactura = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FechaDesde = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_PrecioDesde = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.txt_FechaHasta = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_NumFactura = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_Cliente = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PrecioHasta);
            this.groupBox1.Controls.Add(this.rb_MontoFactura);
            this.groupBox1.Controls.Add(this.rb_Fecha);
            this.groupBox1.Controls.Add(this.rb_Cliente);
            this.groupBox1.Controls.Add(this.rb_numFactura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_FechaDesde);
            this.groupBox1.Controls.Add(this.txt_PrecioDesde);
            this.groupBox1.Controls.Add(this.boton_Buscar);
            this.groupBox1.Controls.Add(this.txt_FechaHasta);
            this.groupBox1.Controls.Add(this.txt_NumFactura);
            this.groupBox1.Controls.Add(this.txt_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros De Busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Desde";
            // 
            // txt_PrecioHasta
            // 
            this.txt_PrecioHasta._campo = null;
            this.txt_PrecioHasta._mensaje_error = null;
            this.txt_PrecioHasta._nombre_tabla = null;
            this.txt_PrecioHasta._pk = false;
            this.txt_PrecioHasta._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_PrecioHasta._validable = false;
            this.txt_PrecioHasta.Enabled = false;
            this.txt_PrecioHasta.Location = new System.Drawing.Point(284, 87);
            this.txt_PrecioHasta.Name = "txt_PrecioHasta";
            this.txt_PrecioHasta.Size = new System.Drawing.Size(77, 20);
            this.txt_PrecioHasta.TabIndex = 85;
            this.txt_PrecioHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // rb_MontoFactura
            // 
            this.rb_MontoFactura.AutoSize = true;
            this.rb_MontoFactura.Location = new System.Drawing.Point(6, 87);
            this.rb_MontoFactura.Name = "rb_MontoFactura";
            this.rb_MontoFactura.Size = new System.Drawing.Size(56, 17);
            this.rb_MontoFactura.TabIndex = 84;
            this.rb_MontoFactura.Text = "Monto";
            this.rb_MontoFactura.UseVisualStyleBackColor = true;
            this.rb_MontoFactura.CheckedChanged += new System.EventHandler(this.rb_MontoFactura_CheckedChanged);
            // 
            // rb_Fecha
            // 
            this.rb_Fecha.AutoSize = true;
            this.rb_Fecha.Location = new System.Drawing.Point(6, 64);
            this.rb_Fecha.Name = "rb_Fecha";
            this.rb_Fecha.Size = new System.Drawing.Size(56, 17);
            this.rb_Fecha.TabIndex = 83;
            this.rb_Fecha.Text = "Fecha";
            this.rb_Fecha.UseVisualStyleBackColor = true;
            this.rb_Fecha.CheckedChanged += new System.EventHandler(this.rb_Fecha_CheckedChanged);
            // 
            // rb_Cliente
            // 
            this.rb_Cliente.AutoSize = true;
            this.rb_Cliente.Location = new System.Drawing.Point(6, 42);
            this.rb_Cliente.Name = "rb_Cliente";
            this.rb_Cliente.Size = new System.Drawing.Size(58, 17);
            this.rb_Cliente.TabIndex = 82;
            this.rb_Cliente.Text = "Cliente";
            this.rb_Cliente.UseVisualStyleBackColor = true;
            this.rb_Cliente.CheckedChanged += new System.EventHandler(this.rb_Cliente_CheckedChanged);
            // 
            // rb_numFactura
            // 
            this.rb_numFactura.AutoSize = true;
            this.rb_numFactura.Location = new System.Drawing.Point(6, 20);
            this.rb_numFactura.Name = "rb_numFactura";
            this.rb_numFactura.Size = new System.Drawing.Size(102, 17);
            this.rb_numFactura.TabIndex = 81;
            this.rb_numFactura.Text = "Numero Factura";
            this.rb_numFactura.UseVisualStyleBackColor = true;
            this.rb_numFactura.CheckedChanged += new System.EventHandler(this.rb_numFactura_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Desde";
            // 
            // txt_FechaDesde
            // 
            this.txt_FechaDesde._campo = "fecha_compra";
            this.txt_FechaDesde._mensaje_error = null;
            this.txt_FechaDesde._nombre_tabla = null;
            this.txt_FechaDesde._pk = false;
            this.txt_FechaDesde._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_FechaDesde._validable = false;
            this.txt_FechaDesde.Enabled = false;
            this.txt_FechaDesde.Location = new System.Drawing.Point(154, 64);
            this.txt_FechaDesde.Mask = "00/00/0000";
            this.txt_FechaDesde.Name = "txt_FechaDesde";
            this.txt_FechaDesde.Size = new System.Drawing.Size(77, 20);
            this.txt_FechaDesde.TabIndex = 78;
            this.txt_FechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_PrecioDesde
            // 
            this.txt_PrecioDesde._campo = null;
            this.txt_PrecioDesde._mensaje_error = null;
            this.txt_PrecioDesde._nombre_tabla = null;
            this.txt_PrecioDesde._pk = false;
            this.txt_PrecioDesde._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_PrecioDesde._validable = false;
            this.txt_PrecioDesde.Enabled = false;
            this.txt_PrecioDesde.Location = new System.Drawing.Point(154, 87);
            this.txt_PrecioDesde.Name = "txt_PrecioDesde";
            this.txt_PrecioDesde.Size = new System.Drawing.Size(77, 20);
            this.txt_PrecioDesde.TabIndex = 76;
            this.txt_PrecioDesde.TextChanged += new System.EventHandler(this.txt_PrecioDesde_TextChanged);
            this.txt_PrecioDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boton_Buscar.FlatAppearance.BorderSize = 0;
            this.boton_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("boton_Buscar.Image")));
            this.boton_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Buscar.Location = new System.Drawing.Point(407, 82);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(110, 30);
            this.boton_Buscar.TabIndex = 75;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = false;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // txt_FechaHasta
            // 
            this.txt_FechaHasta._campo = "fecha_compra";
            this.txt_FechaHasta._mensaje_error = null;
            this.txt_FechaHasta._nombre_tabla = null;
            this.txt_FechaHasta._pk = false;
            this.txt_FechaHasta._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_FechaHasta._validable = false;
            this.txt_FechaHasta.Enabled = false;
            this.txt_FechaHasta.Location = new System.Drawing.Point(284, 64);
            this.txt_FechaHasta.Mask = "00/00/0000";
            this.txt_FechaHasta.Name = "txt_FechaHasta";
            this.txt_FechaHasta.Size = new System.Drawing.Size(77, 20);
            this.txt_FechaHasta.TabIndex = 10;
            this.txt_FechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_NumFactura
            // 
            this.txt_NumFactura._campo = "nro_factura1";
            this.txt_NumFactura._mensaje_error = null;
            this.txt_NumFactura._nombre_tabla = null;
            this.txt_NumFactura._pk = false;
            this.txt_NumFactura._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_NumFactura._validable = false;
            this.txt_NumFactura.Enabled = false;
            this.txt_NumFactura.Location = new System.Drawing.Point(118, 18);
            this.txt_NumFactura.Mask = "99999";
            this.txt_NumFactura.Name = "txt_NumFactura";
            this.txt_NumFactura.Size = new System.Drawing.Size(77, 20);
            this.txt_NumFactura.TabIndex = 9;
            this.txt_NumFactura.ValidatingType = typeof(int);
            // 
            // txt_Cliente
            // 
            this.txt_Cliente._campo = "nombres";
            this.txt_Cliente._mensaje_error = null;
            this.txt_Cliente._nombre_tabla = null;
            this.txt_Cliente._pk = false;
            this.txt_Cliente._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Cliente._validable = false;
            this.txt_Cliente.Enabled = false;
            this.txt_Cliente.Location = new System.Drawing.Point(118, 41);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(156, 20);
            this.txt_Cliente.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dataGridView1.Location = new System.Drawing.Point(55, 155);
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
            this.dataGridView1.Size = new System.Drawing.Size(841, 276);
            this.dataGridView1.TabIndex = 74;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Location = new System.Drawing.Point(55, 437);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(129, 29);
            this.btn_Limpiar.TabIndex = 151;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Facturas";
            this.Text = "frm_Facturas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Componentes.MaskedTextBokDeControl txt_FechaHasta;
        private Componentes.MaskedTextBokDeControl txt_NumFactura;
        private Componentes.TextBoxDeControl txt_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button boton_Buscar;
        private Componentes.TextBoxDeControl txt_PrecioDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Componentes.MaskedTextBokDeControl txt_FechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Componentes.TextBoxDeControl txt_PrecioHasta;
        private System.Windows.Forms.CheckBox rb_MontoFactura;
        private System.Windows.Forms.CheckBox rb_Fecha;
        private System.Windows.Forms.CheckBox rb_Cliente;
        private System.Windows.Forms.CheckBox rb_numFactura;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}