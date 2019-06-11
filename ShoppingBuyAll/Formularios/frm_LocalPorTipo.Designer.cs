namespace ShoppingBuyAll.Formularios
{
    partial class frm_LocalPorTipo
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipo_com = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dataGrid_LocXTipo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_LocXTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 29);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tipo de local/comercio";
            // 
            // cmb_tipo_com
            // 
            this.cmb_tipo_com._campo = "tipo_Comercio1";
            this.cmb_tipo_com._mensaje_error = "No se seleccionó el tipo de comercio";
            this.cmb_tipo_com._nombre_tabla = "Locales";
            this.cmb_tipo_com._pk = false;
            this.cmb_tipo_com._validable = true;
            this.cmb_tipo_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_tipo_com.FormattingEnabled = true;
            this.cmb_tipo_com.Location = new System.Drawing.Point(48, 172);
            this.cmb_tipo_com.Name = "cmb_tipo_com";
            this.cmb_tipo_com.Size = new System.Drawing.Size(392, 37);
            this.cmb_tipo_com.TabIndex = 107;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(117, 420);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(148, 46);
            this.btn_Buscar.TabIndex = 109;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(292, 420);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(148, 46);
            this.btn_Salir.TabIndex = 108;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dataGrid_LocXTipo
            // 
            this.dataGrid_LocXTipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGrid_LocXTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_LocXTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_LocXTipo.Location = new System.Drawing.Point(527, 47);
            this.dataGrid_LocXTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid_LocXTipo.Name = "dataGrid_LocXTipo";
            this.dataGrid_LocXTipo.Size = new System.Drawing.Size(852, 492);
            this.dataGrid_LocXTipo.TabIndex = 110;
            // 
            // frm_LocalPorTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1420, 602);
            this.Controls.Add(this.dataGrid_LocXTipo);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.cmb_tipo_com);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LocalPorTipo";
            this.Text = "frm_LocalPorTipo";
            this.Load += new System.EventHandler(this.frm_LocalPorTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_LocXTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Componentes.ComboBoxDeControl cmb_tipo_com;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dataGrid_LocXTipo;
    }
}