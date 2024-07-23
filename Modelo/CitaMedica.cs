using ConsultorioPrivado.Vista.Cita_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CitaMedica : IEntidad
    {
        private int idCitaMedica;
        private string descripcion;
        private int idPaciente;
        private int idMedicoTurno;

        public CitaMedica()
        {
            IdCitaMedica = 0;
            Descripcion = string.Empty;
            IdPaciente = 0;
            IdMedicoTurno = 0;

        }

        public CitaMedica(int idCitaMedica, string descripcion, int idPaciente, int idMedicoTurno)
        {
            this.idCitaMedica = idCitaMedica;
            this.descripcion = descripcion;
            this.idPaciente = idPaciente;
            this.idMedicoTurno = idMedicoTurno;
        }

        public int IdCitaMedica { get => idCitaMedica; set => idCitaMedica = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedicoTurno { get => idMedicoTurno; set => idMedicoTurno = value; }
    }

}
