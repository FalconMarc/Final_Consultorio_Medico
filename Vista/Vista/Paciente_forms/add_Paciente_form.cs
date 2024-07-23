using ConsultorioPrivado.Controlador.Controlers;
using Modelo;
using ConsultorioPrivado.Utilidad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class add_Paciente_form : Form
    {
        ControladorPaciente controlador;
        public add_Paciente_form()
        {
            InitializeComponent();
        }
       
        /*private void resetearButtonEstado(bool estado)
        {
            Button_ControlForms.desabilitarHabilitarBotones(estado, resetear_button);

        }
        */

        private Modelo.Pacientes crearPacienteEntidad()
        {
            Modelo.Pacientes paciente = new Modelo.Pacientes();
            paciente.Cedula = Convert.ToInt32(cedula_textBox.Text.ToString());
            paciente.Nombre = nombre_textBox.Text.ToString();
            paciente.Apellido = apellido_textBox.Text.ToString();
            paciente.Correo = correo_textBox.Text.ToString();
            paciente.Telefono = Convert.ToInt32(telefono_textBox.Text);
            return paciente;
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                Button_ControlForms.HabilitarBotones(resetear_button);
            }
        }
        private void vaciarText()
        {
            Text_ControlForms.EliminarTextos(cedula_textBox, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
        }

        private void add_Paciente_form_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {

        }
    }
}
