using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using Controladores.Controlador.Controlers;
using Modelo;

namespace ConsultorioPrivado.Vista.Cita_Form
{
    public partial class Agregar_Cita_Form : Form
    {
        //OBJETOS
        private Modelo.Pacientes pacientes;
        private CitaMedica citaMedica;
        private Medico medico;
        private int idTurno;
        private MedicoTurno medicoTurno;

        //CONTROLADORES
        private ControladorCita controladorCita;
        private ControladorTurno controladorTurno;


        public Agregar_Cita_Form()
        {
            InitializeComponent();
            controladorTurno = new ControladorTurno();
            controladorCita = new ControladorCita();
            citaMedica = new CitaMedica();
        }

        private void Agregar_Cita_Form_Load(object sender, EventArgs e)
        {
            //CargarGridTurnos();
            HabilitarEventoReset();
            Button_ControlForms.DesabilitarBotones(resetear_button);
        }

        private void CargarGridTurnos()
        {
            turnos_dgv.DataSource = controladorTurno.ObtenerTurnos();
        }

        private void HabilitarEventoReset()
        {
            Reset_ControlForms.Evento_HabilitarReset(resetear_button, description_text);
        }


        private void agregar_button_Click(object sender, EventArgs e)
        {
            try
            {
                CitaMedica citaMedica = CrearObjetoCitaMedica();
                if (controladorCita.CrearCita(citaMedica))
                    MessageBox.Show("Cita Creada Exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private CitaMedica CrearObjetoCitaMedica()
        {
            citaMedica.IdPaciente = pacientes.Id;
            citaMedica.Descripcion = description_text.Text;
            citaMedica.IdMedicoTurno = idTurno;
            return citaMedica;
        }
        private void combo_Pacientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pacientes = (Modelo.Pacientes)combo_Pacientes.SelectedItem;
        }
        private void combo_Medicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            medico = (Medico)combo_Pacientes.SelectedItem;
            turnos_dgv.DataSource = controladorTurno.ObtenerPorEspecialidad(medico);
        }


        private void resetear_button_Click(object sender, EventArgs e)
        {
            combo_Pacientes.SelectedIndex = -1;
            combo_Medicos.SelectedIndex = -1;
            turnos_dgv.Rows.Clear();
            description_text.Text = string.Empty;

            Button_ControlForms.HabilitarBotones(agregar_button, cancelar_button);
            Button_ControlForms.DesabilitarBotones(cancelar_button);
            Text_ControlForms.EliminarTextos(description_text);

        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void PBx_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBx_Cita_Enter(object sender, EventArgs e)
        {

        }

        private void turnos_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = turnos_dgv.Rows[e.RowIndex];
                idTurno = Convert.ToInt32(selectedRow.Cells["TurnoId"].Value);
                MessageBox.Show("ID del Turno seleccionado: " + idTurno);
            }
        }
    }
}
