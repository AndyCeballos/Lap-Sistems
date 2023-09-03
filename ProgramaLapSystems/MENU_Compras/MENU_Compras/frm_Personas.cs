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
    public partial class frm_Personas : Form
    {
        public frm_Personas()
        {
            InitializeComponent();

        }


        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            Consultas.ConsultaPersonas();
            dtgv_Proveedores.DataSource = Consultas.TablaConsultas;

            if (Servicio.RegisModif == 2)// si es MODIFICAR muestra la primer fila del dtg en los txtBox
            {
                txt_IngreseCuil.Enabled = false; //el txtBox del CUIT no se puede modificar

                Servicio.Seleccion = dtgv_Proveedores.CurrentRow.Index;
                txt_IngreseCuil.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[0].Value.ToString();
                txt_IngreseNomb.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[1].Value.ToString();
                txt_IngreseApell.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[2].Value.ToString();
                txt_IngreseCel.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[3].Value.ToString();
                txt_IngreseCorreo.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[4].Value.ToString();
                txt_razonSocial.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[5].Value.ToString();

            }
            
            
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            Servicio.CUIT = (txt_IngreseCuil.Text);      //cargo las variables con lo que hay en cada txtBox
            Servicio.Nombre = txt_IngreseNomb.Text;               
            Servicio.Apellido = txt_IngreseApell.Text;
            Servicio.Telefono = txt_IngreseCel.Text;
            Servicio.Email = txt_IngreseCorreo.Text;
            Servicio.RazonSocial = txt_razonSocial.Text;
            Servicio.tipoPersona = "P";
            Servicio.Proveedor = false;

            if (Servicio.RegisModif == 2) //Si es modificar relaizo la consulta de modifcar
            {
                ABM.ModificarPersona();
                Consultas.ConsultaPersonas();
            }
            else
            {
                if (Servicio.aceptar == true)
                {
                    ABM.RegistrarPersona(); //sino es modificar hago la consulta de registrar
                    Verificaciones.VerificarPersonaFisica();//verifíco si los primeros dos digitos ingresados pertenecen a un cuit o cuil 
                    Consultas.RegistrarProveedores();//creo al proveedor despues de crear a la persona, y si se crea bien el proveedor, creo y le asigno el tipo de persona (P) a la Persona.
                    Consultas.ConsultaPersonas(); // hago una consulta de los datos de Personas
                    this.Close(); //se cierra cuando lo llamo desde registrar una compra
                }

                ABM.RegistrarPersona();
                Verificaciones.VerificarPersonaFisica();
                Consultas.RegistrarProveedores();
                Consultas.ConsultaPersonas();
                Diseño.LimpiarTxtBox(gbx_datosPersona); 

                
            }
            
        }

        private void dtgv_Proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Servicio.RegisModif == 2)//sino es MODIFICAR no puede seleccionar las filas del dtg y mostrarlas en los txtBox
            {
                Servicio.Seleccion = dtgv_Proveedores.CurrentRow.Index;  // guardo en numero de la fila que selecciona el usuario al hacer click en en una fila del dtg
                txt_IngreseCuil.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[0].Value.ToString(); //muestro lo que tiene cada columna del dtg en los txtBox según corresponda
                txt_IngreseNomb.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[1].Value.ToString();
                txt_IngreseApell.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[2].Value.ToString();
                txt_IngreseCel.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[3].Value.ToString();
                txt_IngreseCorreo.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[4].Value.ToString();
                txt_razonSocial.Text = dtgv_Proveedores.Rows[Servicio.Seleccion].Cells[5].Value.ToString();
            }

        }


    }
}
