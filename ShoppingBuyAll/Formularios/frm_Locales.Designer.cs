namespace ShoppingBuyAll.Formularios
{
    partial class frm_Locales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Locales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_cuil = new System.Windows.Forms.Label();
            this.lb_nombre_loc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Cuil = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_Nombre_Local = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.cmb_Tipo_Loc = new ShoppingBuyAll.Componentes.ComboBoxDeControl();
            this.btn_Buscar_CUIL = new System.Windows.Forms.Button();
            this.boton_Nuevo = new System.Windows.Forms.Button();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.boton_Modi = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_mostrarRubros = new System.Windows.Forms.Button();
            this.btn_agregarRubro = new System.Windows.Forms.Button();
            this.btn_filtros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_cuil
            // 
            this.lb_cuil.AutoSize = true;
            this.lb_cuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lb_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cuil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_cuil.Location = new System.Drawing.Point(325, 261);
            this.lb_cuil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cuil.Name = "lb_cuil";
            this.lb_cuil.Size = new System.Drawing.Size(70, 29);
            this.lb_cuil.TabIndex = 41;
            this.lb_cuil.Text = "CUIL";
            // 
            // lb_nombre_loc
            // 
            this.lb_nombre_loc.AutoSize = true;
            this.lb_nombre_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lb_nombre_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_loc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_nombre_loc.Location = new System.Drawing.Point(181, 341);
            this.lb_nombre_loc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nombre_loc.Name = "lb_nombre_loc";
            this.lb_nombre_loc.Size = new System.Drawing.Size(214, 29);
            this.lb_nombre_loc.TabIndex = 42;
            this.lb_nombre_loc.Text = "Nombre del local";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(126, 413);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 29);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tipo de local/negocio";
            // 
            // txt_Cuil
            // 
            this.txt_Cuil._campo = "cuil";
            this.txt_Cuil._mensaje_error = "No se Ingreso el CUIL";
            this.txt_Cuil._nombre_tabla = "Locales";
            this.txt_Cuil._pk = true;
            this.txt_Cuil._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_Cuil._validable = true;
            this.txt_Cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cuil.Location = new System.Drawing.Point(414, 261);
            this.txt_Cuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Cuil.MaxLength = 19;
            this.txt_Cuil.Name = "txt_Cuil";
            this.txt_Cuil.Size = new System.Drawing.Size(288, 35);
            this.txt_Cuil.TabIndex = 0;
            // 
            // txt_Nombre_Local
            // 
            this.txt_Nombre_Local._campo = "nombre";
            this.txt_Nombre_Local._mensaje_error = "No se ingresó el nombre del local";
            this.txt_Nombre_Local._nombre_tabla = "Locales";
            this.txt_Nombre_Local._pk = false;
            this.txt_Nombre_Local._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_Nombre_Local._validable = true;
            this.txt_Nombre_Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Local.Location = new System.Drawing.Point(414, 335);
            this.txt_Nombre_Local.MaxLength = 30;
            this.txt_Nombre_Local.Name = "txt_Nombre_Local";
            this.txt_Nombre_Local.Size = new System.Drawing.Size(463, 35);
            this.txt_Nombre_Local.TabIndex = 1;
            // 
            // cmb_Tipo_Loc
            // 
            this.cmb_Tipo_Loc._campo = "tipo_Comercio1";
            this.cmb_Tipo_Loc._mensaje_error = "No se seleccionó el tipo de comercio";
            this.cmb_Tipo_Loc._nombre_tabla = "Locales";
            this.cmb_Tipo_Loc._pk = false;
            this.cmb_Tipo_Loc._validable = true;
            this.cmb_Tipo_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Tipo_Loc.FormattingEnabled = true;
            this.cmb_Tipo_Loc.Location = new System.Drawing.Point(414, 405);
            this.cmb_Tipo_Loc.Name = "cmb_Tipo_Loc";
            this.cmb_Tipo_Loc.Size = new System.Drawing.Size(386, 37);
            this.cmb_Tipo_Loc.TabIndex = 2;
            // 
            // btn_Buscar_CUIL
            // 
            this.btn_Buscar_CUIL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscar_CUIL.BackgroundImage")));
            this.btn_Buscar_CUIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar_CUIL.Location = new System.Drawing.Point(710, 261);
            this.btn_Buscar_CUIL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Buscar_CUIL.Name = "btn_Buscar_CUIL";
            this.btn_Buscar_CUIL.Size = new System.Drawing.Size(40, 35);
            this.btn_Buscar_CUIL.TabIndex = 12;
            this.btn_Buscar_CUIL.UseVisualStyleBackColor = true;
            this.btn_Buscar_CUIL.Visible = false;
            this.btn_Buscar_CUIL.Click += new System.EventHandler(this.btn_Buscar_CUIL_Click);
            // 
            // boton_Nuevo
            // 
            this.boton_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boton_Nuevo.FlatAppearance.BorderSize = 0;
            this.boton_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("boton_Nuevo.Image")));
            this.boton_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Nuevo.Location = new System.Drawing.Point(131, 685);
            this.boton_Nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Nuevo.Name = "boton_Nuevo";
            this.boton_Nuevo.Size = new System.Drawing.Size(204, 46);
            this.boton_Nuevo.TabIndex = 6;
            this.boton_Nuevo.Text = "Nuevo";
            this.boton_Nuevo.UseVisualStyleBackColor = false;
            this.boton_Nuevo.Click += new System.EventHandler(this.boton_Nuevo_Click);
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boton_Agregar.FlatAppearance.BorderSize = 0;
            this.boton_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("boton_Agregar.Image")));
            this.boton_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Agregar.Location = new System.Drawing.Point(330, 685);
            this.boton_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(219, 46);
            this.boton_Agregar.TabIndex = 7;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = false;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // boton_Modi
            // 
            this.boton_Modi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boton_Modi.FlatAppearance.BorderSize = 0;
            this.boton_Modi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Modi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Modi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Modi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Modi.Image = ((System.Drawing.Image)(resources.GetObject("boton_Modi.Image")));
            this.boton_Modi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Modi.Location = new System.Drawing.Point(531, 685);
            this.boton_Modi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Modi.Name = "boton_Modi";
            this.boton_Modi.Size = new System.Drawing.Size(219, 46);
            this.boton_Modi.TabIndex = 8;
            this.boton_Modi.Text = "Modificar";
            this.boton_Modi.UseVisualStyleBackColor = false;
            this.boton_Modi.Click += new System.EventHandler(this.boton_Modi_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boton_Eliminar.FlatAppearance.BorderSize = 0;
            this.boton_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("boton_Eliminar.Image")));
            this.boton_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Eliminar.Location = new System.Drawing.Point(729, 685);
            this.boton_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(204, 46);
            this.boton_Eliminar.TabIndex = 9;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = false;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boton_Buscar.FlatAppearance.BorderSize = 0;
            this.boton_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.boton_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("boton_Buscar.Image")));
            this.boton_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_Buscar.Location = new System.Drawing.Point(921, 685);
            this.boton_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(204, 46);
            this.boton_Buscar.TabIndex = 10;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = false;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(311, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Rubro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(414, 476);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 106);
            this.dataGridView1.TabIndex = 79;
            // 
            // btn_mostrarRubros
            // 
            this.btn_mostrarRubros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_mostrarRubros.FlatAppearance.BorderSize = 0;
            this.btn_mostrarRubros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_mostrarRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_mostrarRubros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mostrarRubros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mostrarRubros.Location = new System.Drawing.Point(414, 608);
            this.btn_mostrarRubros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mostrarRubros.Name = "btn_mostrarRubros";
            this.btn_mostrarRubros.Size = new System.Drawing.Size(204, 46);
            this.btn_mostrarRubros.TabIndex = 3;
            this.btn_mostrarRubros.Text = "Mostrar Rubros";
            this.btn_mostrarRubros.UseVisualStyleBackColor = false;
            this.btn_mostrarRubros.Click += new System.EventHandler(this.btn_mostrarRubros_Click);
            // 
            // btn_agregarRubro
            // 
            this.btn_agregarRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_agregarRubro.FlatAppearance.BorderSize = 0;
            this.btn_agregarRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_agregarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_agregarRubro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregarRubro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarRubro.Location = new System.Drawing.Point(660, 608);
            this.btn_agregarRubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_agregarRubro.Name = "btn_agregarRubro";
            this.btn_agregarRubro.Size = new System.Drawing.Size(204, 46);
            this.btn_agregarRubro.TabIndex = 4;
            this.btn_agregarRubro.Text = "Agregar Rubro";
            this.btn_agregarRubro.UseVisualStyleBackColor = false;
            this.btn_agregarRubro.Click += new System.EventHandler(this.btn_agregarRubro_Click);
            // 
            // btn_filtros
            // 
            this.btn_filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_filtros.FlatAppearance.BorderSize = 0;
            this.btn_filtros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(155)))));
            this.btn_filtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_filtros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filtros.Image = ((System.Drawing.Image)(resources.GetObject("btn_filtros.Image")));
            this.btn_filtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtros.Location = new System.Drawing.Point(1098, 685);
            this.btn_filtros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_filtros.Name = "btn_filtros";
            this.btn_filtros.Size = new System.Drawing.Size(204, 46);
            this.btn_filtros.TabIndex = 11;
            this.btn_filtros.Text = "Filtros";
            this.btn_filtros.UseVisualStyleBackColor = false;
            this.btn_filtros.Click += new System.EventHandler(this.btn_filtros_Click);
            // 
            // frm_Locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1446, 865);
            this.Controls.Add(this.btn_filtros);
            this.Controls.Add(this.btn_agregarRubro);
            this.Controls.Add(this.btn_mostrarRubros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_Buscar);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Modi);
            this.Controls.Add(this.boton_Agregar);
            this.Controls.Add(this.boton_Nuevo);
            this.Controls.Add(this.btn_Buscar_CUIL);
            this.Controls.Add(this.cmb_Tipo_Loc);
            this.Controls.Add(this.txt_Nombre_Local);
            this.Controls.Add(this.txt_Cuil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_nombre_loc);
            this.Controls.Add(this.lb_cuil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Locales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Locales";
            this.Load += new System.EventHandler(this.frm_Locales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cuil;
        private System.Windows.Forms.Label lb_nombre_loc;
        private System.Windows.Forms.Label label10;
        private Componentes.TextBoxDeControl txt_Cuil;
        private Componentes.TextBoxDeControl txt_Nombre_Local;
        private Componentes.ComboBoxDeControl cmb_Tipo_Loc;
        private System.Windows.Forms.Button btn_Buscar_CUIL;
        private System.Windows.Forms.Button boton_Nuevo;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.Button boton_Modi;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_mostrarRubros;
        private System.Windows.Forms.Button btn_agregarRubro;
        private System.Windows.Forms.Button btn_filtros;
    }
}