using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    public class Button_ControlForms
    {


        
        public static void DesabilitarBotones(params Button[] botones)
        {
            IterarBotones(false, botones);
        }
       
        public static void HabilitarBotones(params Button[] botones)
        {
            IterarBotones(true, botones);
        }

        private static void IterarBotones(bool estado, params Button[] botones)
        {
            foreach (Button button in botones)
            {
                button.Enabled = estado;
            }
        }

    }
}

