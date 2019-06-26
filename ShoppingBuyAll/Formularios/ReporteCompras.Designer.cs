namespace ShoppingBuyAll.Formularios
{
    partial class ReporteCompras
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comprasXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShoppingBuyAll.DataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comprasXClienteTableAdapter = new ShoppingBuyAll.DataSet1TableAdapters.ComprasXClienteTableAdapter();
            this.clientesTableAdapter = new ShoppingBuyAll.DataSet1TableAdapters.clientesTableAdapter();
            this.detalleComprasTableAdapter = new ShoppingBuyAll.DataSet1TableAdapters.DetalleComprasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FechaDesde = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.txt_FechaHasta = new ShoppingBuyAll.Componentes.MaskedTextBokDeControl(this.components);
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comprasXClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comprasXClienteBindingSource
            // 
            this.comprasXClienteBindingSource.DataMember = "ComprasXCliente";
            this.comprasXClienteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataSet1;
            // 
            // detalleComprasBindingSource
            // 
            this.detalleComprasBindingSource.DataMember = "DetalleCompras";
            this.detalleComprasBindingSource.DataSource = this.dataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.SteelBlue;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource4.Name = "DataSetCompras";
            reportDataSource4.Value = this.comprasXClienteBindingSource;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.clientesBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.detalleComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShoppingBuyAll.Informes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1351, 456);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // comprasXClienteTableAdapter
            // 
            this.comprasXClienteTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // detalleComprasTableAdapter
            // 
            this.detalleComprasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe de compras por cliente";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(308, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 95;
            this.button2.Text = "Generar reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(152, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 93;
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
            this.txt_FechaDesde.Location = new System.Drawing.Point(69, 72);
            this.txt_FechaDesde.Mask = "00/00/0000";
            this.txt_FechaDesde.Name = "txt_FechaDesde";
            this.txt_FechaDesde.Size = new System.Drawing.Size(77, 26);
            this.txt_FechaDesde.TabIndex = 92;
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
            this.txt_FechaHasta.Location = new System.Drawing.Point(210, 72);
            this.txt_FechaHasta.Mask = "00/00/0000";
            this.txt_FechaHasta.Name = "txt_FechaHasta";
            this.txt_FechaHasta.Size = new System.Drawing.Size(77, 26);
            this.txt_FechaHasta.TabIndex = 91;
            this.txt_FechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(438, 69);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 29);
            this.btn_Salir.TabIndex = 96;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1375, 572);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FechaDesde);
            this.Controls.Add(this.txt_FechaHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteCompras";
            this.Text = "ReporteCompras";
            this.Load += new System.EventHandler(this.ReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprasXClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleComprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource comprasXClienteBindingSource;
        private DataSet1TableAdapters.ComprasXClienteTableAdapter comprasXClienteTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSet1TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource detalleComprasBindingSource;
        private DataSet1TableAdapters.DetalleComprasTableAdapter detalleComprasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Componentes.MaskedTextBokDeControl txt_FechaDesde;
        private Componentes.MaskedTextBokDeControl txt_FechaHasta;
        private System.Windows.Forms.Button btn_Salir;
    }
}