﻿using System;
using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Service
{
    public class FuncionalidadPorRolService
    {
        private RolService rolService;
        private FuncionalidadService funcionalidadService;

        public FuncionalidadPorRolService(RolService rolService, FuncionalidadService funcionalidadService)
        {
            this.rolService = rolService;
            this.funcionalidadService = funcionalidadService;
        }
        
        public Rol GetRolById(int id)
        {
            return rolService.GetById(id);
        }
        
        public void CreateRol(Rol rol)
        {
            rolService.Create(rol);
        }

        public void UpdateRol(Rol rol)
        {
            rolService.Update(rol);
        }

        public List<Rol> searchRoles()
        {
            return rolService.searchRoles();
        }
        
        public List<Rol> searchRoles(string nombre, int estado)
        {
            return rolService.searchRoles(nombre, estado);
        }

        public Funcionalidad GetFuncionalidadById(int id)
        {
            return funcionalidadService.GetById(id);
        }

        public List<Funcionalidad> searchFuncionalidades(Usuario usuario)
        {   
            return funcionalidadService.searchFuncionalidad(usuario);
        }

        public List<Funcionalidad> searchFuncionalidades(long rolId)
        {
            return funcionalidadService.searchFuncionalidad(rolId);
        }
    }
}