namespace ShoppingBuyAll.Formularios
{
    partial class frm_TarjetaCliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_Modi = new System.Windows.Forms.Button();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.txt_TipoDoc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_NumDocu = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmb_FechaVencimiento = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_NumTarjeta = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.cmb_CodTarjeta = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoppingBuyAll.Properties.Resources.tarjeta3;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(250, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Codigo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(217, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nro Tarjeta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(207, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Vencimineto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(235, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Tipo Doc:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(233, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Num Doc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // boton_Modi
            // 
            this.boton_Modi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton_Modi.FlatAppearance.BorderSize = 0;
            this.boton_Modi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Modi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Modi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Modi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Modi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Modi.Location = new System.Drawing.Point(346, 197);
            this.boton_Modi.Name = "boton_Modi";
            this.boton_Modi.Size = new System.Drawing.Size(99, 30);
            this.boton_Modi.TabIndex = 100;
            this.boton_Modi.Text = "Cancelar";
            this.boton_Modi.UseVisualStyleBackColor = false;
            this.boton_Modi.Click += new System.EventHandler(this.boton_Modi_Click);
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton_Agregar.FlatAppearance.BorderSize = 0;
            this.boton_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Agregar.Location = new System.Drawing.Point(211, 197);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(99, 30);
            this.boton_Agregar.TabIndex = 99;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = false;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // txt_TipoDoc
            // 
            this.txt_TipoDoc._campo = "tipo_doc3";
            this.txt_TipoDoc._mensaje_error = null;
            this.txt_TipoDoc._nombre_tabla = "TarjetaXCliente";
            this.txt_TipoDoc._pk = true;
            this.txt_TipoDoc._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_TipoDoc._validable = false;
            this.txt_TipoDoc.Enabled = false;
            this.txt_TipoDoc.Location = new System.Drawing.Point(326, 29);
            this.txt_TipoDoc.Name = "txt_TipoDoc";
            this.txt_TipoDoc.Size = new System.Drawing.Size(88, 20);
            this.txt_TipoDoc.TabIndex = 101;
            // 
            // txt_NumDocu
            // 
            this.txt_NumDocu._campo = "num_doc3";
            this.txt_NumDocu._mensaje_error = null;
            this.txt_NumDocu._nombre_tabla = "TarjetaXCliente";
            this.txt_NumDocu._pk = true;
            this.txt_NumDocu._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_NumDocu._validable = false;
            this.txt_NumDocu.Enabled = false;
            this.txt_NumDocu.Location = new System.Drawing.Point(326, 63);
            this.txt_NumDocu.Name = "txt_NumDocu";
            this.txt_NumDocu.Size = new System.Drawing.Size(88, 20);
            this.txt_NumDocu.TabIndex = 95;
            // 
            // cmb_FechaVencimiento
            // 
            this.cmb_FechaVencimiento._campo = "fecha_venc";
            this.cmb_FechaVencimiento._mensaje_error = "No ingreso la fecha de vencimiento de la tarejta";
            this.cmb_FechaVencimiento._nombre_tabla = "TarjetaXCliente";
            this.cmb_FechaVencimiento._pk = false;
            this.cmb_FechaVencimiento._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.fecha;
            this.cmb_FechaVencimiento._validable = true;
            this.cmb_FechaVencimiento.Location = new System.Drawing.Point(326, 157);
            this.cmb_FechaVencimiento.Mask = "00/00/0000";
            this.cmb_FechaVencimiento.Name = "cmb_FechaVencimiento";
            this.cmb_FechaVencimiento.Size = new System.Drawing.Size(73, 20);
            this.cmb_FechaVencimiento.TabIndex = 92;
            this.cmb_FechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_NumTarjeta
            // 
            this.txt_NumTarjeta._campo = "nro_tarje3";
            this.txt_NumTarjeta._mensaje_error = "No se ingreso el numero de la tarejeta";
            this.txt_NumTarjeta._nombre_tabla = "TarjetaXCliente";
            this.txt_NumTarjeta._pk = true;
            this.txt_NumTarjeta._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_NumTarjeta._validable = true;
            this.txt_NumTarjeta.Location = new System.Drawing.Point(326, 127);
            this.txt_NumTarjeta.Mask = "99999";
            this.txt_NumTarjeta.Name = "txt_NumTarjeta";
            this.txt_NumTarjeta.Size = new System.Drawing.Size(37, 20);
            this.txt_NumTarjeta.TabIndex = 91;
            // 
            // cmb_CodTarjeta
            // 
            this.cmb_CodTarjeta._campo = "cod_tarje3";
            this.cmb_CodTarjeta._mensaje_error = "No se ingreso el codigo de la tarjeta";
            this.cmb_CodTarjeta._nombre_tabla = "TarjetaXCliente";
            this.cmb_CodTarjeta._pk = false;
            this.cmb_CodTarjeta._validable = false;
            this.cmb_CodTarjeta.FormattingEnabled = true;
            this.cmb_CodTarjeta.Location = new System.Drawing.Point(326, 94);
            this.cmb_CodTarjeta.Name = "cmb_CodTarjeta";
            this.cmb_CodTarjeta.Size = new System.Drawing.Size(119, 21);
            this.cmb_CodTarjeta.TabIndex = 102;
            // 
            // frm_TarjetaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 242);
            this.Controls.Add(this.cmb_CodTarjeta);
            this.Controls.Add(this.txt_TipoDoc);
            this.Controls.Add(this.boton_Modi);
            this.Controls.Add(this.boton_Agregar);
            this.Controls.Add(this.txt_NumDocu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_FechaVencimiento);
            this.Controls.Add(this.txt_NumTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TarjetaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TarjetaCliente";
            this.Load += new System.EventHandler(this.frm_TarjetaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Componentes.MaskedTextBokDeControl txt_NumTarjeta;
        private Componentes.MaskedTextBokDeControl cmb_FechaVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_Modi;
        private System.Windows.Forms.Button boton_Agregar;
        public Componentes.TextBoxDeControl txt_NumDocu;
        public Componentes.TextBoxDeControl txt_TipoDoc;
        private Componentes.ComboBoxDeControl cmb_CodTarjeta;
    }
}