﻿namespace ShoppingBuyAll.Formularios
{
    partial class frm_Modelo
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
            this.txt_Nombre_Modelo = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmb_Marca = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nombre_Modelo
            // 
            this.txt_Nombre_Modelo._campo = null;
            this.txt_Nombre_Modelo._mensaje_error = null;
            this.txt_Nombre_Modelo._nombre_tabla = null;
            this.txt_Nombre_Modelo._pk = false;
            this.txt_Nombre_Modelo._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nombre_Modelo._validable = true;
            this.txt_Nombre_Modelo.Location = new System.Drawing.Point(170, 38);
            this.txt_Nombre_Modelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombre_Modelo.Name = "txt_Nombre_Modelo";
            this.txt_Nombre_Modelo.Size = new System.Drawing.Size(164, 26);
            this.txt_Nombre_Modelo.TabIndex = 0;
            // 
            // cmb_Marca
            // 
            this.cmb_Marca._campo = null;
            this.cmb_Marca._mensaje_error = null;
            this.cmb_Marca._nombre_tabla = null;
            this.cmb_Marca._pk = false;
            this.cmb_Marca._validable = true;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Location = new System.Drawing.Point(170, 74);
            this.cmb_Marca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(164, 28);
            this.cmb_Marca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(119, 119);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(99, 30);
            this.btn_Agregar.TabIndex = 101;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
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
            this.btn_Salir.Location = new System.Drawing.Point(235, 119);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(99, 30);
            this.btn_Salir.TabIndex = 102;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(368, 165);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Marca);
            this.Controls.Add(this.txt_Nombre_Modelo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Modelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Modelo";
            this.Load += new System.EventHandler(this.frm_Modelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxDeControl txt_Nombre_Modelo;
        private Componentes.ComboBoxDeControl cmb_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Salir;
    }
}