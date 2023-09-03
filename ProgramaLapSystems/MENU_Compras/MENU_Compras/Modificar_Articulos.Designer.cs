namespace MENU_Compras
{
    partial class Modificar_Articulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_modificarArticulos = new System.Windows.Forms.DataGridView();
            this.Cod_articulo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_Cmb_Categoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_aceptarModificacionesArt = new System.Windows.Forms.Button();
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_modificarArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_modificarArticulos
            // 
            this.dtg_modificarArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_modificarArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_modificarArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.dtg_modificarArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_modificarArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_modificarArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_modificarArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_modificarArticulos.ColumnHeadersHeight = 40;
            this.dtg_modificarArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_articulo,
            this.Costo,
            this.dtg_Cmb_Categoria,
            this.dtg});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_modificarArticulos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_modificarArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_modificarArticulos.EnableHeadersVisualStyles = false;
            this.dtg_modificarArticulos.Location = new System.Drawing.Point(135, 180);
            this.dtg_modificarArticulos.Name = "dtg_modificarArticulos";
            this.dtg_modificarArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_modificarArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_modificarArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            this.dtg_modificarArticulos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_modificarArticulos.Size = new System.Drawing.Size(520, 169);
            this.dtg_modificarArticulos.TabIndex = 1;
            // 
            // Cod_articulo
            // 
            this.Cod_articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cod_articulo.HeaderText = "Codigo de Articulo";
            this.Cod_articulo.Name = "Cod_articulo";
            this.Cod_articulo.Width = 123;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Width = 71;
            // 
            // dtg_Cmb_Categoria
            // 
            this.dtg_Cmb_Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtg_Cmb_Categoria.HeaderText = "Categoria";
            this.dtg_Cmb_Categoria.Name = "dtg_Cmb_Categoria";
            this.dtg_Cmb_Categoria.Width = 80;
            // 
            // dtg
            // 
            this.dtg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtg.HeaderText = "Subcategoria";
            this.dtg.Name = "dtg";
            // 
            // btn_aceptarModificacionesArt
            // 
            this.btn_aceptarModificacionesArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.btn_aceptarModificacionesArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarModificacionesArt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarModificacionesArt.ForeColor = System.Drawing.Color.Transparent;
            this.btn_aceptarModificacionesArt.Location = new System.Drawing.Point(438, 355);
            this.btn_aceptarModificacionesArt.Name = "btn_aceptarModificacionesArt";
            this.btn_aceptarModificacionesArt.Size = new System.Drawing.Size(123, 59);
            this.btn_aceptarModificacionesArt.TabIndex = 2;
            this.btn_aceptarModificacionesArt.Text = "Aceptar Modificaciones";
            this.btn_aceptarModificacionesArt.UseVisualStyleBackColor = false;
           
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.pnl_usuario.BackgroundImage = global::MENU_Compras.Properties.Resources.usuario1;
            this.pnl_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_usuario.Location = new System.Drawing.Point(16, 324);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(70, 66);
            this.pnl_usuario.TabIndex = 3;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_usuario.Location = new System.Drawing.Point(12, 393);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 21);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "Usuario: ";
            // 
            // Modificar_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MENU_Compras.Properties.Resources.fondo_Mesa_de_trabajo_1;
            this.ClientSize = new System.Drawing.Size(709, 438);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pnl_usuario);
            this.Controls.Add(this.btn_aceptarModificacionesArt);
            this.Controls.Add(this.dtg_modificarArticulos);
            this.Name = "Modificar_Articulos";
            this.Text = "Modificar_Articulos";
            this.Load += new System.EventHandler(this.Modificar_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_modificarArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_modificarArticulos;
        private System.Windows.Forms.Button btn_aceptarModificacionesArt;
        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cod_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtg_Cmb_Categoria;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtg;
    }
}