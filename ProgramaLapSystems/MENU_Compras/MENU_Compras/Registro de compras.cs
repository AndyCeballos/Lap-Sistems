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
    public partial class frm_Registro_de_compras : Form
    {
        public frm_Registro_de_compras()
        {
            InitializeComponent();
            lbl_fecha.Text = lbl_fecha.Text + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frm_Registro_de_compras_Load(object sender, EventArgs e)
        {
            cmb_proveedores.DataSource = Consultas.ObtenerProveedores();
            cmb_proveedores.DisplayMember = "Cuit_proveedor";
        }

        private void cmb_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_agregarProveedor_Click(object sender, EventArgs e)
        {
            Servicio.RegisModif = 1;
            Form proveedores = new  frm_Personas();
            Servicio.aceptar = true;
            proveedores.Height = 670;
            proveedores.Width = 1050;
            proveedores.MaximizeBox = false;
            proveedores.MinimizeBox = false;
            proveedores.StartPosition = FormStartPosition.CenterScreen;
            proveedores.FormBorderStyle = FormBorderStyle.Fixed3D;
            proveedores.ShowDialog();

        }




    }
}
