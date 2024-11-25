﻿using Dao;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPaciente
    {
        DaoPaciente dao = new DaoPaciente();
        public bool agregarPaciente(string dni, string nombre, string apellido, int sexo, DateTime fecha, int idnacionalidad, int idlocalidad, string direccion, string email, string telefono, Boolean estado)
        {
            int cantFilas = 0;
            Paciente paciente = new Paciente();

            paciente.setDni(dni);
            paciente.setNombre(nombre);
            paciente.setApellido(apellido);
            paciente.setGenero(sexo);
            paciente.setFechaNacimiento(fecha);
            paciente.setNacionalidad(idnacionalidad);
            paciente.setLocalidad(idlocalidad);
            paciente.setDireccion(direccion);
            paciente.setEmail(email);
            paciente.setTelefono(telefono);
            paciente.setEstado(estado);

            cantFilas = dao.agregarPaciente(paciente);
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarPaciente(string dni, string nombre, string apellido, int sexo, DateTime fecha, int idnacionalidad, int idlocalidad, string direccion, string email, string telefono, Boolean estado)
        {
            int cantFilas = 0;
            Paciente paciente = new Paciente();

            paciente.setDni(dni);
            paciente.setNombre(nombre);
            paciente.setApellido(apellido);
            paciente.setGenero(sexo);
            paciente.setFechaNacimiento(fecha);
            paciente.setNacionalidad(idnacionalidad);
            paciente.setLocalidad(idlocalidad);
            paciente.setDireccion(direccion);
            paciente.setEmail(email);
            paciente.setTelefono(telefono);
            paciente.setEstado(estado);

            cantFilas = dao.ActualizarPaciente(paciente);
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool bajaPaciente(string dni, int idnacionalidad)
        {
            int cantFilas = 0;
            Paciente paciente = new Paciente();

            paciente.setDni(dni);
            paciente.setNacionalidad(idnacionalidad);

            cantFilas = dao.bajaPaciente(paciente);
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getPaciente(string dni, int idNacionalidad)
        {
            return dao.filtrarPaciente(dni, idNacionalidad); 
        }

        public DataTable getPacientes()
        {
            return dao.filtrarPacientes();
        }

        public Boolean existePaciente(string dni, int idNacionalidad)
        {
            return dao.existePaciente(dni, idNacionalidad);
        }

        public Boolean existePacienteDni(string dni)
        {
            return dao.existePacienteDni(dni);
        }

        public Boolean existeEmail(string email)
        {
            return dao.existeEmail(email);
        }

        public int ObtenerLocalidadPorDNI(string dniPaciente)
        {
            return dao.ObtenerLocalidadPorDNI(dniPaciente);
        }

        public int ObtenerNacionalidadPorDNI(string dniPaciente)
        {
            return dao.ObtenerNacionalidadPorDNI(dniPaciente);
        }
    }
}
