namespace MENU_Compras
{
    partial class Registrar_Compra
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
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.pnl_opcCompras = new System.Windows.Forms.Panel();
            this.btn_RegistrarCompras_servicios = new System.Windows.Forms.Button();
            this.btn_registCompras = new System.Windows.Forms.Button();
            this.btn_pagarServicios = new System.Windows.Forms.Button();
            this.pnl_registrarCompras = new System.Windows.Forms.Panel();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_registrarProveedores = new System.Windows.Forms.Button();
            this.btn_modificarProveedores = new System.Windows.Forms.Button();
            this.pnl_proveedores = new System.Windows.Forms.Panel();
            this.btn_articulos = new System.Windows.Forms.Button();
            this.btn_categoriasSubcat = new System.Windows.Forms.Button();
            this.btn_modificarArticulos = new System.Windows.Forms.Button();
            this.pnl_articulos = new System.Windows.Forms.Panel();
            this.btn_historicoCompras = new System.Windows.Forms.Button();
            this.pnl_opcCompras.SuspendLayout();
            this.pnl_registrarCompras.SuspendLayout();
            this.pnl_proveedores.SuspendLayout();
            this.pnl_articulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenedor.Location = new System.Drawing.Point(254, 0);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(951, 670);
            this.pnl_Contenedor.TabIndex = 15;
            this.pnl_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Contenedor_Paint);
            // 
            // pnl_opcCompras
            // 
            this.pnl_opcCompras.BackColor = System.Drawing.Color.Transparent;
            this.pnl_opcCompras.BackgroundImage = global::MENU_Compras.Properties.Resources.fondoModif_02;
            this.pnl_opcCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_opcCompras.Controls.Add(this.btn_historicoCompras);
            this.pnl_opcCompras.Controls.Add(this.pnl_articulos);
            this.pnl_opcCompras.Controls.Add(this.btn_articulos);
            this.pnl_opcCompras.Controls.Add(this.pnl_proveedores);
            this.pnl_opcCompras.Controls.Add(this.btn_proveedores);
            this.pnl_opcCompras.Controls.Add(this.pnl_registrarCompras);
            this.pnl_opcCompras.Controls.Add(this.btn_RegistrarCompras_servicios);
            this.pnl_opcCompras.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_opcCompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_opcCompras.Location = new System.Drawing.Point(0, 0);
            this.pnl_opcCompras.Name = "pnl_opcCompras";
            this.pnl_opcCompras.Size = new System.Drawing.Size(254, 670);
            this.pnl_opcCompras.TabIndex = 14;
            // 
            // btn_RegistrarCompras_servicios
            // 
            this.btn_RegistrarCompras_servicios.BackColor = System.Drawing.Color.Transparent;
            this.btn_RegistrarCompras_servicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RegistrarCompras_servicios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_RegistrarCompras_servicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_RegistrarCompras_servicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_RegistrarCompras_servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarCompras_servicios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_RegistrarCompras_servicios.Location = new System.Drawing.Point(0, 0);
            this.btn_RegistrarCompras_servicios.Name = "btn_RegistrarCompras_servicios";
            this.btn_RegistrarCompras_servicios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_RegistrarCompras_servicios.Size = new System.Drawing.Size(254, 96);
            this.btn_RegistrarCompras_servicios.TabIndex = 1;
            this.btn_RegistrarCompras_servicios.Text = "Registrar Compras\r\n               y\r\nPagos de servicios/gastos";
            this.btn_RegistrarCompras_servicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistrarCompras_servicios.UseVisualStyleBackColor = false;
            this.btn_RegistrarCompras_servicios.Click += new System.EventHandler(this.btn_RegistrarCompras_servicios_Click);
            // 
            // btn_registCompras
            // 
            this.btn_registCompras.BackColor = System.Drawing.Color.Transparent;
            this.btn_registCompras.FlatAppearance.BorderSize = 0;
            this.btn_registCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_registCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registCompras.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_registCompras.ForeColor = System.Drawing.Color.White;
            this.btn_registCompras.Location = new System.Drawing.Point(-1, 3);
            this.btn_registCompras.Name = "btn_registCompras";
            this.btn_registCompras.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_registCompras.Size = new System.Drawing.Size(254, 45);
            this.btn_registCompras.TabIndex = 0;
            this.btn_registCompras.Text = "Registrar compras";
            this.btn_registCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registCompras.UseVisualStyleBackColor = false;
            this.btn_registCompras.Click += new System.EventHandler(this.btn_registCompras_Click_1);
            this.btn_registCompras.MouseEnter += new System.EventHandler(this.btn_Todos_MouseEnter);
            this.btn_registCompras.MouseLeave += new System.EventHandler(this.btn_Todos_MouseLeave);
            // 
            // btn_pagarServicios
            // 
            this.btn_pagarServicios.BackColor = System.Drawing.Color.Transparent;
            this.btn_pagarServicios.FlatAppearance.BorderSize = 0;
            this.btn_pagarServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_pagarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagarServicios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_pagarServicios.ForeColor = System.Drawing.Color.White;
            this.btn_pagarServicios.Location = new System.Drawing.Point(-1, 51);
            this.btn_pagarServicios.Name = "btn_pagarServicios";
            this.btn_pagarServicios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_pagarServicios.Size = new System.Drawing.Size(254, 45);
            this.btn_pagarServicios.TabIndex = 1;
            this.btn_pagarServicios.Text = "Pagar servicios/gastos";
            this.btn_pagarServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagarServicios.UseVisualStyleBackColor = false;
            this.btn_pagarServicios.Click += new System.EventHandler(this.btn_pagarServicios_Click_1);
            this.btn_pagarServicios.MouseEnter += new System.EventHandler(this.btn_Todos_MouseEnter);
            this.btn_pagarServicios.MouseLeave += new System.EventHandler(this.btn_Todos_MouseLeave);
            // 
            // pnl_registrarCompras
            // 
            this.pnl_registrarCompras.BackColor = System.Drawing.Color.Transparent;
            this.pnl_registrarCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_registrarCompras.Controls.Add(this.btn_pagarServicios);
            this.pnl_registrarCompras.Controls.Add(this.btn_registCompras);
            this.pnl_registrarCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_registrarCompras.Location = new System.Drawing.Point(0, 96);
            this.pnl_registrarCompras.Name = "pnl_registrarCompras";
            this.pnl_registrarCompras.Size = new System.Drawing.Size(254, 101);
            this.pnl_registrarCompras.TabIndex = 2;
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_proveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_proveedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_proveedores.Location = new System.Drawing.Point(0, 197);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_proveedores.Size = new System.Drawing.Size(254, 44);
            this.btn_proveedores.TabIndex = 3;
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedores.UseVisualStyleBackColor = false;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // btn_registrarProveedores
            // 
            this.btn_registrarProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrarProveedores.FlatAppearance.BorderSize = 0;
            this.btn_registrarProveedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_registrarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_registrarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarProveedores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_registrarProveedores.ForeColor = System.Drawing.Color.White;
            this.btn_registrarProveedores.Location = new System.Drawing.Point(0, 3);
            this.btn_registrarProveedores.Name = "btn_registrarProveedores";
            this.btn_registrarProveedores.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_registrarProveedores.Size = new System.Drawing.Size(254, 45);
            this.btn_registrarProveedores.TabIndex = 0;
            this.btn_registrarProveedores.Text = "Registrar proveedores";
            this.btn_registrarProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrarProveedores.UseVisualStyleBackColor = false;
            this.btn_registrarProveedores.Click += new System.EventHandler(this.btn_registrarProveedores_Click_1);
            this.btn_registrarProveedores.MouseEnter += new System.EventHandler(this.btn_Todos_MouseEnter);
            this.btn_registrarProveedores.MouseLeave += new System.EventHandler(this.btn_Todos_MouseLeave);
            // 
            // btn_modificarProveedores
            // 
            this.btn_modificarProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificarProveedores.FlatAppearance.BorderSize = 0;
            this.btn_modificarProveedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_modificarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_modificarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarProveedores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_modificarProveedores.ForeColor = System.Drawing.Color.White;
            this.btn_modificarProveedores.Location = new System.Drawing.Point(0, 52);
            this.btn_modificarProveedores.Name = "btn_modificarProveedores";
            this.btn_modificarProveedores.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_modificarProveedores.Size = new System.Drawing.Size(254, 45);
            this.btn_modificarProveedores.TabIndex = 1;
            this.btn_modificarProveedores.Text = "Modificar proveedores";
            this.btn_modificarProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificarProveedores.UseVisualStyleBackColor = false;
            this.btn_modificarProveedores.Click += new System.EventHandler(this.btn_modificarProveedores_Click_1);
            this.btn_modificarProveedores.MouseEnter += new System.EventHandler(this.btn_Todos_MouseEnter);
            this.btn_modificarProveedores.MouseLeave += new System.EventHandler(this.btn_Todos_MouseLeave);
            // 
            // pnl_proveedores
            // 
            this.pnl_proveedores.BackColor = System.Drawing.Color.Transparent;
            this.pnl_proveedores.Controls.Add(this.btn_modificarProveedores);
            this.pnl_proveedores.Controls.Add(this.btn_registrarProveedores);
            this.pnl_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_proveedores.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_proveedores.Location = new System.Drawing.Point(0, 241);
            this.pnl_proveedores.Name = "pnl_proveedores";
            this.pnl_proveedores.Size = new System.Drawing.Size(254, 100);
            this.pnl_proveedores.TabIndex = 4;
            // 
            // btn_articulos
            // 
            this.btn_articulos.BackColor = System.Drawing.Color.Transparent;
            this.btn_articulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_articulos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_articulos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_articulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_articulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_articulos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_articulos.Location = new System.Drawing.Point(0, 341);
            this.btn_articulos.Name = "btn_articulos";
            this.btn_articulos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_articulos.Size = new System.Drawing.Size(254, 44);
            this.btn_articulos.TabIndex = 5;
            this.btn_articulos.Text = "Articulos";
            this.btn_articulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_articulos.UseVisualStyleBackColor = false;
            this.btn_articulos.Click += new System.EventHandler(this.btn_articulos_Click);
            // 
            // btn_categoriasSubcat
            // 
            this.btn_categoriasSubcat.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriasSubcat.FlatAppearance.BorderSize = 0;
            this.btn_categoriasSubcat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_categoriasSubcat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_categoriasSubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categoriasSubcat.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_categoriasSubcat.ForeColor = System.Drawing.Color.White;
            this.btn_categoriasSubcat.Location = new System.Drawing.Point(0, 6);
            this.btn_categoriasSubcat.Name = "btn_categoriasSubcat";
            this.btn_categoriasSubcat.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_categoriasSubcat.Size = new System.Drawing.Size(254, 76);
            this.btn_categoriasSubcat.TabIndex = 0;
            this.btn_categoriasSubcat.Text = "Agregar Categorias \r\n             y\r\n    Subcategorias";
            this.btn_categoriasSubcat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriasSubcat.UseVisualStyleBackColor = false;
            this.btn_categoriasSubcat.Click += new System.EventHandler(this.btn_categoriasSubcat_Click_1);
            this.btn_categoriasSubcat.MouseEnter += new System.EventHandler(this.btn_Todos_MouseEnter);
            this.btn_categoriasSubcat.MouseLeave += new System.EventHandler(this.btn_Todos_MouseLeave);
            // 
            // btn_modificarArticulos
            // 
            this.btn_modificarArticulos.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificarArticulos.FlatAppearance.BorderSize = 0;
            this.btn_modificarArticulos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_modificarArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_modificarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarArticulos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_modificarArticulos.ForeColor = System.Drawing.Color.White;
            this.btn_modificarArticulos.Location = new System.Drawing.Point(0, 88);
            this.btn_modificarArticulos.Name = "btn_modificarArticulos";
            this.btn_modificarArticulos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_modificarArticulos.Size = new System.Drawing.Size(254, 40);
            this.btn_modificarArticulos.TabIndex = 1;
            this.btn_modificarArticulos.Text = "Modificar articulos";
            this.btn_modificarArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificarArticulos.UseVisualStyleBackColor = false;
            this.btn_modificarArticulos.Click += new System.EventHandler(this.btn_modificarArticulos_Click_1);
            this.btn_modificarArticulos.MouseEnter += new System.EventHandler(this.btn_Todos_MouseEnter);
            this.btn_modificarArticulos.MouseLeave += new System.EventHandler(this.btn_Todos_MouseLeave);
            // 
            // pnl_articulos
            // 
            this.pnl_articulos.BackColor = System.Drawing.Color.Transparent;
            this.pnl_articulos.Controls.Add(this.btn_modificarArticulos);
            this.pnl_articulos.Controls.Add(this.btn_categoriasSubcat);
            this.pnl_articulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_articulos.Location = new System.Drawing.Point(0, 385);
            this.pnl_articulos.Name = "pnl_articulos";
            this.pnl_articulos.Size = new System.Drawing.Size(254, 134);
            this.pnl_articulos.TabIndex = 6;
            // 
            // btn_historicoCompras
            // 
            this.btn_historicoCompras.BackColor = System.Drawing.Color.Transparent;
            this.btn_historicoCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_historicoCompras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_historicoCompras.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btn_historicoCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_historicoCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_historicoCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historicoCompras.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_historicoCompras.Location = new System.Drawing.Point(0, 519);
            this.btn_historicoCompras.Name = "btn_historicoCompras";
            this.btn_historicoCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_historicoCompras.Size = new System.Drawing.Size(254, 44);
            this.btn_historicoCompras.TabIndex = 7;
            this.btn_historicoCompras.Text = "Historico de compras";
            this.btn_historicoCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historicoCompras.UseVisualStyleBackColor = false;
            // 
            // Registrar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 670);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.pnl_opcCompras);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar_Compra";
            this.Text = "Registrar_Compras";
            this.pnl_opcCompras.ResumeLayout(false);
            this.pnl_registrarCompras.ResumeLayout(false);
            this.pnl_proveedores.ResumeLayout(false);
            this.pnl_articulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_opcCompras;
        private System.Windows.Forms.Panel pnl_Contenedor;
        private System.Windows.Forms.Button btn_historicoCompras;
        private System.Windows.Forms.Panel pnl_articulos;
        private System.Windows.Forms.Button btn_modificarArticulos;
        private System.Windows.Forms.Button btn_categoriasSubcat;
        private System.Windows.Forms.Button btn_articulos;
        private System.Windows.Forms.Panel pnl_proveedores;
        private System.Windows.Forms.Button btn_modificarProveedores;
        private System.Windows.Forms.Button btn_registrarProveedores;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Panel pnl_registrarCompras;
        private System.Windows.Forms.Button btn_pagarServicios;
        private System.Windows.Forms.Button btn_registCompras;
        private System.Windows.Forms.Button btn_RegistrarCompras_servicios;
    }
}