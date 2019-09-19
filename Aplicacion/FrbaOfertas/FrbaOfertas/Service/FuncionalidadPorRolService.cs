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

        public List<Rol> searchRoles(string usuario)
        {
            return rolService.searchRoles(usuario);
        }

        public List<Funcionalidad> searchFuncionalidades(Usuario usuario)
        {
            return funcionalidadService.searchFuncionalidad(rol);
        }
    }
}