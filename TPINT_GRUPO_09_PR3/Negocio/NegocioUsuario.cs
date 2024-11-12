﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            // Llamamos al Dao para obtener el usuario
            Usuario usuarioDB = _daoUsuario.ObtenerUsuarioPorCredenciales(usuario, contraseña);
            if (usuarioDB != null)
            {
                // Verificamos el tipo de usuario
                if (usuarioDB.IdTipoUsuario_Us == 1) // Supongamos que 1 es Administrador
                    return "Administrador";
                else if (usuarioDB.IdTipoUsuario_Us == 2) // Supongamos que 2 es Médico
                    return "Médico";
            }

            // Si no se encuentra el usuario o las credenciales son incorrectas
            return "Credenciales incorrectas";
        }


    }
}



