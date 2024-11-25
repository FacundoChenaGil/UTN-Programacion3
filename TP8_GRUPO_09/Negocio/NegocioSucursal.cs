﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Dao;

namespace Negocio
{
    public class NegocioSucursal
    {
        DaoSucursal daoSucursal = new DaoSucursal();


        public bool AgregarSucursal(Sucursal sucursal)
        {
            // validación si la sucursal ya existe
            if (daoSucursal.existeSucursal(sucursal))
            {
                return false;
            }

            // Llamar al método agregarSucursal de la capa de datos
            int filasAfectadas = daoSucursal.agregarSucursal(sucursal);

            return filasAfectadas > 0; // Si la inserción fue exitosa
        }

        public DataTable ObtenerSucursales()
        {
            try
            {
                // llama al método de la capa de acceso a datos para obtener las sucursales
                return daoSucursal.getTablaSucursales();
            }
            catch (Exception ex)
            {
                // manejo de excepciones, puedes lanzar una excepción personalizada o manejar el error
                throw new Exception("Error al obtener las sucursales: " + ex.Message);
            }
        }

        public DataTable ObtenerSucursalesFiltradas(int id)
        {
            try
            {
                // llama al método de la capa de acceso a datos para obtener las sucursales filtradas
                return daoSucursal.getTablaSucursalesFiltrada(id);
            }
            catch (Exception ex)
            {
                // manejo de excepciones, puedes lanzar una excepción personalizada o manejar el error
                throw new Exception("Error al obtener las sucursales: " + ex.Message);
            }
        }

        public bool eliminarSucursal(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal suc = new Sucursal();
            suc.setIdSucursal(id);
            int op = dao.eliminarSucursal(suc);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean existeId(int id)
        {
            return daoSucursal.existeIdSucursal(id);
        }
    }

}
