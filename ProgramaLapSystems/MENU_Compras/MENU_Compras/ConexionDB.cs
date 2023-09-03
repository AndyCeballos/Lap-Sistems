using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace MENU_Compras
{
    class ConexionDB
    {

        static private SqlConnection Conexion;
        static private SqlCommand Comando;

        static string ConexionConDB = ("Data Source=DESKTOP-4JQFO2O\\SQLEXPRESS;Initial Catalog=Lap_System;Integrated Security=True");
    

        //public SqlConnection AbrirConexion()
        //{ 
        //    if (Conexion.State == ConnectionState.Closed)
        //        Conexion.Open();
        //    return Conexion;
        //}

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }


        //método para leer datos de Access
        public SqlDataReader RealizarConsulta(string Consulta)
        {
            //creamos la conexión con la base de datos
            Conexion = new SqlConnection(ConexionConDB);
            //establecemos la consulta dentro de la conexión
            Comando = new SqlCommand(Consulta, Conexion);
            try
            {
                Conexion.Open();//abrimos la conexion

                //ejecutamos la consulta y retornamos el resultado de tipo OleDbDataReader

                return Comando.ExecuteReader();
            }
            catch
            {
                //ante cualquier error en la conexión, se devuelve un valor nulo al DataTable (Tabla)

                SqlDataReader error = null;

                return error;
            }

        }




        public bool VerificacionConsuilta (string Consulta)
        {
            //variable de control
            bool Resultado = false;
            Conexion = new SqlConnection(ConexionConDB);
           Comando = new SqlCommand(Consulta, Conexion);
            try
            {
                Conexion.Open();//abrimos la conexion
                //ejecutamos la consulta
                Comando.ExecuteNonQuery();

                //indicamos que todo se realizó de forma correcta

                Resultado = true;

            }
            catch
            {
                //caso contrario, indicamos que hubo un error
                Resultado = false;
            }
            Comando.Dispose();
            CerrarConexion();//deconectamos
            //devolvemos el valor asignado en la variable de control
            return Resultado;
        }


    }
}
