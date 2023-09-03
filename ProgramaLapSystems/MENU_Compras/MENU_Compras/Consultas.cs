using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MENU_Compras
{
    class Consultas
    {
        public static ConexionDB NuevaConexion = new ConexionDB();

        public static DataTable TablaConsultas = new DataTable(); 




              //////////////////////////////////////////////////////////PERSONAS///////////////////////////////////////////////////////////////////////

        public static void ConsultaPersonas()
        {

            SqlDataReader lectura = Servicio.claseConexion.RealizarConsulta("SELECT CUIT,nombre,apellido, tel, email,razon_social From Personas");

            TablaConsultas.Clear();
            TablaConsultas.Load(lectura);
            Servicio.claseConexion.CerrarConexion();
        }





        public static void VerificarTipoPersona(string Tipo)
        {
            SqlDataReader tipoPersona = Servicio.claseConexion.RealizarConsulta(@"	select Tipo_Persona.tipo_persona as TipoP
			 from Tipo_Persona 
			 inner join per_tipo
			 on per_tipo.id_tipo_persona = Tipo_Persona.id_tipo_persona
			 inner join Personas
			 on Personas.id_persona = per_tipo.id_persona
			 where Personas.CUIT = " + Servicio.CUIT);



            if (tipoPersona.ToString() != null)
            {
                if (tipoPersona.Read() == true)//si la consulta leyó algo, se controla que es lo que leyó.
                {
                    Servicio.consultaTipoPersona = tipoPersona["TipoP"].ToString();

                    if (Servicio.consultaTipoPersona.Contains("P") && (Tipo == "P"))
                    {
                        Servicio.Proveedor = true;
                    }
                    else if (Servicio.consultaTipoPersona.Contains("C") && (Tipo == "C"))
                    {
                        Servicio.Cliente = true;
                    }
                    else if (Servicio.consultaTipoPersona.Contains("U") && (Tipo == "U"))
                    {
                        Servicio.Usuario = true;
                    }

                    else
                    {
                        Servicio.sinTipoPersona = false;
                    }
                }

                else
                {
                    Servicio.consultaTipoPersona = "";
                    Servicio.sinTipoPersona = true;// si la consulta no leyó nada significa que la Persona no está registrada
                }
            }

            else
            {
                Servicio.consultaTipoPersona = "";
                Servicio.sinTipoPersona = true;// si la consulta no leyó nada significa que la Persona no está registrada
            }

        }





        public static void RegistrarTipoPersona(bool TipoP)
        {

            
            if ((TipoP == false) && (Servicio.sinTipoPersona == true))//No está registrado
            {
                Servicio.registrarTipoPersona = Servicio.claseConexion.VerificacionConsuilta(@"Insert into Tipo_Persona (tipo_persona, fisica)
            values ('" + Servicio.consultaTipoPersona + " " + Servicio.tipoPersona + "', '" + Servicio.personaFisica + "')");


                ConsultaIdPersonaIdTipoPersona();
                Servicio.registrarPerTipo = Servicio.claseConexion.VerificacionConsuilta(@"Insert into per_tipo (id_persona, id_tipo_persona)
			values (" + Servicio.Id_Persona + ", " + Servicio.Id_TipoPersona + ")");
            }

            else if ((TipoP == false) && (Servicio.sinTipoPersona == false))//Está registrado pero no como proveedor, no es necesario ingresar per_tipo, solo actualizar Tipo_Persona
            {
                ConsultaIdPersonaIdTipoPersona();
                Servicio.registrarTipoPersona = Servicio.claseConexion.VerificacionConsuilta(@" Update Tipo_Persona set tipo_persona = '" + Servicio.consultaTipoPersona + Servicio.tipoPersona + "',  fisica = '" + Servicio.personaFisica +
                   "'  where id_tipo_persona = " + Servicio.Id_TipoPersona);


            }

            else
            {
                MessageBox.Show("Esta persona ya se encuentra dada de alta");
            }


        }



        public static void ConsultaIdPersonaIdTipoPersona()
        {
            SqlDataReader idPersona = Servicio.claseConexion.RealizarConsulta(@"Select id_persona from Personas where CUIT = " + Servicio.CUIT);
            while ( idPersona.Read())
                Servicio.Id_Persona = idPersona.GetInt32(0);

            SqlDataReader idTipoPersona = Servicio.claseConexion.RealizarConsulta(@"Select id_tipo_persona from Tipo_Persona where id_tipo_persona = (select MAX (id_tipo_persona) from Tipo_Persona)");
            while(idTipoPersona.Read())
            Servicio.Id_TipoPersona = idTipoPersona.GetInt32(0);
        }






         
        ////////////////////////////////////////////////// PROVEEDORES////////////////////////////////////////////


        public static void RegistrarProveedores()
        {
            SqlDataReader consultaCuitRepetido = Servicio.claseConexion.RealizarConsulta("SELECT CUIT FROM Proveedores where CUIT = " + Convert.ToInt64(Servicio.CUIT) + "");

            if (consultaCuitRepetido.Read() == true) // si consultaCuitRepetido trae un registro, significa que el valor de consultaCuitRepetido es TRUE
            {
                MessageBox.Show("El Cuil/Cuit ingresado pertenece a un proveedor dado de alta");
            }
            else
            {
                Servicio.registrarProv = Servicio.claseConexion.VerificacionConsuilta(@"Insert Into Proveedores(CUIT,razon_social)
            Values (" + Convert.ToInt64(Servicio.CUIT) + ", '" + Servicio.RazonSocial + "')");



                if (Servicio.registrarProv == true)
                {
                    ConsultaPersonas();
                    VerificarTipoPersona(Servicio.tipoPersona);
                    RegistrarTipoPersona(Servicio.Proveedor);// si se crea bien el proveedor, creo el tipo de persona (P)
                    MessageBox.Show("Se registró correctamente ", "Proceso finalizado:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:");
                }
            }

        }



        public static List<Servicio.Proveedores> ObtenerProveedores()
        {
            List<Servicio.Proveedores> _lista = new List<Servicio.Proveedores>();

            SqlDataReader consulta = NuevaConexion.RealizarConsulta("Select CUIT From Proveedores");

            while (consulta.Read())
            {
                Servicio.Proveedores N_Proveedores = new Servicio.Proveedores();

                N_Proveedores.Cuit_proveedor = consulta.GetDecimal(0).ToString();

                _lista.Add(N_Proveedores);
            }

            return _lista;

        }

        public static List<Servicio.Usuarios> ObtenerUsuarios()
        {
            List<Servicio.Usuarios> _lista = new List<Servicio.Usuarios>();

            SqlDataReader consulta = NuevaConexion.RealizarConsulta("Select CUIT From Usuarios");

            while (consulta.Read())
            {
                Servicio.Usuarios N_Usuarios = new Servicio.Usuarios();

                N_Usuarios.Cuit_usuario = consulta.GetDecimal(0).ToString();

                _lista.Add(N_Usuarios);
            }

            return _lista;

        }

        ////////////////////////////////////////////////// USUARIOS////////////////////////////////////////////
        public static void consultaPersona()
        {
            SqlDataReader lector = NuevaConexion.RealizarConsulta("Select * From Personas WHERE CUIT =" + Servicio.CUIT);

            if (lector.Read())
            {
                Servicio.nombreUsuario = lector["nombre"].ToString();
                Servicio.apellidoUsuario = lector["apellido"].ToString();
                Servicio.telefonoUsuario = lector["tel"].ToString();
                Servicio.correoUsuario = lector["email"].ToString();
                Servicio.razonsocialUsuario = lector["razon_social"].ToString();
 
            }
            //else
                //MessageBox.Show("control: falta persona");
        }

        public static void consultaUsuario()
        {
            SqlDataReader lector = NuevaConexion.RealizarConsulta("Select * From Usuarios WHERE CUIT =" + Servicio.CUIT);

            if (lector.Read())
            {
                Servicio.usuarioNombre = lector["usuario"].ToString();
                Servicio.activoUsuarioString = lector["activo"].ToString();
              
            }
            //else
            //{
            //    Servicio.usuarioNombre = "";
            //    MessageBox.Show("control: falta usuario");
            //}
                
        }

        public static void bajaUsuario()
        {
            SqlDataReader lector = NuevaConexion.RealizarConsulta("UPDATE Usuarios set activo='false' WHERE CUIT =" + Servicio.CUIT);
        }

    }
}
