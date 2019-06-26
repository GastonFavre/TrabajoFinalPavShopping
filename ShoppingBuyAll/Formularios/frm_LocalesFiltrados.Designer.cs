namespace ShoppingBuyAll.Formularios
{
    partial class frm_LocalesFiltrados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LocalesFiltrados));
            this.datagrid_filtro = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_Nombre = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_CuilLocal = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cb_Nombre = new System.Windows.Forms.CheckBox();
            this.cb_TipoComercio = new System.Windows.Forms.CheckBox();
            this.cb_Cuil = new System.Windows.Forms.CheckBox();
            this.cmb_tipoCom = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_filtro)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_filtro
            // 
            this.datagrid_filtro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_filtro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_filtro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.datagrid_filtro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_filtro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_filtro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_filtro.ColumnHeadersHeight = 30;
            this.datagrid_filtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_filtro.EnableHeadersVisualStyles = false;
            this.datagrid_filtro.GridColor = System.Drawing.Color.SteelBlue;
            this.datagrid_filtro.Location = new System.Drawing.Point(694, 103);
            this.datagrid_filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagrid_filtro.Name = "datagrid_filtro";
            this.datagrid_filtro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_filtro.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.datagrid_filtro.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_filtro.Size = new System.Drawing.Size(734, 421);
            this.datagrid_filtro.TabIndex = 2;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Location = new System.Drawing.Point(1293, 534);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(135, 45);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.btn_buscar);
            this.groupBoxFiltros.Controls.Add(this.txt_Nombre);
            this.groupBoxFiltros.Controls.Add(this.txt_CuilLocal);
            this.groupBoxFiltros.Controls.Add(this.cb_Nombre);
            this.groupBoxFiltros.Controls.Add(this.cb_TipoComercio);
            this.groupBoxFiltros.Controls.Add(this.cb_Cuil);
            this.groupBoxFiltros.Controls.Add(this.cmb_tipoCom);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFiltros.Location = new System.Drawing.Point(67, 103);
            this.groupBoxFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFiltros.Size = new System.Drawing.Size(578, 408);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "FILTROS";
            this.groupBoxFiltros.Enter += new System.EventHandler(this.groupBoxFiltros_Enter);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buscar.Location = new System.Drawing.Point(346, 335);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(184, 52);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre._campo = "nombre";
            this.txt_Nombre._mensaje_error = null;
            this.txt_Nombre._nombre_tabla = null;
            this.txt_Nombre._pk = false;
            this.txt_Nombre._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nombre._validable = false;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(240, 238);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(229, 35);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_CuilLocal
            // 
            this.txt_CuilLocal._campo = "cuil";
            this.txt_CuilLocal._mensaje_error = null;
            this.txt_CuilLocal._nombre_tabla = "Locales";
            this.txt_CuilLocal._pk = true;
            this.txt_CuilLocal._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_CuilLocal._validable = false;
            this.txt_CuilLocal.Enabled = false;
            this.txt_CuilLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuilLocal.Location = new System.Drawing.Point(240, 64);
            this.txt_CuilLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CuilLocal.Name = "txt_CuilLocal";
            this.txt_CuilLocal.Size = new System.Drawing.Size(229, 35);
            this.txt_CuilLocal.TabIndex = 4;
            this.txt_CuilLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CuilLocal_KeyPress);
            // 
            // cb_Nombre
            // 
            this.cb_Nombre.AutoSize = true;
            this.cb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nombre.Location = new System.Drawing.Point(20, 240);
            this.cb_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Nombre.Name = "cb_Nombre";
            this.cb_Nombre.Size = new System.Drawing.Size(133, 33);
            this.cb_Nombre.TabIndex = 3;
            this.cb_Nombre.Text = "Nombre";
            this.cb_Nombre.UseVisualStyleBackColor = true;
            this.cb_Nombre.CheckedChanged += new System.EventHandler(this.cb_Nombre_CheckedChanged);
            // 
            // cb_TipoComercio
            // 
            this.cb_TipoComercio.AutoSize = true;
            this.cb_TipoComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoComercio.Location = new System.Drawing.Point(20, 153);
            this.cb_TipoComercio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_TipoComercio.Name = "cb_TipoComercio";
            this.cb_TipoComercio.Size = new System.Drawing.Size(206, 33);
            this.cb_TipoComercio.TabIndex = 2;
            this.cb_TipoComercio.Text = "TipoComercio";
            this.cb_TipoComercio.UseVisualStyleBackColor = true;
            this.cb_TipoComercio.CheckedChanged += new System.EventHandler(this.cb_TipoComercio_CheckedChanged);
            // 
            // cb_Cuil
            // 
            this.cb_Cuil.AutoSize = true;
            this.cb_Cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cuil.Location = new System.Drawing.Point(20, 66);
            this.cb_Cuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Cuil.Name = "cb_Cuil";
            this.cb_Cuil.Size = new System.Drawing.Size(96, 33);
            this.cb_Cuil.TabIndex = 1;
            this.cb_Cuil.Text = "CUIL";
            this.cb_Cuil.UseVisualStyleBackColor = true;
            this.cb_Cuil.CheckedChanged += new System.EventHandler(this.cb_Cuil_CheckedChanged);
            // 
            // cmb_tipoCom
            // 
            this.cmb_tipoCom._campo = "tipo_Comercio1";
            this.cmb_tipoCom._mensaje_error = "";
            this.cmb_tipoCom._nombre_tabla = "Locales";
            this.cmb_tipoCom._pk = false;
            this.cmb_tipoCom._validable = true;
            this.cmb_tipoCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoCom.Enabled = false;
            this.cmb_tipoCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoCom.FormattingEnabled = true;
            this.cmb_tipoCom.Location = new System.Drawing.Point(240, 149);
            this.cmb_tipoCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_tipoCom.Name = "cmb_tipoCom";
            this.cmb_tipoCom.Size = new System.Drawing.Size(290, 37);
            this.cmb_tipoCom.TabIndex = 5;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Location = new System.Drawing.Point(694, 534);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(194, 45);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_LocalesFiltrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1902, 1106);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.datagrid_filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LocalesFiltrados";
            this.Text = "frm_LocalPorTipo";
            this.Load += new System.EventHandler(this.frm_LocalPorTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_filtro)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.ComboBoxDeControl cmb_tipoCom;
        private System.Windows.Forms.DataGridView datagrid_filtro;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Button btn_buscar;
        private Componentes.TextBoxDeControl txt_Nombre;
        private Componentes.TextBoxDeControl txt_CuilLocal;
        private System.Windows.Forms.CheckBox cb_Nombre;
        private System.Windows.Forms.CheckBox cb_TipoComercio;
        private System.Windows.Forms.CheckBox cb_Cuil;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}