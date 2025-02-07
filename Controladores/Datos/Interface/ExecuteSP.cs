﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Controlador.Creators;
using ConsultorioPrivado.Datos.DbOpeaciones;

namespace ConsultorioPrivado.Datos.Interface
{

    //CLASE QUE CREA LOS SP SEGUN LAS ESTRUCTURA DE LAS PETICIONES
    public class ExecuteSP : I_AccesoDB
    {

        private ExecuteQuery obj_bd;
        public ExecuteSP()
        {
            obj_bd = new ExecuteQuery();
            
        }

        public DataTable ObtenerPorEntidad(string sp_query)
        {
            try
            {
                List<ParametrosCreator> lista = new List<ParametrosCreator>();
                return obj_bd.ExecuteSPQuery(sp_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error  al obtener tabla de " + sp_query + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorCedula(string sp_query)
        {
            try
            {
                List<ParametrosCreator> lista = new List<ParametrosCreator>();
                return obj_bd.ExecuteSPQuery(sp_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error  al obtener la cedula del " + sp_query + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorID(string sp_query) {

            try
            {
                List<ParametrosCreator> lista = new List<ParametrosCreator>();
                return obj_bd.ExecuteSPQuery(sp_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error  al obtener tabla de " + sp_query + " " + ex.Message);
            }
        }

        public bool CrearEntidad(string sp_Non_query,List<ParametrosCreator> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(sp_Non_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error  al crear entidad de " + sp_Non_query + " " + ex.Message);
            }
        }

        public bool EliminarEntidad(string sp_Non_query, List<ParametrosCreator> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(sp_Non_query, lista);
            }
            catch (Exception ex) 
            {
                throw new Exception("error al eliminar la entidad de " + sp_Non_query + " " + ex.Message);
            }
        }

        public bool ActualizarEntidad(string sp_Non_query, List<ParametrosCreator> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(sp_Non_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar la entidad " + sp_Non_query + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorCedula(string sp_query, List<ParametrosCreator> lista)
        {
            throw new NotImplementedException();
        }

        public DataTable ObtenerPorID(string sp_query, List<ParametrosCreator> lista)
        {
            throw new NotImplementedException();
        }
        // Ver tabla entidad


        /*
        public DataTable ObtenerPorId(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            //<CD_Parameter_SP> lista = new List<CD_Parameter_SP> ();
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_OBTENER_POR_ID, rol), lista);
        }
        //Crear entidad
        public bool Crear(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_CREAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al guardar un nuevo " + rol + " " + ex.Message);
            }
        }
        //Eliminar entidad
        public bool Eliminar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ELIMINAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar el " + rol + " " + ex.Message);
            }
        }
        //Actualiza entidad
        public bool Actualizar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ACTUALIZAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar el " + rol + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorCedula(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_OBTENER_POR_CEDULA, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el " + rol + " " + ex.Message);
            }
        }

        */
    }
}
