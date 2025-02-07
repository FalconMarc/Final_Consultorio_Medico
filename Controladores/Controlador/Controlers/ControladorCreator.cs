﻿using ConsultorioPrivado.Controlador.Creators;
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
    public class ControladorCreator
    {
        private List<ParametrosCreator> lista;
        private CadenaSPCreator executeRolDB;
        private PropiedadesCreator propiedadesCreator;
        private I_AccesoDB accesoDatos;

        public ControladorCreator()
        {
            lista = new List<ParametrosCreator>();
            executeRolDB = new CadenaSPCreator();
            propiedadesCreator = new PropiedadesCreator();
            accesoDatos = new ExecuteSP();
        }

        public DataTable ObtenerEntidad(E_ROL rol)
        {
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR,rol);
            return accesoDatos.ObtenerPorEntidad(procedimientoAlmacenado);
        }

        public DataTable ObtenerPropiedadEspecifica<T>(string propiedad, T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedadesEspecifica(propiedad,entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR, rol);
            return accesoDatos.ObtenerPorEntidad(procedimientoAlmacenado);
        }

        public DataTable ObtenerPorCedula<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR_CEDULA, rol);
            return accesoDatos.ObtenerPorCedula(procedimientoAlmacenado,lista);
        }

        public DataTable ObtenerPorId<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);

            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR_ID,rol);
            return accesoDatos.ObtenerPorID(procedimientoAlmacenado,lista);
        }

        public bool CrearEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_CREAR, rol);
            return accesoDatos.CrearEntidad(procedimientoAlmacenado, lista);
        }

        public bool EliminarEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_ELIMINAR, rol);
            return accesoDatos.EliminarEntidad(procedimientoAlmacenado , lista);
        }

        public bool ActualizarEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_ACTUALIZAR, rol);
            return accesoDatos.ActualizarEntidad(procedimientoAlmacenado, lista);
        }

    }
}
