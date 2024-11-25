﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;

 
namespace Negocio
{
    public class NegocioUsuario
    {
       DaoUsuario _daoUsuario = new DaoUsuario(); // Accedemos al DaoUsuario

        public string VerificarUsuario(string usuario, string contraseña)
        {
            // Validar que el usuario esté en minúsculas
            if (usuario != usuario.ToLower())
            {
                return "El usuario debe ingresarse solo en minúsculas.";
            }
            // Llamamos al Dao para obtener el usuario
            Usuario usuarioDB = _daoUsuario.ObtenerUsuarioPorCredenciales(usuario, contraseña);
            if (usuarioDB != null)
            {
                // Verificamos el tipo de usuario
                if (usuarioDB.IdTipoUsuario_Us == 1) //  1 es admin
                    return "Administrador";
                else if (usuarioDB.IdTipoUsuario_Us == 2) //  2 es medico
                    return "Médico";
            }

            // Si no se encuentra el usuario o las credenciales son incorrectas
            return "Credenciales incorrectas";
        }

        public Boolean existeUsuario(string user)
        {
            return _daoUsuario.existeUsuario(user);
        }

        public Boolean agregarUsuario(Usuario usuario)
        {
            if(_daoUsuario.existeUsuario(usuario.GetUsuarioUs()))
            {
                return false; // Si el usuario ya existe
            }

            int filasAfectadas = _daoUsuario.agregarUsuario(usuario); ;

            return filasAfectadas > 0; // Si la inserción fue exitosa

        }

        public bool CambiarContraseña(string usuario, string email, string nuevaClave)
        {
            // Llamar al método de DaoUsuario para verificar y actualizar la contraseña
            return _daoUsuario.VerificarYActualizarClave(usuario, email, nuevaClave);
            
            
        }

        
            
        
    }


}




