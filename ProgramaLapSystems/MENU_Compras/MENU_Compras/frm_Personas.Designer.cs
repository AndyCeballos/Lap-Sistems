namespace MENU_Compras
{
    partial class frm_Personas
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
            this.txt_IngreseNomb = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_codarea = new System.Windows.Forms.Label();
            this.cmb_localidad = new System.Windows.Forms.ComboBox();
            this.cmb_codArea = new System.Windows.Forms.ComboBox();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_IngreseCorreo = new System.Windows.Forms.TextBox();
            this.txt_IngreseCel = new System.Windows.Forms.TextBox();
            this.txt_ingreseDirecc = new System.Windows.Forms.TextBox();
            this.txt_IngreseCuil = new System.Windows.Forms.TextBox();
            this.txt_IngreseApell = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_FechadeNac = new System.Windows.Forms.Label();
            this.lbl_Localidad = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_CuilCuit = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_razonSocial = new System.Windows.Forms.TextBox();
            this.lbl_razonSocial = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.dtgv_Proveedores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbx_datosPersona = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Proveedores)).BeginInit();
            this.gbx_datosPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IngreseNomb
            // 
            this.txt_IngreseNomb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IngreseNomb.Location = new System.Drawing.Point(19, 37);
            this.txt_IngreseNomb.Name = "txt_IngreseNomb";
            this.txt_IngreseNomb.Size = new System.Drawing.Size(282, 27);
            this.txt_IngreseNomb.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Nombre.Location = new System.Drawing.Point(16, 16);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(77, 21);
            this.lbl_Nombre.TabIndex = 174;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telefono.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Telefono.Location = new System.Drawing.Point(80, 397);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(0, 18);
            this.lbl_Telefono.TabIndex = 173;
            // 
            // lbl_codarea
            // 
            this.lbl_codarea.AutoSize = true;
            this.lbl_codarea.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codarea.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codarea.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_codarea.Location = new System.Drawing.Point(18, 443);
            this.lbl_codarea.Name = "lbl_codarea";
            this.lbl_codarea.Size = new System.Drawing.Size(60, 16);
            this.lbl_codarea.TabIndex = 172;
            this.lbl_codarea.Text = "Cód Área";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Items.AddRange(new object[] {
            "Adolfo Alsina",
            "Alberti",
            "Almirante Brown",
            "Avellaneda",
            "Bransen",
            "Campana",
            "Cañuelas",
            "Carlos Casares",
            "Castelli",
            "Chacabuco",
            "Chascomús",
            "Coronel Dorrego",
            "Dolores",
            "Escobar",
            "Esteban Echeverria",
            "Ezeiza",
            "Florencio Varela",
            "General Belgrano",
            "General San Martin",
            "Hipólito Yrigoyen",
            "Hurlingham",
            "Ituzaingo",
            "José C. Paz",
            "Junín",
            "La Matanza",
            "Lanús",
            "La Plata",
            "Laprida",
            "Lobos",
            "Lomas de Zamora",
            "Luján",
            "Mercedes",
            "Merlo",
            "Monte Hermoso",
            "Moreno",
            "Morón",
            "Navarro",
            "Quilmes",
            "Saavedra",
            "San Nicolás",
            "San Pedro",
            "San Vicente",
            "Tandil",
            "Tigre",
            "Tres Arroyos",
            "Tres de Febrero",
            "vicente López",
            "Zarate"});
            this.cmb_localidad.Location = new System.Drawing.Point(19, 303);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Size = new System.Drawing.Size(282, 29);
            this.cmb_localidad.TabIndex = 6;
            // 
            // cmb_codArea
            // 
            this.cmb_codArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_codArea.FormattingEnabled = true;
            this.cmb_codArea.Location = new System.Drawing.Point(20, 411);
            this.cmb_codArea.Name = "cmb_codArea";
            this.cmb_codArea.Size = new System.Drawing.Size(73, 29);
            this.cmb_codArea.TabIndex = 10;
            // 
            // cmb_año
            // 
            this.cmb_año.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Items.AddRange(new object[] {
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970"});
            this.cmb_año.Location = new System.Drawing.Point(187, 358);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(114, 29);
            this.cmb_año.TabIndex = 9;
            // 
            // cmb_mes
            // 
            this.cmb_mes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmb_mes.Location = new System.Drawing.Point(104, 357);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(73, 29);
            this.cmb_mes.TabIndex = 8;
            // 
            // cmb_dia
            // 
            this.cmb_dia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_dia.Location = new System.Drawing.Point(19, 357);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(73, 29);
            this.cmb_dia.TabIndex = 7;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.btn_aceptar.Location = new System.Drawing.Point(197, 518);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(101, 34);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_IngreseCorreo
            // 
            this.txt_IngreseCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IngreseCorreo.Location = new System.Drawing.Point(20, 482);
            this.txt_IngreseCorreo.Name = "txt_IngreseCorreo";
            this.txt_IngreseCorreo.Size = new System.Drawing.Size(282, 27);
            this.txt_IngreseCorreo.TabIndex = 12;
            // 
            // txt_IngreseCel
            // 
            this.txt_IngreseCel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IngreseCel.Location = new System.Drawing.Point(97, 411);
            this.txt_IngreseCel.Name = "txt_IngreseCel";
            this.txt_IngreseCel.Size = new System.Drawing.Size(205, 27);
            this.txt_IngreseCel.TabIndex = 11;
            // 
            // txt_ingreseDirecc
            // 
            this.txt_ingreseDirecc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingreseDirecc.Location = new System.Drawing.Point(19, 252);
            this.txt_ingreseDirecc.Name = "txt_ingreseDirecc";
            this.txt_ingreseDirecc.Size = new System.Drawing.Size(282, 27);
            this.txt_ingreseDirecc.TabIndex = 5;
            // 
            // txt_IngreseCuil
            // 
            this.txt_IngreseCuil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IngreseCuil.Location = new System.Drawing.Point(19, 142);
            this.txt_IngreseCuil.Name = "txt_IngreseCuil";
            this.txt_IngreseCuil.Size = new System.Drawing.Size(282, 27);
            this.txt_IngreseCuil.TabIndex = 3;
            // 
            // txt_IngreseApell
            // 
            this.txt_IngreseApell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IngreseApell.Location = new System.Drawing.Point(19, 88);
            this.txt_IngreseApell.Name = "txt_IngreseApell";
            this.txt_IngreseApell.Size = new System.Drawing.Size(282, 27);
            this.txt_IngreseApell.TabIndex = 2;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Correo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Correo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Correo.Location = new System.Drawing.Point(17, 461);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(159, 21);
            this.lbl_Correo.TabIndex = 160;
            this.lbl_Correo.Text = "Correo electrónico:";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Celular.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Celular.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Celular.Location = new System.Drawing.Point(17, 389);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(69, 21);
            this.lbl_Celular.TabIndex = 159;
            this.lbl_Celular.Text = "Celular:";
            // 
            // lbl_FechadeNac
            // 
            this.lbl_FechadeNac.AutoSize = true;
            this.lbl_FechadeNac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechadeNac.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_FechadeNac.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_FechadeNac.Location = new System.Drawing.Point(16, 336);
            this.lbl_FechadeNac.Name = "lbl_FechadeNac";
            this.lbl_FechadeNac.Size = new System.Drawing.Size(183, 21);
            this.lbl_FechadeNac.TabIndex = 158;
            this.lbl_FechadeNac.Text = "Fecha de Nacimiento:";
            // 
            // lbl_Localidad
            // 
            this.lbl_Localidad.AutoSize = true;
            this.lbl_Localidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Localidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Localidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Localidad.Location = new System.Drawing.Point(16, 282);
            this.lbl_Localidad.Name = "lbl_Localidad";
            this.lbl_Localidad.Size = new System.Drawing.Size(91, 21);
            this.lbl_Localidad.TabIndex = 157;
            this.lbl_Localidad.Text = "Localidad:";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Direccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Direccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Direccion.Location = new System.Drawing.Point(16, 231);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(87, 21);
            this.lbl_Direccion.TabIndex = 156;
            this.lbl_Direccion.Text = "Dirección:";
            // 
            // lbl_CuilCuit
            // 
            this.lbl_CuilCuit.AutoSize = true;
            this.lbl_CuilCuit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CuilCuit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_CuilCuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CuilCuit.Location = new System.Drawing.Point(16, 121);
            this.lbl_CuilCuit.Name = "lbl_CuilCuit";
            this.lbl_CuilCuit.Size = new System.Drawing.Size(79, 21);
            this.lbl_CuilCuit.TabIndex = 155;
            this.lbl_CuilCuit.Text = "Cuil/Cuit";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Apellido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Apellido.Location = new System.Drawing.Point(17, 67);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(78, 21);
            this.lbl_Apellido.TabIndex = 154;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razonSocial.Location = new System.Drawing.Point(19, 194);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(282, 27);
            this.txt_razonSocial.TabIndex = 4;
            // 
            // lbl_razonSocial
            // 
            this.lbl_razonSocial.AutoSize = true;
            this.lbl_razonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_razonSocial.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_razonSocial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_razonSocial.Location = new System.Drawing.Point(16, 173);
            this.lbl_razonSocial.Name = "lbl_razonSocial";
            this.lbl_razonSocial.Size = new System.Drawing.Size(105, 21);
            this.lbl_razonSocial.TabIndex = 176;
            this.lbl_razonSocial.Text = "Razon social";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_usuario.Location = new System.Drawing.Point(-113, 509);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 21);
            this.lbl_usuario.TabIndex = 180;
            this.lbl_usuario.Text = "Usuario: ";
            // 
            // dtgv_Proveedores
            // 
            this.dtgv_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_Proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Proveedores.BackgroundColor = System.Drawing.Color.Teal;
            this.dtgv_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Proveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Proveedores.EnableHeadersVisualStyles = false;
            this.dtgv_Proveedores.Location = new System.Drawing.Point(402, 64);
            this.dtgv_Proveedores.Name = "dtgv_Proveedores";
            this.dtgv_Proveedores.ReadOnly = true;
            this.dtgv_Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Proveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Proveedores.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_Proveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Proveedores.Size = new System.Drawing.Size(703, 279);
            this.dtgv_Proveedores.TabIndex = 181;
            this.dtgv_Proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Proveedores_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MENU_Compras.Properties.Resources.usuario1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(497, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 71);
            this.panel1.TabIndex = 179;
            // 
            // gbx_datosPersona
            // 
            this.gbx_datosPersona.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datosPersona.Controls.Add(this.lbl_Nombre);
            this.gbx_datosPersona.Controls.Add(this.lbl_Apellido);
            this.gbx_datosPersona.Controls.Add(this.lbl_usuario);
            this.gbx_datosPersona.Controls.Add(this.lbl_CuilCuit);
            this.gbx_datosPersona.Controls.Add(this.lbl_Direccion);
            this.gbx_datosPersona.Controls.Add(this.txt_razonSocial);
            this.gbx_datosPersona.Controls.Add(this.lbl_Localidad);
            this.gbx_datosPersona.Controls.Add(this.lbl_razonSocial);
            this.gbx_datosPersona.Controls.Add(this.lbl_FechadeNac);
            this.gbx_datosPersona.Controls.Add(this.txt_IngreseNomb);
            this.gbx_datosPersona.Controls.Add(this.lbl_Celular);
            this.gbx_datosPersona.Controls.Add(this.lbl_Correo);
            this.gbx_datosPersona.Controls.Add(this.lbl_Telefono);
            this.gbx_datosPersona.Controls.Add(this.txt_IngreseApell);
            this.gbx_datosPersona.Controls.Add(this.lbl_codarea);
            this.gbx_datosPersona.Controls.Add(this.txt_IngreseCuil);
            this.gbx_datosPersona.Controls.Add(this.cmb_localidad);
            this.gbx_datosPersona.Controls.Add(this.txt_ingreseDirecc);
            this.gbx_datosPersona.Controls.Add(this.cmb_codArea);
            this.gbx_datosPersona.Controls.Add(this.txt_IngreseCel);
            this.gbx_datosPersona.Controls.Add(this.cmb_año);
            this.gbx_datosPersona.Controls.Add(this.txt_IngreseCorreo);
            this.gbx_datosPersona.Controls.Add(this.cmb_mes);
            this.gbx_datosPersona.Controls.Add(this.btn_aceptar);
            this.gbx_datosPersona.Controls.Add(this.cmb_dia);
            this.gbx_datosPersona.Location = new System.Drawing.Point(54, 27);
            this.gbx_datosPersona.Name = "gbx_datosPersona";
            this.gbx_datosPersona.Size = new System.Drawing.Size(325, 567);
            this.gbx_datosPersona.TabIndex = 182;
            this.gbx_datosPersona.TabStop = false;
            // 
            // frm_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.BackgroundImage = global::MENU_Compras.Properties.Resources.fondo_Mesa_de_trabajo_1;
            this.ClientSize = new System.Drawing.Size(1313, 606);
            this.Controls.Add(this.gbx_datosPersona);
            this.Controls.Add(this.dtgv_Proveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Personas";
            this.Text = "frm_Personas";
            this.Load += new System.EventHandler(this.frm_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Proveedores)).EndInit();
            this.gbx_datosPersona.ResumeLayout(false);
            this.gbx_datosPersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IngreseNomb;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_codarea;
        private System.Windows.Forms.ComboBox cmb_localidad;
        private System.Windows.Forms.ComboBox cmb_codArea;
        private System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_IngreseCorreo;
        private System.Windows.Forms.TextBox txt_IngreseCel;
        private System.Windows.Forms.TextBox txt_ingreseDirecc;
        private System.Windows.Forms.TextBox txt_IngreseCuil;
        private System.Windows.Forms.TextBox txt_IngreseApell;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Label lbl_FechadeNac;
        private System.Windows.Forms.Label lbl_Localidad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_CuilCuit;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.Label lbl_razonSocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.DataGridView dtgv_Proveedores;
        private System.Windows.Forms.GroupBox gbx_datosPersona;
    }
}