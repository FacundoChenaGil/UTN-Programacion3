﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
    public class DaoMedico
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoMedico()
        {

        }

        public int agregarMedico(Medico medico)
        {
            SqlCommand cmd = new SqlCommand();
            ArmarParametrosAgregarMedico(ref cmd, medico);
            return ds.EjecutarProcedimientoAlmacenado(cmd, "spAgregarMedico");
        }

        private void ArmarParametrosAgregarMedico(ref SqlCommand cmd, Medico medico)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = cmd.Parameters.Add("@LEGAJO", SqlDbType.Char);
            SqlParametros.Value = medico.getLegajo();

            SqlParametros = cmd.Parameters.Add("@LOCALIDAD", SqlDbType.Int);
            SqlParametros.Value = medico.getIdLocalidad();

            SqlParametros = cmd.Parameters.Add("@ESPECIALIDAD", SqlDbType.Int);
            SqlParametros.Value = medico.getIdEspecialidad();

            SqlParametros = cmd.Parameters.Add("@NACIONALIDAD", SqlDbType.Int);
            SqlParametros.Value = medico.getNacionalidad();

            SqlParametros = cmd.Parameters.Add("@GENERO", SqlDbType.Int);
            SqlParametros.Value = medico.getGenero();

            SqlParametros = cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar);
            SqlParametros.Value = medico.getUsuario();

            SqlParametros = cmd.Parameters.Add("@DNI", SqlDbType.Char);
            SqlParametros.Value = medico.getDni();

            SqlParametros = cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar);
            SqlParametros.Value = medico.getEmail();

            SqlParametros = cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar);
            SqlParametros.Value = medico.getEmail();

            SqlParametros = cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar);
            SqlParametros.Value = medico.getApellido();

            SqlParametros = cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime);
            SqlParametros.Value = medico.getFechaNacimiento();

            SqlParametros = cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar);
            SqlParametros.Value = medico.getDireccion();

            SqlParametros = cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar);
            SqlParametros.Value = medico.getTelefono();
        }


        public DataTable getMedico()
        {
            string consulta = "SELECT * FROM Medicos";
            return ds.ObtenerTabla("Medicos", consulta);
        }

        public DataTable getMedicoSegunEspecialidad(int id)
        {
            string consulta = "SELECT * FROM Medicos WHERE Id_Especialidad_Me =" + id;
            return ds.ObtenerTabla("Medicos", consulta);
        }
        public Boolean existeMedico(string dni, int idNacionalidad)
        {
            string consulta = "SELECT * FROM Medicos WHERE Estado_Pa = '" + 1 + "' AND Dni_Me = '" + dni + "' AND Id_Nacionalidad_Pa = " + idNacionalidad;
            return ds.existe(consulta);
        }


        public string ObtenerLegajoPorNombreCompleto(string nombreCompleto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);

            DataTable tabla = ds.EjecutarProcedimientoAlmacenadoLectura(comando, "sp_ObtenerLegajoPorNombreCompleto");

            return tabla.Rows.Count > 0 ? tabla.Rows[0]["Legajo_Me"].ToString() : null;
        }



    }








}
