namespace ConsultorioPrivado.Vista.Cita_Form
{
    public class MedicoTurno
    {
        private int id;
        private int idTurno;
        private int idMedico;
        private bool estado;

        public MedicoTurno()
        {
            id = 0;
            idTurno = 0;
            idMedico = 0;
            estado = false;
        }

        public MedicoTurno(int id, int idTurno, int idMedico, bool estado)
        {
            this.id = id;
            this.idTurno = idTurno;
            this.idMedico = idMedico;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }
        public bool Estado { get => estado; set => estado = value; }
    }

}