namespace ShoppingBuyAll.Formularios
{
    partial class frm_InformeClientesXSexo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clientesXSexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_InfromeClientes = new ShoppingBuyAll.DS_InfromeClientes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesXSexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_InfromeClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesXSexoBindingSource
            // 
            this.clientesXSexoBindingSource.DataMember = "ClientesXSexo";
            this.clientesXSexoBindingSource.DataSource = this.dS_InfromeClientes;
            // 
            // dS_InfromeClientes
            // 
            this.dS_InfromeClientes.DataSetName = "DS_InfromeClientes";
            this.dS_InfromeClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource3.Name = "DSSEXO";
            reportDataSource3.Value = this.clientesXSexoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShoppingBuyAll.Informes.ClientesXSexo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1351, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(878, 34);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 29);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informe de clientes por sexo";
            // 
            // frm_InformeClientesXSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1351, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InformeClientesXSexo";
            this.Text = "frm_InformeClientesXSexo";
            this.Load += new System.EventHandler(this.frm_InformeClientesXSexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesXSexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_InfromeClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.BindingSource clientesXSexoBindingSource;
        private DS_InfromeClientes dS_InfromeClientes;
        private System.Windows.Forms.Label label1;
    }
}