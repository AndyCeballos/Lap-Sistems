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
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }


        private void frm_moduloCompras_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Diseño.FormHijo(new Registrar_Compra(), pnl_forms); //llamo al form registrar compras en el panel de forms
        }

        private void btn_RRHH_Click(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_GestionUsuarios(), pnl_forms);
        }

        private void pnl_forms_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
