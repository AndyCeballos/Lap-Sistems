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
    public partial class Registrar_Compra : Form
    {
        public Registrar_Compra()
        {
            InitializeComponent();

            ocultarPanelesCompra();


        }

        private void ocultarPanelesCompra()
        {
            pnl_registrarCompras.Visible = false;
            pnl_proveedores.Visible = false;
            pnl_articulos.Visible = false;
        }


        private void btn_Todos_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (Servicio.BotonAnterior != null)
            {
                Servicio.BotonAnterior.ForeColor = Color.White;
            }
            boton.ForeColor = Color.Black;

            Servicio.BotonAnterior = boton;
        }

        private void btn_Todos_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.White;
        }




        private void btn_RegistrarCompras_servicios_Click(object sender, EventArgs e)
        {
            Diseño.mostrarSubMenu(pnl_registrarCompras);
        }


        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Diseño.mostrarSubMenu(pnl_proveedores);
        }


        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Diseño.mostrarSubMenu(pnl_articulos);
        }


 

        private void btn_registCompras_Click_1(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_Registro_de_compras(), pnl_Contenedor);
            Diseño.DesmarcarBotones(btn_registCompras, btn_pagarServicios,btn_registrarProveedores,btn_modificarProveedores,btn_categoriasSubcat,btn_modificarArticulos);
            btn_registCompras.BackColor = Color.FromArgb(28, 63, 89);
            btn_registCompras.ForeColor = Color.Black;
        }

        private void btn_pagarServicios_Click_1(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_Registro_de_compras(), pnl_Contenedor);
            Diseño.DesmarcarBotones(btn_pagarServicios, btn_registCompras,btn_registrarProveedores,btn_modificarProveedores,btn_categoriasSubcat,btn_modificarArticulos);
            btn_pagarServicios.BackColor = Color.FromArgb(28, 63, 89);
            btn_pagarServicios.ForeColor = Color.Black;
        }

        private void btn_registrarProveedores_Click_1(object sender, EventArgs e)
        {
            Servicio.RegisModif = 1;
            Diseño.FormHijo(new frm_Personas(), pnl_Contenedor);
            Servicio.altaTipoPersona = 2;
            Servicio.aceptar = false;
            Diseño.DesmarcarBotones(btn_registrarProveedores, btn_pagarServicios, btn_registCompras, btn_modificarProveedores,btn_categoriasSubcat,btn_modificarArticulos);
            btn_registrarProveedores.BackColor = Color.FromArgb(28, 63, 89);
            btn_registrarProveedores.ForeColor = Color.Black;
        }

        private void btn_modificarProveedores_Click_1(object sender, EventArgs e)
        {
            Servicio.RegisModif = 2;
            Diseño.FormHijo(new frm_Personas(), pnl_Contenedor);
            Servicio.aceptar = false;
            Diseño.DesmarcarBotones(btn_modificarProveedores, btn_registrarProveedores, btn_pagarServicios, btn_registCompras, btn_categoriasSubcat, btn_modificarArticulos);
            btn_modificarProveedores.BackColor = Color.FromArgb(28, 63, 89);
            btn_modificarProveedores.ForeColor = Color.Black;
        }

        private void btn_categoriasSubcat_Click_1(object sender, EventArgs e)
        {
            Diseño.FormHijo(new frm_Categorias_subcategorias(), pnl_Contenedor);
            Diseño.DesmarcarBotones(btn_categoriasSubcat, btn_modificarProveedores, btn_registrarProveedores, btn_pagarServicios, btn_registCompras, btn_modificarArticulos);
            btn_categoriasSubcat.BackColor = Color.FromArgb(28, 63, 89);
            btn_categoriasSubcat.ForeColor = Color.Black;
        }

        private void btn_modificarArticulos_Click_1(object sender, EventArgs e)
        {
            Diseño.FormHijo(new Modificar_Articulos(), pnl_Contenedor);
            Diseño.DesmarcarBotones(btn_modificarArticulos, btn_categoriasSubcat, btn_modificarProveedores, btn_registrarProveedores, btn_pagarServicios, btn_registCompras);
            btn_modificarArticulos.BackColor = Color.FromArgb(28, 63, 89);
            btn_modificarArticulos.ForeColor = Color.Black;
        }

        private void pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }





   
       
    }
}
