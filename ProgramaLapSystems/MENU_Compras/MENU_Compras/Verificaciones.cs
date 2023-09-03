using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MENU_Compras
{
    class Verificaciones
    {
        public static void VerificarPersonaFisica()
        {
          Servicio.verficarCuiloCuit =  Servicio.CUIT.Substring(0,2);
          if ((Convert.ToInt32(Servicio.verficarCuiloCuit) == 20) || (Convert.ToInt32(Servicio.verficarCuiloCuit) > 23) && (Convert.ToInt32(Servicio.verficarCuiloCuit) < 30))
          {
              Servicio.personaFisica = true;
          }
          else if ((Convert.ToInt32(Servicio.verficarCuiloCuit) == 30) || (Convert.ToInt32(Servicio.verficarCuiloCuit) == 33) && (Convert.ToInt32(Servicio.verficarCuiloCuit) == 34))

              Servicio.personaFisica = false;
          else

              MessageBox.Show("Error en la identificación del Cuil/Cuit");
               
        }



    }
}
