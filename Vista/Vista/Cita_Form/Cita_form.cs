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
using Vista.Utilidad;

namespace ConsultorioPrivado.Vista.Cita_Form
{
    public partial class Cita_form : Form
    {
        public Cita_form()
        {
            InitializeComponent();
           
        }

        private void nuevo_button_Click(object sender, EventArgs e)
        {
            Form formcita = new Agregar_Cita_Form();
            formcita.ShowDialog();
        }

        private void Cita_form_Load(object sender, EventArgs e)
        {
            DGVDisenio.Formato(citas_dgv, 1);
        }
    }
}
