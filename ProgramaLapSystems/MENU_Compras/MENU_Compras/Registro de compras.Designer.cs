namespace MENU_Compras
{
    partial class frm_Registro_de_compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_agregarProveedor = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_ingrsarDescuento = new System.Windows.Forms.Label();
            this.lbl_ingresarSubtotal = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_ingresarProveedor = new System.Windows.Forms.Label();
            this.cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.btn_registrarCompra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_articulos = new System.Windows.Forms.DataGridView();
            this.cod_articulo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Subcategoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_por = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarProveedor
            // 
            this.btn_agregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.btn_agregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregarProveedor.Location = new System.Drawing.Point(279, 111);
            this.btn_agregarProveedor.Name = "btn_agregarProveedor";
            this.btn_agregarProveedor.Size = new System.Drawing.Size(192, 35);
            this.btn_agregarProveedor.TabIndex = 27;
            this.btn_agregarProveedor.Text = "Agregar nuevo proveedor";
            this.btn_agregarProveedor.UseVisualStyleBackColor = false;
            this.btn_agregarProveedor.Click += new System.EventHandler(this.btn_agregarProveedor_Click);
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(403, 346);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 27);
            this.txt_total.TabIndex = 26;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(172, 350);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(225, 19);
            this.lbl_total.TabIndex = 25;
            this.lbl_total.Text = "El Total de la compra es de: ";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_fecha.Location = new System.Drawing.Point(919, 4);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(67, 21);
            this.lbl_fecha.TabIndex = 24;
            this.lbl_fecha.Text = "Fecha: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::MENU_Compras.Properties.Resources.usuarioss_Mesa_de_trabajo_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(12, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 63);
            this.panel2.TabIndex = 23;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_usuario.Location = new System.Drawing.Point(8, 539);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 21);
            this.lbl_usuario.TabIndex = 22;
            this.lbl_usuario.Text = "Usuario: ";
            // 
            // lbl_ingrsarDescuento
            // 
            this.lbl_ingrsarDescuento.AutoSize = true;
            this.lbl_ingrsarDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingrsarDescuento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_ingrsarDescuento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ingrsarDescuento.Location = new System.Drawing.Point(734, 95);
            this.lbl_ingrsarDescuento.Name = "lbl_ingrsarDescuento";
            this.lbl_ingrsarDescuento.Size = new System.Drawing.Size(162, 21);
            this.lbl_ingrsarDescuento.TabIndex = 21;
            this.lbl_ingrsarDescuento.Text = "Ingresar Descuento";
            // 
            // lbl_ingresarSubtotal
            // 
            this.lbl_ingresarSubtotal.AutoSize = true;
            this.lbl_ingresarSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingresarSubtotal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_ingresarSubtotal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ingresarSubtotal.Location = new System.Drawing.Point(734, 33);
            this.lbl_ingresarSubtotal.Name = "lbl_ingresarSubtotal";
            this.lbl_ingresarSubtotal.Size = new System.Drawing.Size(142, 21);
            this.lbl_ingresarSubtotal.TabIndex = 20;
            this.lbl_ingresarSubtotal.Text = "Ingresar subtotal";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txt_descuento.Location = new System.Drawing.Point(738, 121);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(100, 25);
            this.txt_descuento.TabIndex = 19;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txt_subtotal.Location = new System.Drawing.Point(738, 57);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 25);
            this.txt_subtotal.TabIndex = 18;
            // 
            // lbl_ingresarProveedor
            // 
            this.lbl_ingresarProveedor.AutoSize = true;
            this.lbl_ingresarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingresarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresarProveedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ingresarProveedor.Location = new System.Drawing.Point(194, 23);
            this.lbl_ingresarProveedor.Name = "lbl_ingresarProveedor";
            this.lbl_ingresarProveedor.Size = new System.Drawing.Size(277, 21);
            this.lbl_ingresarProveedor.TabIndex = 17;
            this.lbl_ingresarProveedor.Text = "Ingrese o seleccione un proveedor";
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(198, 47);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(273, 26);
            this.cmb_proveedores.TabIndex = 16;
            this.cmb_proveedores.SelectedIndexChanged += new System.EventHandler(this.cmb_proveedores_SelectedIndexChanged);
            // 
            // btn_registrarCompra
            // 
            this.btn_registrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.btn_registrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarCompra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_registrarCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrarCompra.Location = new System.Drawing.Point(612, 341);
            this.btn_registrarCompra.Name = "btn_registrarCompra";
            this.btn_registrarCompra.Size = new System.Drawing.Size(153, 32);
            this.btn_registrarCompra.TabIndex = 15;
            this.btn_registrarCompra.Text = "Registrar compra";
            this.btn_registrarCompra.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dtgv_articulos);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.btn_registrarCompra);
            this.panel1.Location = new System.Drawing.Point(198, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 389);
            this.panel1.TabIndex = 14;
            // 
            // dtgv_articulos
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.dtgv_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_articulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_articulo,
            this.Column1,
            this.Categoria,
            this.Subcategoria,
            this.Cantidad,
            this.Cantidad_por,
            this.Costo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_articulos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_articulos.Location = new System.Drawing.Point(5, 3);
            this.dtgv_articulos.Name = "dtgv_articulos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_articulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_articulos.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dtgv_articulos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgv_articulos.Size = new System.Drawing.Size(760, 309);
            this.dtgv_articulos.TabIndex = 0;
            // 
            // cod_articulo
            // 
            this.cod_articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_articulo.HeaderText = "Codigo de artículo";
            this.cod_articulo.Name = "cod_articulo";
            this.cod_articulo.Width = 124;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripcion";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Subcategoria
            // 
            this.Subcategoria.HeaderText = "Subcategoria";
            this.Subcategoria.Name = "Subcategoria";
            this.Subcategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subcategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Cantidad_por
            // 
            this.Cantidad_por.HeaderText = "Cantidad por:";
            this.Cantidad_por.Name = "Cantidad_por";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // frm_Registro_de_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MENU_Compras.Properties.Resources.WhatsApp_Image_2023_06_26_at_01_09_15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 581);
            this.Controls.Add(this.btn_agregarProveedor);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_ingrsarDescuento);
            this.Controls.Add(this.lbl_ingresarSubtotal);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.lbl_ingresarProveedor);
            this.Controls.Add(this.cmb_proveedores);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "frm_Registro_de_compras";
            this.Text = "Registro_de_compras";
            this.Load += new System.EventHandler(this.frm_Registro_de_compras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarProveedor;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_ingrsarDescuento;
        private System.Windows.Forms.Label lbl_ingresarSubtotal;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label lbl_ingresarProveedor;
        private System.Windows.Forms.ComboBox cmb_proveedores;
        private System.Windows.Forms.Button btn_registrarCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_articulos;
        private System.Windows.Forms.DataGridViewComboBoxColumn cod_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewComboBoxColumn Subcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cantidad_por;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;

    }
}