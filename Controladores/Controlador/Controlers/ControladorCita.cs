using ConsultorioPrivado.Controlador.Enums;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Controlers
{
    public class ControladorCita
    {
        private ControladorCreator controladorCreator;

        public ControladorCita() 
        {
            controladorCreator=new ControladorCreator();
        }

        public DataTable ObtenerPorCita()
        {
            return controladorCreator.ObtenerEntidad(E_ROL._CITA);
        }

        public DataTable ObtenerPorId<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorId(entidad, E_ROL._CITA);
        }

        public DataTable ObtenerPorCedula<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorCedula(entidad, E_ROL._CITA);
        }
        public bool CrearCita<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._CITA);
        }

        public bool EliminarCita<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, E_ROL._CITA);
        }

        public bool ActualizarCita<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._CITA);
        }




        //TERMINAR DE AGREGAR 
    }
}
