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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CargarGrid = new System.Windows.Forms.Button();
            this.textBoxDeControl1 = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturas";
            // 
            // btn_CargarGrid
            // 
            this.btn_CargarGrid.Location = new System.Drawing.Point(269, 25);
            this.btn_CargarGrid.Name = "btn_CargarGrid";
            this.btn_CargarGrid.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarGrid.TabIndex = 2;
            this.btn_CargarGrid.Text = "Cargar";
            this.btn_CargarGrid.UseVisualStyleBackColor = true;
            this.btn_CargarGrid.Click += new System.EventHandler(this.btn_CargarGrid_Click);
            // 
            // textBoxDeControl1
            // 
            this.textBoxDeControl1._campo = null;
            this.textBoxDeControl1._mensaje_error = null;
            this.textBoxDeControl1._nombre_tabla = null;
            this.textBoxDeControl1._pk = false;
            this.textBoxDeControl1._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.textBoxDeControl1._validable = false;
            this.textBoxDeControl1.Location = new System.Drawing.Point(149, 28);
            this.textBoxDeControl1.Name = "textBoxDeControl1";
            this.textBoxDeControl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeControl1.TabIndex = 3;
            // 
            // frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.textBoxDeControl1);
            this.Controls.Add(this.btn_CargarGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Facturas";
            this.Text = "frm_Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CargarGrid;
        private Componentes.TextBoxDeControl textBoxDeControl1;
    }
}