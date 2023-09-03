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
    public partial class frm_AltaUsuario : Form
    {
        public frm_AltaUsuario()
        {
            InitializeComponent();
        }

        private void frm_AltaUsuario_Load(object sender, EventArgs e)
        {
            cmb_estado.SelectedIndex = 0;
        }

        private void btn_aceptarUsuarioAlta_Click(object sender, EventArgs e)
        {
            group_permisos.Visible = true;
            group_usuario.Visible = true;
            btn_CrearUsuarioAlta.Visible = true;
        }

        private void btn_CrearUsuarioAlta_Click(object sender, EventArgs e)
        {
            Servicio.Usuario = false;

            Servicio.Nombre = txt_nombreAlta.Text;
            Servicio.Apellido = txt_apellidoAlta.Text;
            Servicio.Telefono = txt_celularAlta.Text;
            Servicio.Email = txt_correoAlta.Text;
            Servicio.CUIT = txt_cuilAlta.Text;
            Servicio.passwordUsuario = txt_password.Text;
            Servicio.usuarioNombre = txt_usuario.Text;
            if (cmb_estado.Text == "Activo")
            {
                Servicio.activoUsuario = true;
            }
            else
            {
                Servicio.activoUsuario = false;
            }

            Servicio.tipoPersona = "U";

            ABM.RegistrarPersona();
            Verificaciones.VerificarPersonaFisica();

            ABM.RegistrarUsuario();
            Consultas.VerificarTipoPersona(Servicio.tipoPersona);
            Verificaciones.VerificarPersonaFisica();
            
        }








    }
}
