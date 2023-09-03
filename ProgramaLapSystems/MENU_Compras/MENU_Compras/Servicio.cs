using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MENU_Compras
{
    class Servicio
    {
        public static string CUIT;
        public static string Nombre;
        public static string Apellido;
        public static string Telefono;
        public static string Email;
        public static string RazonSocial;

       
        
        //public static string cuitUsuario;
        public static string nombreUsuario;
        public static string apellidoUsuario;
        //public static string direccionUsuario;
        //public static string localidadUsuario;
        public static string razonsocialUsuario;
        public static string telefonoUsuario;
        public static string correoUsuario;
        public static string usuarioNombre;
        public static string passwordUsuario;
        public static string activoUsuarioString;
        public static bool activoUsuario;
        
        
        public static bool permisoRRHH =false;
        public static bool permisoAltaRRHH = false;
        public static bool permisoBajaRRHH = false;
        public static bool permisoModiRRHH = false;
        public static bool permisoConsultaRRHH = false;

        public static bool permisoVENTAS = false;
        public static bool permisoAltaVENTAS = false;
        public static bool permisoModiVENTAS = false;
        public static bool permisoConsultaVENTAS = false;

        public static bool permisoCOMPRAS = false;
        public static bool permisoAltaCOMPRAS = false;
        public static bool permisoModiCOMPRAS = false;
        public static bool permisoConsultaCOMPRAS = false;

        public static bool permisoCONTABLE = false;
        public static bool permisoConsultaCONTABLE = false;

        public static bool Proveedor = false;
        public static bool Usuario = false;
        public static bool Cliente = false;
        public static bool sinTipoPersona = false;

        public static bool altaPersona = false;
        public static bool registrarProv = false;
        public static bool registrarTipoPersona = false;
        public static int altaTipoPersona = 0;
        public static bool registrarPerTipo = false;

        public static bool personaFisica = false;
        public static string verficarCuiloCuit = "";
        public static string tipoPersona = "";
        public static string consultaTipoPersona = "";
        public static int Id_Persona = 0;
        public static int Id_TipoPersona = 0;

        public static bool aceptar = false;
        public static int RegisModif = 0;
        public static int Seleccion = 0;

        public static Button BotonAnterior;

        public static ConexionDB claseConexion = new ConexionDB();

        public static DataTable Tabla = new DataTable();

        SqlCommand comando = new SqlCommand();

       
        public class Proveedores
        {
            public string Cuit_proveedor { get; set; }
            
        }

        public class Usuarios
        {
            public string Cuit_usuario { get; set; }
        }

       
    }
}
