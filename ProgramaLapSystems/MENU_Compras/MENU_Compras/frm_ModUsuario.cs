using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MENU_Compras
{
    public partial class frm_ModUsuario : Form
    {
        public frm_ModUsuario()
        {
            InitializeComponent();
        }

        private void frm_ModUsuario_Load(object sender, EventArgs e)
        {
            cmb_cuilbuscarMod.DataSource = Consultas.ObtenerUsuarios();
            cmb_cuilbuscarMod.DisplayMember = "Cuit_usuario";
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            Servicio.CUIT = cmb_cuilbuscarMod.Text;
            Consultas.consultaPersona();
            Consultas.consultaUsuario();

            txt_nombreactualMod.Text = Servicio.nombreUsuario;
            txt_apellidoactualMod.Text = Servicio.apellidoUsuario;
            txt_celularactualMod.Text = Servicio.telefonoUsuario;
            txt_correoactualMod.Text = Servicio.correoUsuario;
            txt_nombreUsuactualMod.Text = Servicio.usuarioNombre;
            if (Servicio.activoUsuarioString == "False")
            {
                txt_estadousuarioMod.Text = "Inactivo";
                btn_ActivarMod.Visible = true;
            }
            if (Servicio.activoUsuarioString == "True")
            {
                txt_estadousuarioMod.Text = "Activo";
                btn_ActivarMod.Visible = false;
            }
            
        }

        private void btn_ActivarMod_Click(object sender, EventArgs e)
        {
            ABM.ActivarUsuario();
        }

        private void btn_modificarusuarioaceptar_Click(object sender, EventArgs e)
        {
            Servicio.CUIT = cmb_cuilbuscarMod.Text;
            Servicio.Nombre = txt_nombrenuevoMod.Text;
            Servicio.Apellido = txt_apellidonuevoMod.Text;
            Servicio.Telefono = txt_celularnuevoMod.Text;
            Servicio.Email = txt_correonuevoMod.Text;
            Servicio.usuarioNombre = txt_nombreUsunuevoMod.Text;

            ABM.ModificarPersona();
            ABM.ModUsuario();
        }
    }
}
