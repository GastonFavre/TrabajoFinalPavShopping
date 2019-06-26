namespace ShoppingBuyAll.Formularios
{
    partial class frm_RubroLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RubroLocal));
            this.txt_Cuil = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Rubro = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.boton_Modi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Cuil
            // 
            this.txt_Cuil._campo = "cuil_local1";
            this.txt_Cuil._mensaje_error = null;
            this.txt_Cuil._nombre_tabla = "LocalesXRubro";
            this.txt_Cuil._pk = true;
            this.txt_Cuil._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_Cuil._validable = false;
            this.txt_Cuil.Enabled = false;
            this.txt_Cuil.Location = new System.Drawing.Point(443, 70);
            this.txt_Cuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Cuil.Name = "txt_Cuil";
            this.txt_Cuil.Size = new System.Drawing.Size(180, 26);
            this.txt_Cuil.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(346, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 104;
            this.label3.Text = "CUIL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb_Rubro
            // 
            this.cmb_Rubro._campo = "cod_rub1";
            this.cmb_Rubro._mensaje_error = "No se ingreso el Rubro";
            this.cmb_Rubro._nombre_tabla = "LocalesXRubro";
            this.cmb_Rubro._pk = true;
            this.cmb_Rubro._validable = false;
            this.cmb_Rubro.FormattingEnabled = true;
            this.cmb_Rubro.Location = new System.Drawing.Point(445, 122);
            this.cmb_Rubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Rubro.Name = "cmb_Rubro";
            this.cmb_Rubro.Size = new System.Drawing.Size(178, 28);
            this.cmb_Rubro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(346, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 106;
            this.label1.Text = "Rubro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
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
            this.boton_Agregar.Location = new System.Drawing.Point(325, 282);
            this.boton_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(148, 46);
            this.boton_Agregar.TabIndex = 1;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = false;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
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
            this.boton_Modi.Location = new System.Drawing.Point(503, 282);
            this.boton_Modi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Modi.Name = "boton_Modi";
            this.boton_Modi.Size = new System.Drawing.Size(148, 46);
            this.boton_Modi.TabIndex = 2;
            this.boton_Modi.Text = "Cancelar";
            this.boton_Modi.UseVisualStyleBackColor = false;
            this.boton_Modi.Click += new System.EventHandler(this.boton_Modi_Click);
            // 
            // frm_RubroLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(696, 372);
            this.Controls.Add(this.boton_Modi);
            this.Controls.Add(this.boton_Agregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Rubro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cuil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RubroLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_RubroLocal";
            this.Load += new System.EventHandler(this.frm_RubroLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Componentes.TextBoxDeControl txt_Cuil;
        private System.Windows.Forms.Label label3;
        private Componentes.ComboBoxDeControl cmb_Rubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.Button boton_Modi;
    }
}