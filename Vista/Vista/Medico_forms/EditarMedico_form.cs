﻿using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Utilidad.Forms;
using Microsoft.Identity.Client.NativeInterop;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ConsultorioPrivado.Vista
{

    public partial class EditarMedico_form : Form
    {
        private int id;
        ControladorMedico controlador;
        public EditarMedico_form(int id)//ya la
        {
            
            InitializeComponent();
            cedula_text.TextChanged += textBoxes_TextChanged;
            nombre_text.TextChanged += textBoxes_TextChanged;
            apellido_text.TextChanged += textBoxes_TextChanged;
            correoText.TextChanged += textBoxes_TextChanged;
            controlador = new ControladorMedico();
            Button_ControlForms.DesabilitarBotones(resetear_button);
            this.id = id;
            
        }

        private void agregarDatosFormulario()
        {
            
            Medico medico = new Medico();
            medico.Id = id;
            DataTable datosMedicos = controlador.ObtenerPorId<Medico>(medico);
            if (datosMedicos.Rows.Count > 0)
            {
                DataRow row = datosMedicos.Rows[0];
                id_text.Text = row["id"].ToString();
                nombre_text.Text = row["nombre"].ToString();
                apellido_text.Text = row["apellido"].ToString();
                cedula_text.Text = row["cedula"].ToString();
                telefono_text.Text = row["telefono"].ToString();
                correoText.Text = row["correo"].ToString();
                especialidad_combo.SelectedIndex = Convert.ToInt32(row["idEspecialidadFk"].ToString())-1;
            }
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            Medico medico = crearMedicoDatos();
            if(controlador.ActualizarMedico<Medico>(medico))
            {
                vaciarTexts();
                MessageBox.Show("Medico Actualizado");
                this.Close();
            }
        }

        private Medico crearMedicoDatos()
        {
            Medico medico = new Medico();
            medico.Id = Convert.ToInt32(id_text.Text.ToString());
            medico.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            medico.Nombre = nombre_text.Text.ToString();
            medico.Apellido = apellido_text.Text.ToString();
            medico.Correo = correoText.Text.ToString();
            medico.Telefono = Convert.ToInt32(telefono_text.Text);
            medico.Especialidad_id = especialidad_combo.SelectedIndex+1;

            return medico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaciarTexts();
            Button_ControlForms.DesabilitarBotones(resetear_button);
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                resetearButtonEstado(true);
            }
        }

        private void vaciarTexts()
        {
            Text_ControlForms.EliminarTextos(cedula_text, nombre_text, apellido_text, correoText, telefono_text);
            especialidad_combo.SelectedIndex = 0;
        }

        private void resetearButtonEstado(bool estado)
        {
           Button_ControlForms.HabilitarBotones(resetear_button);

        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarMedico_form_Load(object sender, EventArgs e)
        {
            agregarDatosFormulario();
        }
    }
}
