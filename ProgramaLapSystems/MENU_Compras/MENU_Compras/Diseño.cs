using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MENU_Compras
{
    class Diseño
    {

        
        public static void mostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        public static Form formActivo = null;
        public static void FormHijo(Form formHijo, Panel contenedor) 
        {

            if (formHijo != new Registrar_Compra()) // si el form es uno de Menú, puede llamar a un formHijo sin que se cierre este form
            {
                formActivo = formHijo; //guarda el formulario en una variable.
                formHijo.TopLevel = false; //el formulario no es de nivel superior y se comportara igual que un control.
                formHijo.FormBorderStyle = FormBorderStyle.None; //saca los bordes del formulario.
                formHijo.Dock = DockStyle.Fill; //rellena el panel con el formualario.
                contenedor.Controls.Add(formHijo); //agrega el formulario a la lista de control de panel
                formHijo.BringToFront(); //trae para adelante al formulario
                formHijo.Show(); // muestra el formulario
            }
            else
            {
                if (formActivo != null) formActivo.Close(); //si hay un formulario abierto lo cierra
                formActivo = formHijo; //guarda el formulario en una variable.
                formHijo.TopLevel = false; //el formulario no es de nivel superior y se comportara igual que un control.
                formHijo.FormBorderStyle = FormBorderStyle.None; //saca los bordes del formulario.
                formHijo.Dock = DockStyle.Fill; //rellena el panel con el formualario.
                contenedor.Controls.Add(formHijo); //agrega el formulario a la lista de control de panel
                formHijo.BringToFront(); //trae para adelante al formulario
                formHijo.Show(); // muestra el formulario
            }

        }

        public static void DesmarcarBotonesAltaUsuario(Button boton, Button boton1, Button boton2, Button boton3)
        {
            boton.BackColor = Color.Transparent;
            boton.ForeColor = Color.White;
            boton1.BackColor = Color.Transparent;
            boton1.ForeColor = Color.White;
            boton2.BackColor = Color.Transparent;
            boton2.ForeColor = Color.White;
            boton3.BackColor = Color.Transparent;
            boton3.ForeColor = Color.White;

        }

        public static void DesmarcarBotones(Button boton, Button boton1, Button boton2, Button boton3, Button boton4, Button boton5)
        {
            boton.BackColor = Color.Transparent;
            boton.ForeColor = Color.White;
            boton1.BackColor = Color.Transparent;
            boton1.ForeColor = Color.White;
            boton2.BackColor = Color.Transparent;
            boton2.ForeColor = Color.White;
            boton3.BackColor = Color.Transparent;
            boton3.ForeColor = Color.White;
            boton4.BackColor = Color.Transparent;
            boton4.ForeColor = Color.White;
            boton5.BackColor = Color.Transparent;
            boton5.ForeColor = Color.White;
        }

        public static void LimpiarTxtBox(GroupBox DatosPersonas)
        {
            foreach (Control control in DatosPersonas.Controls)   //genero una varaiable de control y la uso para recorrer los objetos del dtg, y si es del tipo txtBox se limpia
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }
    }
}
