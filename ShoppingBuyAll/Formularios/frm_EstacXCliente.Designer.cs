namespace ShoppingBuyAll.Formularios
{
    partial class frm_EstacXCliente
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
            this.dSEstacClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstacCliente = new ShoppingBuyAll.Datos.DSEstacCliente();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstacClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstacCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dSEstacClienteBindingSource
            // 
            this.dSEstacClienteBindingSource.DataSource = this.dSEstacCliente;
            this.dSEstacClienteBindingSource.Position = 0;
            // 
            // dSEstacCliente
            // 
            this.dSEstacCliente.DataSetName = "DSEstacCliente";
            this.dSEstacCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(878, 34);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 29);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource3.Name = "DSEstacionamientoCliente";
            reportDataSource3.Value = this.dSEstacClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShoppingBuyAll.Informes.InformeEstacCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1351, 486);
            this.reportViewer1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informe de estacionamiento";
            // 
            // frm_EstacXCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1351, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EstacXCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_EstacXCliente";
            this.Load += new System.EventHandler(this.frm_EstacXCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstacClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstacCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSEstacClienteBindingSource;
        private Datos.DSEstacCliente dSEstacCliente;
        private System.Windows.Forms.Label label1;
    }
}