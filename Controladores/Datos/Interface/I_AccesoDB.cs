﻿using ConsultorioPrivado.Controlador.Creators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.Interface
{

    //INTERFAZ DE ACCESOS A DATOS
    public interface I_AccesoDB
    {

        DataTable ObtenerPorEntidad(string sp_query);
    
        DataTable ObtenerPorCedula(string sp_query, List<ParametrosCreator> lista);

        DataTable ObtenerPorID(string sp_query, List<ParametrosCreator> lista);
        bool CrearEntidad(string sp_Non_query, List<ParametrosCreator> lista);

        bool EliminarEntidad(string sp_Non_query, List<ParametrosCreator> lista);

        bool ActualizarEntidad(string sp_Non_query, List<ParametrosCreator> lista);


        /*
        DataTable ObtenerPorId(E_ROL rol, List<CD_Parameter_SP> lista);
        DataTable ObtenerPorCedula(E_ROL rol, List<CD_Parameter_SP> lista);
        bool Actualizar(E_ROL rol, List<CD_Parameter_SP> lista);
        bool Eliminar(E_ROL rol, List<CD_Parameter_SP> lista);
        */
    }
}
