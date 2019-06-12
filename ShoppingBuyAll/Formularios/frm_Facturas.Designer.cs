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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rb_numFactura = new System.Windows.Forms.RadioButton();
            this.rb_Cliente = new System.Windows.Forms.RadioButton();
            this.rb_Fecha = new System.Windows.Forms.RadioButton();
            this.rb_MontoFactura = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Precio = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.txt_Fecha = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_NumFactura = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_Cliente = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_numFactura
            // 
            this.rb_numFactura.AutoSize = true;
            this.rb_numFactura.Location = new System.Drawing.Point(6, 19);
            this.rb_numFactura.Name = "rb_numFactura";
            this.rb_numFactura.Size = new System.Drawing.Size(101, 17);
            this.rb_numFactura.TabIndex = 4;
            this.rb_numFactura.TabStop = true;
            this.rb_numFactura.Text = "Numero Factura";
            this.rb_numFactura.UseVisualStyleBackColor = true;
            this.rb_numFactura.CheckedChanged += new System.EventHandler(this.rb_numFactura_CheckedChanged);
            // 
            // rb_Cliente
            // 
            this.rb_Cliente.AutoSize = true;
            this.rb_Cliente.Location = new System.Drawing.Point(6, 42);
            this.rb_Cliente.Name = "rb_Cliente";
            this.rb_Cliente.Size = new System.Drawing.Size(57, 17);
            this.rb_Cliente.TabIndex = 5;
            this.rb_Cliente.TabStop = true;
            this.rb_Cliente.Text = "Cliente";
            this.rb_Cliente.UseVisualStyleBackColor = true;
            this.rb_Cliente.CheckedChanged += new System.EventHandler(this.rb_Cliente_CheckedChanged);
            // 
            // rb_Fecha
            // 
            this.rb_Fecha.AutoSize = true;
            this.rb_Fecha.Location = new System.Drawing.Point(6, 65);
            this.rb_Fecha.Name = "rb_Fecha";
            this.rb_Fecha.Size = new System.Drawing.Size(94, 17);
            this.rb_Fecha.TabIndex = 6;
            this.rb_Fecha.TabStop = true;
            this.rb_Fecha.Text = "Fecha Factura";
            this.rb_Fecha.UseVisualStyleBackColor = true;
            this.rb_Fecha.CheckedChanged += new System.EventHandler(this.rb_Fecha_CheckedChanged);
            // 
            // rb_MontoFactura
            // 
            this.rb_MontoFactura.AutoSize = true;
            this.rb_MontoFactura.Location = new System.Drawing.Point(6, 89);
            this.rb_MontoFactura.Name = "rb_MontoFactura";
            this.rb_MontoFactura.Size = new System.Drawing.Size(94, 17);
            this.rb_MontoFactura.TabIndex = 7;
            this.rb_MontoFactura.TabStop = true;
            this.rb_MontoFactura.Text = "Monto Factura";
            this.rb_MontoFactura.UseVisualStyleBackColor = true;
            this.rb_MontoFactura.CheckedChanged += new System.EventHandler(this.rb_MontoFactura_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Precio);
            this.groupBox1.Controls.Add(this.boton_Buscar);
            this.groupBox1.Controls.Add(this.txt_Fecha);
            this.groupBox1.Controls.Add(this.txt_NumFactura);
            this.groupBox1.Controls.Add(this.txt_Cliente);
            this.groupBox1.Controls.Add(this.rb_numFactura);
            this.groupBox1.Controls.Add(this.rb_MontoFactura);
            this.groupBox1.Controls.Add(this.rb_Cliente);
            this.groupBox1.Controls.Add(this.rb_Fecha);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros De Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "$";
            // 
            // txt_Precio
            // 
            this.txt_Precio._campo = null;
            this.txt_Precio._mensaje_error = null;
            this.txt_Precio._nombre_tabla = null;
            this.txt_Precio._pk = false;
            this.txt_Precio._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Precio._validable = false;
            this.txt_Precio.Location = new System.Drawing.Point(118, 88);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(77, 20);
            this.txt_Precio.TabIndex = 76;
            this.txt_Precio.Visible = false;
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
            this.boton_Buscar.Location = new System.Drawing.Point(312, 81);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(136, 30);
            this.boton_Buscar.TabIndex = 75;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = false;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha._campo = null;
            this.txt_Fecha._mensaje_error = null;
            this.txt_Fecha._nombre_tabla = null;
            this.txt_Fecha._pk = false;
            this.txt_Fecha._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_Fecha._validable = false;
            this.txt_Fecha.Location = new System.Drawing.Point(118, 64);
            this.txt_Fecha.Mask = "00/00/0000";
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(77, 20);
            this.txt_Fecha.TabIndex = 10;
            this.txt_Fecha.ValidatingType = typeof(System.DateTime);
            this.txt_Fecha.Visible = false;
            // 
            // txt_NumFactura
            // 
            this.txt_NumFactura._campo = null;
            this.txt_NumFactura._mensaje_error = null;
            this.txt_NumFactura._nombre_tabla = null;
            this.txt_NumFactura._pk = false;
            this.txt_NumFactura._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_NumFactura._validable = false;
            this.txt_NumFactura.Location = new System.Drawing.Point(118, 18);
            this.txt_NumFactura.Mask = "99999";
            this.txt_NumFactura.Name = "txt_NumFactura";
            this.txt_NumFactura.Size = new System.Drawing.Size(77, 20);
            this.txt_NumFactura.TabIndex = 9;
            this.txt_NumFactura.ValidatingType = typeof(int);
            this.txt_NumFactura.Visible = false;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente._campo = null;
            this.txt_Cliente._mensaje_error = null;
            this.txt_Cliente._nombre_tabla = null;
            this.txt_Cliente._pk = false;
            this.txt_Cliente._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Cliente._validable = false;
            this.txt_Cliente.Location = new System.Drawing.Point(118, 41);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(156, 20);
            this.txt_Cliente.TabIndex = 8;
            this.txt_Cliente.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(55, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 276);
            this.dataGridView1.TabIndex = 74;
            // 
            // frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Facturas";
            this.Text = "frm_Facturas";
            this.Load += new System.EventHandler(this.frm_Facturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_numFactura;
        private System.Windows.Forms.RadioButton rb_Cliente;
        private System.Windows.Forms.RadioButton rb_Fecha;
        private System.Windows.Forms.RadioButton rb_MontoFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private Componentes.MaskedTextBokDeControl txt_Fecha;
        private Componentes.MaskedTextBokDeControl txt_NumFactura;
        private Componentes.TextBoxDeControl txt_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Label label1;
        private Componentes.TextBoxDeControl txt_Precio;
    }
}