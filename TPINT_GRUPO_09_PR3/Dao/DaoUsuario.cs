﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Dao
{
    public class DaoUsuario
    {
        private AccesoDatos _accesoDatos = new AccesoDatos();
        public DaoUsuario() { }

        public Usuario ObtenerUsuarioPorCredenciales(string usuario, string contraseña)
        {

            // Consulta SQL para obtener el usuario, su clave y el tipo de usuario
            string query = @"
            SELECT u.Usuario_Us, u.Clave_Us, u.Id_Tipo_Usuario_Us, t.Id_Tipo_Usuario_TU
             FROM Usuarios u
            INNER JOIN Tipos_Usuarios t ON u.Id_Tipo_Usuario_Us = t.Id_Tipo_Usuario_TU
             WHERE u.Usuario_Us = @Usuario AND u.Clave_Us = @Contraseña";

            // Crear el comando con los parámetros
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);

            // Usamos el método ObtenerConexion() para obtener la conexión
            SqlConnection conexion = _accesoDatos.ObtenerConexion();
            if (conexion == null)
            {
                // Si no se pudo establecer la conexión, se maneja aquí
                return null;
            }

            // Asignar la conexión al comando
            comando.Connection = conexion;

            // Ejecutar la consulta
            try
            {
                DataTable dt = _accesoDatos.ObtenerTabla(comando); // Ejecutamos la consulta

                // Si se encuentra un usuario
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; // Tomamos la primera fila de los resultados
                    return new Usuario
                    {
                        Usuario_Us = row["Usuario_Us"].ToString(),
                        Clave_Us = row["Clave_Us"].ToString(),
                        IdTipoUsuario_Us = Convert.ToInt32(row["Id_Tipo_Usuario_Us"])
                    };
                }
            }
            finally
            {
                // Asegurarnos de cerrar la conexión después de usarla
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            // Si no se encontró el usuario
            return null;
        }


        public Boolean existeUsuario(string user)
        {
            string consulta = "SELECT * FROM Usuarios WHERE Usuario_Us = '" + user + "'";
            return _accesoDatos.existe(consulta);
        }

        public int agregarUsuario(Usuario user)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarUsuario(ref comando, user);
            return _accesoDatos.EjecutarProcedimientoAlmacenado(comando, "spAgregarUsuario");
        }

        private void ArmarParametrosAgregarUsuario(ref SqlCommand Comando, Usuario user)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@USUARIO", SqlDbType.VarChar, 50);
            SqlParametros.Value = user.GetUsuarioUs();
            SqlParametros = Comando.Parameters.Add("@CLAVE", SqlDbType.VarChar, 80);
            SqlParametros.Value = user.GetClaveUs();
            SqlParametros = Comando.Parameters.Add("@EMAIL", SqlDbType.VarChar, 100);
            SqlParametros.Value = user.GetEmailUs();
            SqlParametros = Comando.Parameters.Add("@TIPO", SqlDbType.Int);
            SqlParametros.Value = user.GetIdTipoUsuario();
        }

        private void ArmarParametrosNuevaClave(ref SqlCommand Comando, string usuario, string email, string nuevaClave)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Usuario", SqlDbType.VarChar, 50);
            SqlParametros.Value = usuario;
            SqlParametros = Comando.Parameters.Add("@NuevaClave", SqlDbType.VarChar, 80);
            SqlParametros.Value = nuevaClave;
            SqlParametros = Comando.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            SqlParametros.Value = email;
        }

        public bool VerificarYActualizarClave(string usuario, string email, string nuevaClave)
        {
            string consulta = @"
            SELECT TU.Id_Tipo_Usuario_TU
            FROM Usuarios U
            INNER JOIN Tipos_Usuarios TU ON U.Id_Tipo_Usuario_Us = TU.Id_Tipo_Usuario_TU
            WHERE U.Usuario_Us = @Usuario AND U.Email_Us = @Email";

            // Crear el comando y agregar los parámetros
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Email", email);

            // Obtener la conexión
            SqlConnection conexion = _accesoDatos.ObtenerConexion();
            if (conexion == null)
            {
                // Si no se pudo establecer la conexión, retornamos false
                return false;
            }

            // Asignar la conexión al comando
            comando.Connection = conexion;

            // Ejecutar la consulta para verificar si existe el usuario y obtener el tipo de usuario
            SqlDataReader reader = comando.ExecuteReader();

            int tipoUsuario = -1; // Variable para almacenar el tipo de usuario
            if (reader.Read())
            {
                tipoUsuario = reader.GetInt32(0); // Obtenemos el valor de Id_Tipo_Usuario_TU
            }

            // Cerrar la conexión y el lector
            reader.Close();
            conexion.Close();

            if (tipoUsuario == 1)
            {
                return false;
                
            }

            if (tipoUsuario == 2)
            {
                // Si el usuario es válido y no es administrador, procedemos a cambiar la clave
                SqlCommand cmdActualizar = new SqlCommand();
                ArmarParametrosNuevaClave(ref cmdActualizar, usuario, email, nuevaClave);

                // Ejecutar el procedimiento almacenado para actualizar la contraseña
                _accesoDatos.EjecutarProcedimientoAlmacenado(cmdActualizar, "ActualizarClave");

                return true; // Contraseña actualizada correctamente
            }

            return false; // Usuario o email no encontrados
        }

        }
    }


