namespace MENU_Compras
{
    partial class frm_MenuPrincipal
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
            this.pnl_forms = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictBx_Salir = new System.Windows.Forms.PictureBox();
            this.btn_Contable = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_RRHH = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pnl_opcCompras = new System.Windows.Forms.Panel();
            this.tTip_Salir = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBx_Salir)).BeginInit();
            this.pnl_opcCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_forms
            // 
            this.pnl_forms.AutoScroll = true;
            this.pnl_forms.BackColor = System.Drawing.Color.Transparent;
            this.pnl_forms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_forms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_forms.Location = new System.Drawing.Point(0, 84);
            this.pnl_forms.MinimumSize = new System.Drawing.Size(712, 670);
            this.pnl_forms.Name = "pnl_forms";
            this.pnl_forms.Size = new System.Drawing.Size(1364, 670);
            this.pnl_forms.TabIndex = 1;
            this.pnl_forms.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_forms_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MENU_Compras.Properties.Resources.fondoModif_02;
            this.panel1.Controls.Add(this.pictBx_Salir);
            this.panel1.Controls.Add(this.btn_Contable);
            this.panel1.Controls.Add(this.btn_Ventas);
            this.panel1.Controls.Add(this.btn_compras);
            this.panel1.Controls.Add(this.btn_RRHH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 84);
            this.panel1.TabIndex = 2;
            // 
            // pictBx_Salir
            // 
            this.pictBx_Salir.BackgroundImage = global::MENU_Compras.Properties.Resources.Salir32px;
            this.pictBx_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictBx_Salir.Location = new System.Drawing.Point(1294, 14);
            this.pictBx_Salir.Name = "pictBx_Salir";
            this.pictBx_Salir.Size = new System.Drawing.Size(41, 50);
            this.pictBx_Salir.TabIndex = 4;
            this.pictBx_Salir.TabStop = false;
            this.tTip_Salir.SetToolTip(this.pictBx_Salir, "Salir");
            this.pictBx_Salir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Contable
            // 
            this.btn_Contable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Contable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_Contable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_Contable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Contable.Location = new System.Drawing.Point(918, 12);
            this.btn_Contable.Name = "btn_Contable";
            this.btn_Contable.Size = new System.Drawing.Size(148, 52);
            this.btn_Contable.TabIndex = 3;
            this.btn_Contable.Text = "Contable";
            this.btn_Contable.UseVisualStyleBackColor = true;
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ventas.Location = new System.Drawing.Point(723, 12);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(160, 52);
            this.btn_Ventas.TabIndex = 2;
            this.btn_Ventas.Text = "Gestión Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = true;
            // 
            // btn_compras
            // 
            this.btn_compras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_compras.Location = new System.Drawing.Point(495, 12);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(194, 52);
            this.btn_compras.TabIndex = 1;
            this.btn_compras.Text = "Gestión Compras";
            this.btn_compras.UseVisualStyleBackColor = true;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_RRHH
            // 
            this.btn_RRHH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_RRHH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_RRHH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_RRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RRHH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RRHH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_RRHH.Location = new System.Drawing.Point(289, 12);
            this.btn_RRHH.Name = "btn_RRHH";
            this.btn_RRHH.Size = new System.Drawing.Size(169, 52);
            this.btn_RRHH.TabIndex = 0;
            this.btn_RRHH.Text = "Gestión de Usuarios";
            this.btn_RRHH.UseVisualStyleBackColor = true;
            this.btn_RRHH.Click += new System.EventHandler(this.btn_RRHH_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Logo.BackgroundImage = global::MENU_Compras.Properties.Resources.fondoModif_Mesa_de_trabajo_1;
            this.pnl_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(255, 110);
            this.pnl_Logo.TabIndex = 0;
            // 
            // pnl_opcCompras
            // 
            this.pnl_opcCompras.BackColor = System.Drawing.Color.Transparent;
            this.pnl_opcCompras.BackgroundImage = global::MENU_Compras.Properties.Resources.fondoModif_021;
            this.pnl_opcCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_opcCompras.Controls.Add(this.pnl_Logo);
            this.pnl_opcCompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_opcCompras.Location = new System.Drawing.Point(0, 0);
            this.pnl_opcCompras.Name = "pnl_opcCompras";
            this.pnl_opcCompras.Size = new System.Drawing.Size(255, 115);
            this.pnl_opcCompras.TabIndex = 0;
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MENU_Compras.Properties.Resources.WhatsApp_Image_2023_06_26_at_00_32_48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.pnl_forms);
            this.Controls.Add(this.pnl_opcCompras);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1070, 726);
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frm_moduloCompras_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBx_Salir)).EndInit();
            this.pnl_opcCompras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_forms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Panel pnl_opcCompras;
        private System.Windows.Forms.Button btn_Contable;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_RRHH;
        private System.Windows.Forms.PictureBox pictBx_Salir;
        private System.Windows.Forms.ToolTip tTip_Salir;
    }
}

