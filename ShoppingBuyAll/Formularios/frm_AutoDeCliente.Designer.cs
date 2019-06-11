namespace ShoppingBuyAll.Formularios
{
    partial class frm_AutoDeCliente
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
            this.dataGrid_Automoviles = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cmb_Tipo_Doc = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.txt_nroDoc = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Automoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Automoviles
            // 
            this.dataGrid_Automoviles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGrid_Automoviles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Automoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Automoviles.Location = new System.Drawing.Point(333, 12);
            this.dataGrid_Automoviles.Name = "dataGrid_Automoviles";
            this.dataGrid_Automoviles.Size = new System.Drawing.Size(568, 320);
            this.dataGrid_Automoviles.TabIndex = 0;
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
            this.btn_Salir.Location = new System.Drawing.Point(179, 302);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(99, 30);
            this.btn_Salir.TabIndex = 102;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // cmb_Tipo_Doc
            // 
            this.cmb_Tipo_Doc._campo = "tipo_doc2";
            this.cmb_Tipo_Doc._mensaje_error = "No se selecciono un tipo de documento";
            this.cmb_Tipo_Doc._nombre_tabla = "automoviles";
            this.cmb_Tipo_Doc._pk = false;
            this.cmb_Tipo_Doc._validable = true;
            this.cmb_Tipo_Doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Tipo_Doc.FormattingEnabled = true;
            this.cmb_Tipo_Doc.Location = new System.Drawing.Point(15, 44);
            this.cmb_Tipo_Doc.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Tipo_Doc.Name = "cmb_Tipo_Doc";
            this.cmb_Tipo_Doc.Size = new System.Drawing.Size(263, 28);
            this.cmb_Tipo_Doc.TabIndex = 103;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc._campo = "num_doc1";
            this.txt_nroDoc._mensaje_error = "No se ingreso un numero de documento";
            this.txt_nroDoc._nombre_tabla = "automoviles";
            this.txt_nroDoc._pk = false;
            this.txt_nroDoc._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_nroDoc._validable = true;
            this.txt_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDoc.Location = new System.Drawing.Point(15, 131);
            this.txt_nroDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nroDoc.MaxLength = 8;
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(263, 26);
            this.txt_nroDoc.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Nro Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Tipo Documento";
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
            this.btn_Buscar.Location = new System.Drawing.Point(62, 302);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(99, 30);
            this.btn_Buscar.TabIndex = 107;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frm_AutoDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(913, 357);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.cmb_Tipo_Doc);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGrid_Automoviles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AutoDeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AutoDeCliente";
            this.Load += new System.EventHandler(this.frm_AutoDeCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Automoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Automoviles;
        private System.Windows.Forms.Button btn_Salir;
        private Componentes.ComboBoxDeControl cmb_Tipo_Doc;
        private Componentes.TextBoxDeControl txt_nroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Buscar;
    }
}