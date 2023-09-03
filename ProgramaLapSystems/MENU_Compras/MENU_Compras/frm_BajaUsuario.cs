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
    public partial class frm_BajaUsuario : Form
    {
        public frm_BajaUsuario()
        {
            InitializeComponent();
        }

        private void frm_BajaUsuario_Load(object sender, EventArgs e)
        {
            cmb_cuilbuscarBaja.DataSource = Consultas.ObtenerUsuarios();
            cmb_cuilbuscarBaja.DisplayMember = "Cuit_usuario";

        }


        private void btn_buscarusuarioBaja_Click(object sender, EventArgs e)
        {
            txt_nombreBaja.Clear();
            txt_apellidoBaja.Clear();
            txt_celularBaja.Clear();
            txt_correoBaja.Clear();

            Servicio.CUIT = cmb_cuilbuscarBaja.Text;
            Consultas.consultaPersona();
            Consultas.consultaUsuario();

            txt_nombreBaja.Text = Servicio.nombreUsuario;
            txt_apellidoBaja.Text = Servicio.apellidoUsuario;
            txt_celularBaja.Text = Servicio.telefonoUsuario;
            txt_correoBaja.Text = Servicio.correoUsuario;
  
            txt_usuarioBaja.Text = Servicio.usuarioNombre;
            
        }

        private void btn_aceptarBaja_Click(object sender, EventArgs e)
        {
            Consultas.bajaUsuario();
        }
    }
}
