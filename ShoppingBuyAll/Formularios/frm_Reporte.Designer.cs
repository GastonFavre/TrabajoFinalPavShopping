namespace ShoppingBuyAll.Formularios
{
    partial class frm_Reporte
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
            this.btn_Locales = new System.Windows.Forms.PictureBox();
            this.btn_Clientes = new System.Windows.Forms.PictureBox();
            this.btn_Productos = new System.Windows.Forms.PictureBox();
            this.btn_Estacionamiento = new System.Windows.Forms.PictureBox();
            this.btn_Automoviles = new System.Windows.Forms.PictureBox();
            this.btn_Ventas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Locales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Estacionamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Automoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Locales
            // 
            this.btn_Locales.BackColor = System.Drawing.Color.Transparent;
            this.btn_Locales.BackgroundImage = global::ShoppingBuyAll.Properties.Resources.icono_exponegocios_02;
            this.btn_Locales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Locales.Location = new System.Drawing.Point(621, 322);
            this.btn_Locales.Name = "btn_Locales";
            this.btn_Locales.Size = new System.Drawing.Size(200, 200);
            this.btn_Locales.TabIndex = 5;
            this.btn_Locales.TabStop = false;
            this.btn_Locales.Click += new System.EventHandler(this.btn_Locales_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clientes.BackgroundImage = global::ShoppingBuyAll.Properties.Resources.person_1058425_1;
            this.btn_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clientes.Location = new System.Drawing.Point(372, 322);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(200, 200);
            this.btn_Clientes.TabIndex = 4;
            this.btn_Clientes.TabStop = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackColor = System.Drawing.Color.Transparent;
            this.btn_Productos.BackgroundImage = global::ShoppingBuyAll.Properties.Resources.icono_proveedor_png_4;
            this.btn_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Productos.Location = new System.Drawing.Point(120, 322);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(200, 200);
            this.btn_Productos.TabIndex = 3;
            this.btn_Productos.TabStop = false;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);

            // 
            // btn_Estacionamiento
            // 
            this.btn_Estacionamiento.BackColor = System.Drawing.Color.Transparent;
            this.btn_Estacionamiento.BackgroundImage = global::ShoppingBuyAll.Properties.Resources.estacionamiento_icono_png1;
            this.btn_Estacionamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Estacionamiento.Location = new System.Drawing.Point(621, 100);
            this.btn_Estacionamiento.Name = "btn_Estacionamiento";
            this.btn_Estacionamiento.Size = new System.Drawing.Size(200, 200);
            this.btn_Estacionamiento.TabIndex = 2;
            this.btn_Estacionamiento.TabStop = false;
            this.btn_Estacionamiento.Click += new System.EventHandler(this.btn_Estacionamiento_Click);

            // 
            // btn_Automoviles
            // 
            this.btn_Automoviles.BackColor = System.Drawing.Color.Transparent;
            this.btn_Automoviles.BackgroundImage = global::ShoppingBuyAll.Properties.Resources.car_icon;
            this.btn_Automoviles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Automoviles.Location = new System.Drawing.Point(372, 100);
            this.btn_Automoviles.Name = "btn_Automoviles";
            this.btn_Automoviles.Size = new System.Drawing.Size(200, 200);
            this.btn_Automoviles.TabIndex = 1;
            this.btn_Automoviles.TabStop = false;
            this.btn_Automoviles.Click += new System.EventHandler(this.btn_Automoviles_Click);

            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ventas.BackgroundImage = global::ShoppingBuyAll.Properties.Resources.ventas_icono_png_5;
            this.btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ventas.Location = new System.Drawing.Point(120, 100);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(200, 200);
            this.btn_Ventas.TabIndex = 0;
            this.btn_Ventas.TabStop = false;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);

            // 
            // frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(943, 591);
            this.Controls.Add(this.btn_Locales);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Estacionamiento);
            this.Controls.Add(this.btn_Automoviles);
            this.Controls.Add(this.btn_Ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Locales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Estacionamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Automoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Ventas;
        private System.Windows.Forms.PictureBox btn_Automoviles;
        private System.Windows.Forms.PictureBox btn_Estacionamiento;
        private System.Windows.Forms.PictureBox btn_Productos;
        private System.Windows.Forms.PictureBox btn_Clientes;
        private System.Windows.Forms.PictureBox btn_Locales;
    }
}