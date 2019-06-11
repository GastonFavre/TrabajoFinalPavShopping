namespace ShoppingBuyAll.Formularios
{
    partial class frm_Automoviles_Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Automoviles_Marca));
            this.dataGrid_MarcaAuto = new System.Windows.Forms.DataGridView();
            this.Barra_De_Titulo = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_rest = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MarcaAuto)).BeginInit();
            this.Barra_De_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_MarcaAuto
            // 
            this.dataGrid_MarcaAuto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGrid_MarcaAuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_MarcaAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MarcaAuto.Location = new System.Drawing.Point(12, 36);
            this.dataGrid_MarcaAuto.Name = "dataGrid_MarcaAuto";
            this.dataGrid_MarcaAuto.Size = new System.Drawing.Size(680, 354);
            this.dataGrid_MarcaAuto.TabIndex = 1;
            // 
            // Barra_De_Titulo
            // 
            this.Barra_De_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.Barra_De_Titulo.Controls.Add(this.btn_min);
            this.Barra_De_Titulo.Controls.Add(this.btn_rest);
            this.Barra_De_Titulo.Controls.Add(this.btn_max);
            this.Barra_De_Titulo.Controls.Add(this.btn_close);
            this.Barra_De_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_De_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_De_Titulo.Name = "Barra_De_Titulo";
            this.Barra_De_Titulo.Size = new System.Drawing.Size(704, 30);
            this.Barra_De_Titulo.TabIndex = 2;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(641, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(16, 16);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_min.TabIndex = 5;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click_1);
            // 
            // btn_rest
            // 
            this.btn_rest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rest.Image = ((System.Drawing.Image)(resources.GetObject("btn_rest.Image")));
            this.btn_rest.Location = new System.Drawing.Point(663, 3);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(16, 16);
            this.btn_rest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_rest.TabIndex = 6;
            this.btn_rest.TabStop = false;
            this.btn_rest.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(663, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(16, 16);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_max.TabIndex = 8;
            this.btn_max.TabStop = false;
            this.btn_max.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(685, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close.TabIndex = 7;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_Automoviles_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.Barra_De_Titulo);
            this.Controls.Add(this.dataGrid_MarcaAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Automoviles_Marca";
            this.Text = "frm_Automoviles_Marca";
            this.Load += new System.EventHandler(this.frm_Automoviles_Marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MarcaAuto)).EndInit();
            this.Barra_De_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_MarcaAuto;
        private System.Windows.Forms.Panel Barra_De_Titulo;
        private System.Windows.Forms.PictureBox btn_min;
        private System.Windows.Forms.PictureBox btn_rest;
        private System.Windows.Forms.PictureBox btn_max;
        private System.Windows.Forms.PictureBox btn_close;
    }
}