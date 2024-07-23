using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Controlers
{
    //controlador que se encarga de las operaciones tipo CRUD


    public class ControladorMedico
    {
        private ControladorCreator controladorCreator;

        public ControladorMedico()
        {
            controladorCreator = new ControladorCreator();
        }

        public DataTable ObtenerPorMedico()
        {
            return controladorCreator.ObtenerEntidad(E_ROL._MEDICO);
        }

        public DataTable ObtenerPorId<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorId(entidad, E_ROL._MEDICO);
        }

        public DataTable ObtenerPorCedula<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorCedula(entidad, E_ROL._MEDICO);
        }
        public bool CrearMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._MEDICO);
        }

        public bool EliminarMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, E_ROL._MEDICO);
        }

        public bool ActualizarMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._MEDICO);
        }
    }
}
