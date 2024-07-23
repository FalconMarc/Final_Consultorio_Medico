using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    internal class Reset_ControlForms
    {
        public static void Evento_HabilitarReset(Button resetButton, params TextBox[] textBoxes)
        {
            CargarEventoReset(resetButton,textBoxes);
        }

        private static void CargarEventoReset(Button resetButton, params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox != null)
                {
                    textBox.TextChanged += TextBox_TextChanged;
                    Button_ControlForms.HabilitarBotones(resetButton);
                }
            }
        }

        private static void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                MessageBox.Show("Cambiado con exito");
            }
        }
    }
}
