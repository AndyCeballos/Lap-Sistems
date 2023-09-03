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
    public partial class frm_GestionUsuarios : Form
    {
        public frm_GestionUsuarios()
        {
            InitializeComponent();
        }

        private void btn_AltaUsuario_Click(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_AltaUsuario(), pnl_ContenedorUsuarios);
            Diseño.DesmarcarBotonesAltaUsuario(btn_AltaUsuario, btn_BajaUsuario, btn_ModUsuario, btn_Consultas);
            btn_AltaUsuario.BackColor = Color.FromArgb(28, 63, 89);
            btn_AltaUsuario.ForeColor = Color.Transparent;
        }

        private void btn_BajaUsuario_Click(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_BajaUsuario(), pnl_ContenedorUsuarios);
            Diseño.DesmarcarBotonesAltaUsuario(btn_AltaUsuario, btn_BajaUsuario, btn_ModUsuario, btn_Consultas);
            btn_BajaUsuario.BackColor = Color.FromArgb(28, 63, 89);
            btn_BajaUsuario.ForeColor = Color.Transparent;
        }

        private void btn_ModUsuario_Click(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_ModUsuario(), pnl_ContenedorUsuarios);
            Diseño.DesmarcarBotonesAltaUsuario(btn_AltaUsuario, btn_BajaUsuario, btn_ModUsuario, btn_Consultas);
            btn_ModUsuario.BackColor = Color.FromArgb(28, 63, 89);
            btn_ModUsuario.ForeColor = Color.Transparent;
        }

        private void btn_Consultas_Click(object sender, EventArgs e)
        {
            Diseño.DesmarcarBotonesAltaUsuario(btn_AltaUsuario, btn_BajaUsuario, btn_ModUsuario, btn_Consultas);
            btn_Consultas.BackColor = Color.FromArgb(28, 63, 89);
            btn_Consultas.ForeColor = Color.Transparent;
        }









    }
}
