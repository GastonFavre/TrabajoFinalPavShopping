namespace ShoppingBuyAll.Formularios
{
    partial class frm_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Productos));
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.lbl_CodProducto = new System.Windows.Forms.Label();
            this.txt_PrecioProducto = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_NombreProducto = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.txt_CodigoProducto = new ShoppingBuyAll.Componentes.TextBoxDeControl();
            this.dataGridBusqueda = new System.Windows.Forms.DataGridView();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonPrecio = new System.Windows.Forms.RadioButton();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.btn_filtros = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarPrecio = new System.Windows.Forms.Button();
            this.btn_BuscarCod = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Modi = new System.Windows.Forms.Button();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.boton_Nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Precio.Location = new System.Drawing.Point(129, 233);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(59, 20);
            this.lbl_Precio.TabIndex = 61;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Productos.Location = new System.Drawing.Point(129, 103);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(124, 24);
            this.lbl_Productos.TabIndex = 60;
            this.lbl_Productos.Text = "PRODUCTO";
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(129, 198);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(71, 20);
            this.lbl_NombreProducto.TabIndex = 59;
            this.lbl_NombreProducto.Text = "Nombre";
            // 
            // lbl_CodProducto
            // 
            this.lbl_CodProducto.AutoSize = true;
            this.lbl_CodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CodProducto.Location = new System.Drawing.Point(129, 163);
            this.lbl_CodProducto.Name = "lbl_CodProducto";
            this.lbl_CodProducto.Size = new System.Drawing.Size(65, 20);
            this.lbl_CodProducto.TabIndex = 58;
            this.lbl_CodProducto.Text = "Codigo";
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto._campo = "precio";
            this.txt_PrecioProducto._mensaje_error = "No se ingreso precio";
            this.txt_PrecioProducto._nombre_tabla = "Productos";
            this.txt_PrecioProducto._pk = false;
            this.txt_PrecioProducto._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_PrecioProducto._validable = true;
            this.txt_PrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioProducto.Location = new System.Drawing.Point(210, 233);
            this.txt_PrecioProducto.MaxLength = 5;
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(98, 26);
            this.txt_PrecioProducto.TabIndex = 64;
            this.txt_PrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto._campo = "nombre";
            this.txt_NombreProducto._mensaje_error = "No se ingreso nombre";
            this.txt_NombreProducto._nombre_tabla = "Productos";
            this.txt_NombreProducto._pk = false;
            this.txt_NombreProducto._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.texto;
            this.txt_NombreProducto._validable = true;
            this.txt_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProducto.Location = new System.Drawing.Point(210, 198);
            this.txt_NombreProducto.MaxLength = 20;
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(184, 26);
            this.txt_NombreProducto.TabIndex = 63;
            this.txt_NombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Letra_KeyPress);
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto._campo = "cod_prod";
            this.txt_CodigoProducto._mensaje_error = "No se ingreso codigo";
            this.txt_CodigoProducto._nombre_tabla = "Productos";
            this.txt_CodigoProducto._pk = true;
            this.txt_CodigoProducto._tipo = ShoppingBuyAll.Componentes.TextBoxDeControl.Tipo_dato.numero;
            this.txt_CodigoProducto._validable = true;
            this.txt_CodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoProducto.Location = new System.Drawing.Point(210, 163);
            this.txt_CodigoProducto.MaxLength = 10;
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(184, 26);
            this.txt_CodigoProducto.TabIndex = 62;
            this.txt_CodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // dataGridBusqueda
            // 
            this.dataGridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusqueda.Location = new System.Drawing.Point(455, 51);
            this.dataGridBusqueda.Name = "dataGridBusqueda";
            this.dataGridBusqueda.Size = new System.Drawing.Size(424, 249);
            this.dataGridBusqueda.TabIndex = 71;
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonCodigo.Location = new System.Drawing.Point(18, 34);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(103, 17);
            this.radioButtonCodigo.TabIndex = 72;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "POR CODIGO";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // radioButtonPrecio
            // 
            this.radioButtonPrecio.AutoSize = true;
            this.radioButtonPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonPrecio.Location = new System.Drawing.Point(18, 57);
            this.radioButtonPrecio.Name = "radioButtonPrecio";
            this.radioButtonPrecio.Size = new System.Drawing.Size(101, 17);
            this.radioButtonPrecio.TabIndex = 73;
            this.radioButtonPrecio.TabStop = true;
            this.radioButtonPrecio.Text = "POR PRECIO";
            this.radioButtonPrecio.UseVisualStyleBackColor = true;
            this.radioButtonPrecio.CheckedChanged += new System.EventHandler(this.radioButtonPrecio_CheckedChanged);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.radioButtonNombre);
            this.groupBoxFiltros.Controls.Add(this.radioButtonCodigo);
            this.groupBoxFiltros.Controls.Add(this.radioButtonPrecio);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFiltros.Location = new System.Drawing.Point(715, 354);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(161, 121);
            this.groupBoxFiltros.TabIndex = 74;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "FILTROS";
            this.groupBoxFiltros.Visible = false;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonNombre.Location = new System.Drawing.Point(18, 79);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(108, 17);
            this.radioButtonNombre.TabIndex = 74;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "POR NOMBRE";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.CheckedChanged += new System.EventHandler(this.radioButtonNombre_CheckedChanged);
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
            this.btn_filtros.Location = new System.Drawing.Point(379, 375);
            this.btn_filtros.Name = "btn_filtros";
            this.btn_filtros.Size = new System.Drawing.Size(136, 30);
            this.btn_filtros.TabIndex = 77;
            this.btn_filtros.Text = "Filtros";
            this.btn_filtros.UseVisualStyleBackColor = false;
            this.btn_filtros.Click += new System.EventHandler(this.btn_filtros_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarNombre.BackgroundImage")));
            this.btnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarNombre.Location = new System.Drawing.Point(400, 196);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(26, 26);
            this.btnBuscarNombre.TabIndex = 76;
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Visible = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnBuscarPrecio
            // 
            this.btnBuscarPrecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPrecio.BackgroundImage")));
            this.btnBuscarPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPrecio.Location = new System.Drawing.Point(314, 234);
            this.btnBuscarPrecio.Name = "btnBuscarPrecio";
            this.btnBuscarPrecio.Size = new System.Drawing.Size(26, 26);
            this.btnBuscarPrecio.TabIndex = 75;
            this.btnBuscarPrecio.UseVisualStyleBackColor = true;
            this.btnBuscarPrecio.Visible = false;
            this.btnBuscarPrecio.Click += new System.EventHandler(this.btnBuscarPrecio_Click);
            // 
            // btn_BuscarCod
            // 
            this.btn_BuscarCod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarCod.BackgroundImage")));
            this.btn_BuscarCod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarCod.Location = new System.Drawing.Point(400, 164);
            this.btn_BuscarCod.Name = "btn_BuscarCod";
            this.btn_BuscarCod.Size = new System.Drawing.Size(26, 26);
            this.btn_BuscarCod.TabIndex = 70;
            this.btn_BuscarCod.UseVisualStyleBackColor = true;
            this.btn_BuscarCod.Visible = false;
            this.btn_BuscarCod.Click += new System.EventHandler(this.btn_BuscarCod_Click);
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
            this.boton_Buscar.Location = new System.Drawing.Point(715, 318);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(136, 30);
            this.boton_Buscar.TabIndex = 69;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = false;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
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
            this.boton_Eliminar.Location = new System.Drawing.Point(531, 318);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(136, 30);
            this.boton_Eliminar.TabIndex = 68;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = false;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
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
            this.boton_Modi.Location = new System.Drawing.Point(379, 318);
            this.boton_Modi.Name = "boton_Modi";
            this.boton_Modi.Size = new System.Drawing.Size(146, 30);
            this.boton_Modi.TabIndex = 67;
            this.boton_Modi.Text = "Modificar";
            this.boton_Modi.UseVisualStyleBackColor = false;
            this.boton_Modi.Click += new System.EventHandler(this.boton_Modi_Click);
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
            this.boton_Agregar.Location = new System.Drawing.Point(212, 318);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(146, 30);
            this.boton_Agregar.TabIndex = 66;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = false;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
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
            this.boton_Nuevo.Location = new System.Drawing.Point(62, 318);
            this.boton_Nuevo.Name = "boton_Nuevo";
            this.boton_Nuevo.Size = new System.Drawing.Size(136, 30);
            this.boton_Nuevo.TabIndex = 65;
            this.boton_Nuevo.Text = "Nuevo";
            this.boton_Nuevo.UseVisualStyleBackColor = false;
            this.boton_Nuevo.Click += new System.EventHandler(this.boton_Nuevo_Click);
            // 
            // frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(924, 484);
            this.Controls.Add(this.btn_filtros);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.btnBuscarPrecio);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.dataGridBusqueda);
            this.Controls.Add(this.btn_BuscarCod);
            this.Controls.Add(this.boton_Buscar);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Modi);
            this.Controls.Add(this.boton_Agregar);
            this.Controls.Add(this.boton_Nuevo);
            this.Controls.Add(this.txt_PrecioProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_CodigoProducto);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.lbl_NombreProducto);
            this.Controls.Add(this.lbl_CodProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Productos";
            this.Load += new System.EventHandler(this.frm_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_BuscarCod;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Modi;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.Button boton_Nuevo;
        private Componentes.TextBoxDeControl txt_PrecioProducto;
        private Componentes.TextBoxDeControl txt_NombreProducto;
        private Componentes.TextBoxDeControl txt_CodigoProducto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.Label lbl_CodProducto;
        private System.Windows.Forms.DataGridView dataGridBusqueda;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.RadioButton radioButtonPrecio;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Button btnBuscarPrecio;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btn_filtros;
    }
}