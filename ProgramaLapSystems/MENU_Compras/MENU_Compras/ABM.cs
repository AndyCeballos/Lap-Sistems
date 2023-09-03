using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MENU_Compras
{
    class ABM
    {
        private ConexionDB conexion = new ConexionDB();

        public static ConexionDB NuevaConexion = new ConexionDB();

        public static DataTable TablaConsultas = new DataTable(); 



        public static void RegistrarPersona()
        {
            Servicio.altaPersona = false;

            SqlDataReader consultaCuitRepetido = Servicio.claseConexion.RealizarConsulta("SELECT CUIT FROM Personas where CUIT = " + Convert.ToInt64(Servicio.CUIT) + "");

            if (consultaCuitRepetido.Read() == true) // si consultaCuitRepetido trae un registro, significa que el valor de consultaCuitRepetido es TRUE
            {
                MessageBox.Show("El Cuil/Cuit pertenece a una persona ya dada de alta");
                if (Servicio.altaTipoPersona == 1)
                {
                    Consultas.VerificarTipoPersona(Servicio.tipoPersona);
                    Consultas.RegistrarTipoPersona(Servicio.Usuario); //verifico si ya esta dado de alta como usuario y sino lo esta lo agrego en TipoPersona y en per_tipo
 
                }
                else if (Servicio.altaTipoPersona == 2)
                {
                    Consultas.VerificarTipoPersona(Servicio.tipoPersona);
                    Consultas.RegistrarTipoPersona(Servicio.Proveedor);  //                         ""

                }
                else if (Servicio.altaTipoPersona == 3)
                {
                    Consultas.VerificarTipoPersona(Servicio.tipoPersona);
                    Consultas.RegistrarTipoPersona(Servicio.Cliente);  //                           ""

                }
               
            }

            else
            {
                Servicio.altaPersona = Servicio.claseConexion.VerificacionConsuilta(@"Insert Into Personas(CUIT, nombre,apellido, tel, email,razon_social)
                Values (" + Convert.ToInt64(Servicio.CUIT) + ", '" + Servicio.Nombre + "', '" + Servicio.Apellido + "', '" + Servicio.Telefono + "', '" + Servicio.Email + "', '" + Servicio.RazonSocial + "')");

                if (Servicio.altaPersona == true)
                {
                    Consultas.ConsultaPersonas();
                }
                else
                {
                }
            }

        }







        public static void ModificarPersona()
        {
            bool ModificarP = false;

            ModificarP = Servicio.claseConexion.VerificacionConsuilta(@"UPDATE Personas SET nombre = '" + Servicio.Nombre + "', apellido = '" + Servicio.Apellido + "',tel = '" + Servicio.Telefono + "', email = '" + Servicio.Email + "' ,razon_social = '" + Servicio.RazonSocial + "'" +
            " WHERE CUIT = " + Convert.ToInt64(Servicio.CUIT));

            var seleccion = MessageBox.Show("¿Está seguro de guardar las modificaciones realizadas?", "Preacucion:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (seleccion != DialogResult.OK)
            {
                if (ModificarP == true)
                {

                    Consultas.ConsultaPersonas();


                    MessageBox.Show("Se registró correctamente ", "Proceso finalizado:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:");
                }
            }
            else
            {
                MessageBox.Show("No se pudo completar la operación", " Opercacion cancelada");
            }
        }

        ////////////////////////////////////////////////REGISTRAR USUARIO/////////////////////////////////////////////////////////////////////////
        public static void RegistrarUsuario()
        {
            Servicio.altaPersona = false;

            SqlDataReader consultaCuitRepetido = Servicio.claseConexion.RealizarConsulta("SELECT CUIT FROM Usuarios where CUIT = " + Convert.ToInt64(Servicio.CUIT) + "");

            if (consultaCuitRepetido.Read() == true) // si consultaCuitRepetido trae un registro, significa que el valor de consultaCuitRepetido es TRUE
            {
                MessageBox.Show("El Cuil/Cuit pertenece a un usuario ya dado de alta.");
                if (Servicio.altaTipoPersona == 1)
                {
                    Consultas.VerificarTipoPersona(Servicio.tipoPersona);
                    Consultas.RegistrarTipoPersona(Servicio.Usuario); //verifico si ya esta dado de alta como usuario y sino lo esta lo agrego en TipoPersona y en per_tipo
                   
                }
                else if (Servicio.altaTipoPersona == 2)
                {
                    Consultas.VerificarTipoPersona(Servicio.tipoPersona);
                    Consultas.RegistrarTipoPersona(Servicio.Proveedor);  //                         ""
                    
                }
                else if (Servicio.altaTipoPersona == 3)
                {
                    Consultas.VerificarTipoPersona(Servicio.tipoPersona);
                    Consultas.RegistrarTipoPersona(Servicio.Cliente);  //                           ""
                    
                }

            }

            else
            {
                Servicio.altaPersona = Servicio.claseConexion.VerificacionConsuilta(@"Insert Into Usuarios(CUIT, usuario, password, activo)  Values (" + Convert.ToInt64(Servicio.CUIT) + ", '" + Servicio.usuarioNombre + "', '"  + Servicio.passwordUsuario + "','" + Servicio.activoUsuario + "')");


                if (Servicio.altaPersona == true)
                {
                    MessageBox.Show("Usuario creado correctamente.");

                }
                else
                {
                    MessageBox.Show("Error en la creación del usuario.");
                }
            }

        }

        //////////////////////////////////////////////////////////////////////////CAMBIAR ACTIVO A TRUE//////////////////////////////////////////////////////
        public static void ActivarUsuario()
        {
            Servicio.altaPersona = false;

            Servicio.altaPersona = Servicio.claseConexion.VerificacionConsuilta(@"UPDATE Usuarios SET activo='true' WHERE CUIT=" + Convert.ToInt64(Servicio.CUIT) + ";");


            if (Servicio.altaPersona == true)
            {
                MessageBox.Show("Activo cambiado a true.");

            }
            else
            {
                MessageBox.Show("Error.");
            }
        }
        //////////////////////////////////////////////////////////////////////////MODIFICAR USUARIO//////////////////////////////////////////////////////
        public static void ModUsuario()
        {
            Servicio.altaPersona = false;

            Servicio.altaPersona = Servicio.claseConexion.VerificacionConsuilta(@"UPDATE Usuarios SET usuario='"+ Servicio.usuarioNombre + "' WHERE CUIT=" + Convert.ToInt64(Servicio.CUIT) + ";");


            if (Servicio.altaPersona == true)
            {
                MessageBox.Show("Usuario modificado correctamente.");

            }
            else
            {
                MessageBox.Show("Error en la modificación del usuario.");
            }
        }

    }
}


