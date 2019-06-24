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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comprasXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShoppingBuyAll.DataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comprasXClienteTableAdapter = new ShoppingBuyAll.DataSet1TableAdapters.ComprasXClienteTableAdapter();
            this.clientesTableAdapter = new ShoppingBuyAll.DataSet1TableAdapters.clientesTableAdapter();
            this.detalleComprasTableAdapter = new ShoppingBuyAll.DataSet1TableAdapters.DetalleComprasTableAdapter();
            this.btn_repCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            reportDataSource1.Name = "DataSetCompras";
            reportDataSource1.Value = this.comprasXClienteBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.clientesBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.detalleComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
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
            // btn_repCompra
            // 
            this.btn_repCompra.FlatAppearance.BorderSize = 0;
            this.btn_repCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_repCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repCompra.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_repCompra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_repCompra.Location = new System.Drawing.Point(12, 75);
            this.btn_repCompra.Name = "btn_repCompra";
            this.btn_repCompra.Size = new System.Drawing.Size(130, 23);
            this.btn_repCompra.TabIndex = 1;
            this.btn_repCompra.Text = "Generar reporte";
            this.btn_repCompra.UseVisualStyleBackColor = true;
            this.btn_repCompra.Click += new System.EventHandler(this.btn_repCompra_Click);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(148, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1375, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_repCompra);
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
        private System.Windows.Forms.Button btn_repCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}