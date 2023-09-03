namespace MENU_Compras
{
    partial class frm_Categorias_subcategorias
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
            this.cmb_categorias = new System.Windows.Forms.ComboBox();
            this.cmb_subcategorias = new System.Windows.Forms.ComboBox();
            this.btn_agregarCategorias = new System.Windows.Forms.Button();
            this.lbl_categorias = new System.Windows.Forms.Label();
            this.lbl_subcategorias = new System.Windows.Forms.Label();
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_categorias
            // 
            this.cmb_categorias.FormattingEnabled = true;
            this.cmb_categorias.Location = new System.Drawing.Point(13, 136);
            this.cmb_categorias.Name = "cmb_categorias";
            this.cmb_categorias.Size = new System.Drawing.Size(283, 21);
            this.cmb_categorias.TabIndex = 0;
            this.cmb_categorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_subcategorias
            // 
            this.cmb_subcategorias.FormattingEnabled = true;
            this.cmb_subcategorias.Location = new System.Drawing.Point(342, 136);
            this.cmb_subcategorias.Name = "cmb_subcategorias";
            this.cmb_subcategorias.Size = new System.Drawing.Size(280, 21);
            this.cmb_subcategorias.TabIndex = 1;
            // 
            // btn_agregarCategorias
            // 
            this.btn_agregarCategorias.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_agregarCategorias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_agregarCategorias.Location = new System.Drawing.Point(526, 294);
            this.btn_agregarCategorias.Name = "btn_agregarCategorias";
            this.btn_agregarCategorias.Size = new System.Drawing.Size(96, 44);
            this.btn_agregarCategorias.TabIndex = 2;
            this.btn_agregarCategorias.Text = "Agregar";
            this.btn_agregarCategorias.UseVisualStyleBackColor = true;
            // 
            // lbl_categorias
            // 
            this.lbl_categorias.AutoSize = true;
            this.lbl_categorias.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_categorias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_categorias.Location = new System.Drawing.Point(12, 106);
            this.lbl_categorias.Name = "lbl_categorias";
            this.lbl_categorias.Size = new System.Drawing.Size(284, 21);
            this.lbl_categorias.TabIndex = 3;
            this.lbl_categorias.Text = "Seleccione o ingrese una categoria";
            // 
            // lbl_subcategorias
            // 
            this.lbl_subcategorias.AutoSize = true;
            this.lbl_subcategorias.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_subcategorias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_subcategorias.Location = new System.Drawing.Point(338, 106);
            this.lbl_subcategorias.Name = "lbl_subcategorias";
            this.lbl_subcategorias.Size = new System.Drawing.Size(284, 21);
            this.lbl_subcategorias.TabIndex = 4;
            this.lbl_subcategorias.Text = "Seleccione o ingrese una categoria";
            this.lbl_subcategorias.Click += new System.EventHandler(this.lbl_subcategorias_Click);
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.pnl_usuario.BackgroundImage = global::MENU_Compras.Properties.Resources.usuarioss_Mesa_de_trabajo_1;
            this.pnl_usuario.Location = new System.Drawing.Point(5, 197);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(161, 166);
            this.pnl_usuario.TabIndex = 6;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_usuario.Location = new System.Drawing.Point(9, 376);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 21);
            this.lbl_usuario.TabIndex = 7;
            this.lbl_usuario.Text = "Usuario: ";
            // 
            // frm_Categorias_subcategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::MENU_Compras.Properties.Resources.fondo_Mesa_de_trabajo_1;
            this.ClientSize = new System.Drawing.Size(987, 534);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pnl_usuario);
            this.Controls.Add(this.lbl_subcategorias);
            this.Controls.Add(this.lbl_categorias);
            this.Controls.Add(this.btn_agregarCategorias);
            this.Controls.Add(this.cmb_subcategorias);
            this.Controls.Add(this.cmb_categorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Categorias_subcategorias";
            this.Text = "Categorias_subcategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_categorias;
        private System.Windows.Forms.ComboBox cmb_subcategorias;
        private System.Windows.Forms.Button btn_agregarCategorias;
        private System.Windows.Forms.Label lbl_categorias;
        private System.Windows.Forms.Label lbl_subcategorias;
        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.Label lbl_usuario;
    }
}