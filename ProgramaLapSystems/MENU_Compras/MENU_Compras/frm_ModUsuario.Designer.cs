namespace MENU_Compras
{
    partial class frm_ModUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_correoactualMod = new System.Windows.Forms.TextBox();
            this.txt_celularactualMod = new System.Windows.Forms.TextBox();
            this.txt_apellidoactualMod = new System.Windows.Forms.TextBox();
            this.txt_nombreactualMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_correonuevoMod = new System.Windows.Forms.TextBox();
            this.txt_celularnuevoMod = new System.Windows.Forms.TextBox();
            this.txt_apellidonuevoMod = new System.Windows.Forms.TextBox();
            this.txt_nombrenuevoMod = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_modificarusuarioaceptar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ActivarMod = new System.Windows.Forms.Button();
            this.txt_estadousuarioMod = new System.Windows.Forms.TextBox();
            this.cmb_cuilbuscarMod = new System.Windows.Forms.ComboBox();
            this.txt_nombreUsunuevoMod = new System.Windows.Forms.TextBox();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.txt_nombreUsuactualMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cuil del usuario a modificar:";
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.BackColor = System.Drawing.Color.White;
            this.btn_CrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_CrearUsuario.ForeColor = System.Drawing.Color.Black;
            this.btn_CrearUsuario.Location = new System.Drawing.Point(372, 21);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(100, 35);
            this.btn_CrearUsuario.TabIndex = 53;
            this.btn_CrearUsuario.Text = "Buscar";
            this.btn_CrearUsuario.UseVisualStyleBackColor = false;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_correoactualMod);
            this.groupBox1.Controls.Add(this.txt_celularactualMod);
            this.groupBox1.Controls.Add(this.txt_nombreUsuactualMod);
            this.groupBox1.Controls.Add(this.txt_apellidoactualMod);
            this.groupBox1.Controls.Add(this.txt_nombreactualMod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 498);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos actuales del usuario:";
            // 
            // txt_correoactualMod
            // 
            this.txt_correoactualMod.Enabled = false;
            this.txt_correoactualMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correoactualMod.Location = new System.Drawing.Point(54, 202);
            this.txt_correoactualMod.Name = "txt_correoactualMod";
            this.txt_correoactualMod.ReadOnly = true;
            this.txt_correoactualMod.Size = new System.Drawing.Size(354, 21);
            this.txt_correoactualMod.TabIndex = 64;
            // 
            // txt_celularactualMod
            // 
            this.txt_celularactualMod.Enabled = false;
            this.txt_celularactualMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celularactualMod.Location = new System.Drawing.Point(54, 278);
            this.txt_celularactualMod.Name = "txt_celularactualMod";
            this.txt_celularactualMod.ReadOnly = true;
            this.txt_celularactualMod.Size = new System.Drawing.Size(354, 21);
            this.txt_celularactualMod.TabIndex = 63;
            // 
            // txt_apellidoactualMod
            // 
            this.txt_apellidoactualMod.Enabled = false;
            this.txt_apellidoactualMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoactualMod.Location = new System.Drawing.Point(54, 126);
            this.txt_apellidoactualMod.Name = "txt_apellidoactualMod";
            this.txt_apellidoactualMod.ReadOnly = true;
            this.txt_apellidoactualMod.Size = new System.Drawing.Size(354, 21);
            this.txt_apellidoactualMod.TabIndex = 59;
            // 
            // txt_nombreactualMod
            // 
            this.txt_nombreactualMod.Enabled = false;
            this.txt_nombreactualMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreactualMod.Location = new System.Drawing.Point(54, 50);
            this.txt_nombreactualMod.Name = "txt_nombreactualMod";
            this.txt_nombreactualMod.ReadOnly = true;
            this.txt_nombreactualMod.Size = new System.Drawing.Size(354, 21);
            this.txt_nombreactualMod.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(50, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Correo electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(50, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Celular:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(50, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Apellido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(50, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_correonuevoMod);
            this.groupBox2.Controls.Add(this.txt_celularnuevoMod);
            this.groupBox2.Controls.Add(this.txt_nombreUsunuevoMod);
            this.groupBox2.Controls.Add(this.txt_apellidonuevoMod);
            this.groupBox2.Controls.Add(this.txt_nombrenuevoMod);
            this.groupBox2.Controls.Add(this.lbl_correo);
            this.groupBox2.Controls.Add(this.lbl_celular);
            this.groupBox2.Controls.Add(this.lbl_localidad);
            this.groupBox2.Controls.Add(this.lbl_apellido);
            this.groupBox2.Controls.Add(this.lbl_nombre);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(478, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 498);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos nuevos del usuario:";
            // 
            // txt_correonuevoMod
            // 
            this.txt_correonuevoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_correonuevoMod.Location = new System.Drawing.Point(41, 202);
            this.txt_correonuevoMod.Name = "txt_correonuevoMod";
            this.txt_correonuevoMod.Size = new System.Drawing.Size(354, 20);
            this.txt_correonuevoMod.TabIndex = 64;
            // 
            // txt_celularnuevoMod
            // 
            this.txt_celularnuevoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_celularnuevoMod.Location = new System.Drawing.Point(41, 278);
            this.txt_celularnuevoMod.Name = "txt_celularnuevoMod";
            this.txt_celularnuevoMod.Size = new System.Drawing.Size(354, 20);
            this.txt_celularnuevoMod.TabIndex = 63;
            // 
            // txt_apellidonuevoMod
            // 
            this.txt_apellidonuevoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_apellidonuevoMod.Location = new System.Drawing.Point(41, 126);
            this.txt_apellidonuevoMod.Name = "txt_apellidonuevoMod";
            this.txt_apellidonuevoMod.Size = new System.Drawing.Size(354, 20);
            this.txt_apellidonuevoMod.TabIndex = 59;
            // 
            // txt_nombrenuevoMod
            // 
            this.txt_nombrenuevoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nombrenuevoMod.Location = new System.Drawing.Point(41, 50);
            this.txt_nombrenuevoMod.Name = "txt_nombrenuevoMod";
            this.txt_nombrenuevoMod.Size = new System.Drawing.Size(354, 20);
            this.txt_nombrenuevoMod.TabIndex = 58;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_correo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_correo.Location = new System.Drawing.Point(37, 178);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(159, 21);
            this.lbl_correo.TabIndex = 57;
            this.lbl_correo.Text = "Correo electrónico:";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_celular.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_celular.Location = new System.Drawing.Point(37, 254);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(69, 21);
            this.lbl_celular.TabIndex = 56;
            this.lbl_celular.Text = "Celular:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_apellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_apellido.Location = new System.Drawing.Point(37, 102);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(78, 21);
            this.lbl_apellido.TabIndex = 51;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_nombre.Location = new System.Drawing.Point(37, 26);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 21);
            this.lbl_nombre.TabIndex = 50;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_modificarusuarioaceptar
            // 
            this.btn_modificarusuarioaceptar.BackColor = System.Drawing.Color.White;
            this.btn_modificarusuarioaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_modificarusuarioaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarusuarioaceptar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_modificarusuarioaceptar.ForeColor = System.Drawing.Color.Black;
            this.btn_modificarusuarioaceptar.Location = new System.Drawing.Point(920, 517);
            this.btn_modificarusuarioaceptar.Name = "btn_modificarusuarioaceptar";
            this.btn_modificarusuarioaceptar.Size = new System.Drawing.Size(175, 53);
            this.btn_modificarusuarioaceptar.TabIndex = 56;
            this.btn_modificarusuarioaceptar.Text = "Aceptar Modificación";
            this.btn_modificarusuarioaceptar.UseVisualStyleBackColor = false;
            this.btn_modificarusuarioaceptar.Click += new System.EventHandler(this.btn_modificarusuarioaceptar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ActivarMod);
            this.groupBox3.Controls.Add(this.txt_estadousuarioMod);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(920, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 119);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado del usuario:";
            // 
            // btn_ActivarMod
            // 
            this.btn_ActivarMod.BackColor = System.Drawing.Color.White;
            this.btn_ActivarMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_ActivarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActivarMod.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_ActivarMod.ForeColor = System.Drawing.Color.Black;
            this.btn_ActivarMod.Location = new System.Drawing.Point(6, 76);
            this.btn_ActivarMod.Name = "btn_ActivarMod";
            this.btn_ActivarMod.Size = new System.Drawing.Size(163, 37);
            this.btn_ActivarMod.TabIndex = 70;
            this.btn_ActivarMod.Text = "Activar Usuario";
            this.btn_ActivarMod.UseVisualStyleBackColor = false;
            this.btn_ActivarMod.Visible = false;
            this.btn_ActivarMod.Click += new System.EventHandler(this.btn_ActivarMod_Click);
            // 
            // txt_estadousuarioMod
            // 
            this.txt_estadousuarioMod.Enabled = false;
            this.txt_estadousuarioMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_estadousuarioMod.Location = new System.Drawing.Point(6, 50);
            this.txt_estadousuarioMod.Name = "txt_estadousuarioMod";
            this.txt_estadousuarioMod.ReadOnly = true;
            this.txt_estadousuarioMod.Size = new System.Drawing.Size(163, 20);
            this.txt_estadousuarioMod.TabIndex = 68;
            // 
            // cmb_cuilbuscarMod
            // 
            this.cmb_cuilbuscarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmb_cuilbuscarMod.FormattingEnabled = true;
            this.cmb_cuilbuscarMod.Location = new System.Drawing.Point(12, 29);
            this.cmb_cuilbuscarMod.Name = "cmb_cuilbuscarMod";
            this.cmb_cuilbuscarMod.Size = new System.Drawing.Size(354, 21);
            this.cmb_cuilbuscarMod.TabIndex = 69;
            // 
            // txt_nombreUsunuevoMod
            // 
            this.txt_nombreUsunuevoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nombreUsunuevoMod.Location = new System.Drawing.Point(41, 354);
            this.txt_nombreUsunuevoMod.Name = "txt_nombreUsunuevoMod";
            this.txt_nombreUsunuevoMod.Size = new System.Drawing.Size(354, 20);
            this.txt_nombreUsunuevoMod.TabIndex = 62;
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_localidad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_localidad.Location = new System.Drawing.Point(37, 330);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(162, 21);
            this.lbl_localidad.TabIndex = 52;
            this.lbl_localidad.Text = "Nombre de Usuario:";
            // 
            // txt_nombreUsuactualMod
            // 
            this.txt_nombreUsuactualMod.Enabled = false;
            this.txt_nombreUsuactualMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreUsuactualMod.Location = new System.Drawing.Point(54, 354);
            this.txt_nombreUsuactualMod.Name = "txt_nombreUsuactualMod";
            this.txt_nombreUsuactualMod.ReadOnly = true;
            this.txt_nombreUsuactualMod.Size = new System.Drawing.Size(354, 21);
            this.txt_nombreUsuactualMod.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(50, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nombre de Usuario:";
            // 
            // frm_ModUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1107, 670);
            this.Controls.Add(this.cmb_cuilbuscarMod);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_modificarusuarioaceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ModUsuario";
            this.Text = "frm_ModUsuario";
            this.Load += new System.EventHandler(this.frm_ModUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_correoactualMod;
        private System.Windows.Forms.TextBox txt_celularactualMod;
        private System.Windows.Forms.TextBox txt_apellidoactualMod;
        private System.Windows.Forms.TextBox txt_nombreactualMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_correonuevoMod;
        private System.Windows.Forms.TextBox txt_celularnuevoMod;
        private System.Windows.Forms.TextBox txt_apellidonuevoMod;
        private System.Windows.Forms.TextBox txt_nombrenuevoMod;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_modificarusuarioaceptar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_cuilbuscarMod;
        private System.Windows.Forms.TextBox txt_estadousuarioMod;
        private System.Windows.Forms.Button btn_ActivarMod;
        private System.Windows.Forms.TextBox txt_nombreUsuactualMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombreUsunuevoMod;
        private System.Windows.Forms.Label lbl_localidad;

    }
}