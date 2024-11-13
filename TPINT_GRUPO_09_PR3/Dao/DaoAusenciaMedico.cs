﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Reflection;

namespace Dao
{
    public class DaoAusenciaMedico
    {
        AccesoDatos ds = new AccesoDatos();

        public Boolean existeAusencia(AusenciaMedico aus)
        {
            String consulta = "SELECT * FROM Ausencias_Medicos WHERE Legajo_Medico_AM='" + aus.getLegajoMedico() + "' AND Fecha_Inicio_AM='" + aus.getFechaInicio() + "'";
            return ds.existe(consulta);
        }

        public DataTable getTablaAusencias()
        {
            DataTable tabla = ds.ObtenerTabla("Ausencias_Medicos",
            "SELECT Legajo_Medico_AM, (Me.Nombre_Me + ' ' + Me.Apellido_Me) AS Nombre_Completo, TAM.Descripcion_TAM, " +
            "Fecha_Inicio_AM, Fecha_Fin_AM " +
            "FROM Ausencias_Medicos " +
            "INNER JOIN Tipos_Ausencias_Medicos AS TAM ON Id_Tipo_Ausencia_AM = TAM.Id_Tipo_Ausencia_TAM " +
            "INNER JOIN Medicos AS Me ON Legajo_Medico_AM = Legajo_Me");
            return tabla;
        }

        public int agregarAusencia(AusenciaMedico aus)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarAusencia(ref comando, aus);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarAusencia");
        }

        private void ArmarParametrosAgregarAusencia(ref SqlCommand Comando, AusenciaMedico aus)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@LEGAJO", SqlDbType.Int);
            SqlParametros.Value = aus.getLegajoMedico();
            SqlParametros = Comando.Parameters.Add("@TIPO", SqlDbType.Int);
            SqlParametros.Value = aus.getTipoAusencia();
            SqlParametros = Comando.Parameters.Add("@FECHA_INICIO", SqlDbType.Date);
            SqlParametros.Value = aus.getFechaInicio();
            SqlParametros = Comando.Parameters.Add("@FECHA_FIN", SqlDbType.Date);
            SqlParametros.Value = aus.getFechaFin();
        }

        public DataTable filtrarAusenciasLegajo(string legajo)
        {
            string consulta = "SELECT Legajo_Medico_AM, (Me.Nombre_Me + ' ' + Me.Apellido_Me) AS Nombre_Completo, TAM.Descripcion_TAM, " +
            "Fecha_Inicio_AM, Fecha_Fin_AM " +
            "FROM Ausencias_Medicos " +
            "INNER JOIN Tipos_Ausencias_Medicos AS TAM ON Id_Tipo_Ausencia_AM = TAM.Id_Tipo_Ausencia_TAM " +
            "INNER JOIN Medicos AS Me ON Legajo_Medico_AM = Legajo_Me " +
            "WHERE Legajo_Medico_AM = '" + legajo + "'";
            DataTable tabla = ds.ObtenerTabla("Ausencias_Medicos", consulta);

            return tabla;
        }
    }
}
