namespace ShoppingBuyAll.Formularios
{
    partial class frm_ReporteProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.topProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new ShoppingBuyAll.Datos.DataSetProductos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FechaDesde = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_FechaHasta = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // topProductosBindingSource
            // 
            this.topProductosBindingSource.DataMember = "topProductos";
            this.topProductosBindingSource.DataSource = this.dataSetProductos;
            // 
            // dataSetProductos
            // 
            this.dataSetProductos.DataSetName = "DataSetProductos";
            this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.topProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShoppingBuyAll.Informes.Infr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1351, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe de productos mas vendidos";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(878, 34);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 29);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(599, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(459, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 83;
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
            this.txt_FechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaDesde.Location = new System.Drawing.Point(516, 34);
            this.txt_FechaDesde.Mask = "00/00/0000";
            this.txt_FechaDesde.Name = "txt_FechaDesde";
            this.txt_FechaDesde.Size = new System.Drawing.Size(77, 26);
            this.txt_FechaDesde.TabIndex = 82;
            this.txt_FechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_FechaHasta
            // 
            this.txt_FechaHasta._campo = "fecha_compra";
            this.txt_FechaHasta._mensaje_error = null;
            this.txt_FechaHasta._nombre_tabla = null;
            this.txt_FechaHasta._pk = false;
            this.txt_FechaHasta._tipo = ShoppingBuyAll.Componentes.MaskedTextBokDeControl.Tipo_dato.texto;
            this.txt_FechaHasta._validable = false;
            this.txt_FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaHasta.Location = new System.Drawing.Point(657, 34);
            this.txt_FechaHasta.Mask = "00/00/0000";
            this.txt_FechaHasta.Name = "txt_FechaHasta";
            this.txt_FechaHasta.Size = new System.Drawing.Size(77, 26);
            this.txt_FechaHasta.TabIndex = 81;
            this.txt_FechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(757, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 85;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1375, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FechaDesde);
            this.Controls.Add(this.txt_FechaHasta);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ReporteProductos";
            this.Text = "frm_ReporteProductos";
            this.Load += new System.EventHandler(this.frm_ReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.BindingSource topProductosBindingSource;
        private Datos.DataSetProductos dataSetProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Componentes.MaskedTextBokDeControl txt_FechaDesde;
        private Componentes.MaskedTextBokDeControl txt_FechaHasta;
        private System.Windows.Forms.Button button1;
    }
}