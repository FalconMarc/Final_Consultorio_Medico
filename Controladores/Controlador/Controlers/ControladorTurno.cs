using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Controlador.Enums;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.Controlador.Controlers
{
    public class ControladorTurno
    {
        private ControladorCreator controladorCreator;

        public ControladorTurno()
        {
            controladorCreator = new ControladorCreator();

        }

        public DataTable ObtenerTurnos()
        {
            return controladorCreator.ObtenerEntidad(E_ROL._MEDICO_TURNO);
        }


        public DataTable ObtenerTurnosPorId<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorId  (entidad,E_ROL._MEDICO_TURNO);
        }


        public DataTable ObtenerPorEspecialidad<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPropiedadEspecifica("Especialidad", entidad, E_ROL._MEDICO_TURNO);
        }


        public bool CrearTurno<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._MEDICO_TURNO);
        }

        public bool EliminarTurno<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, E_ROL._MEDICO_TURNO);
        }


        public bool ActualizarTurno<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._MEDICO_TURNO);
        }
    }

}
