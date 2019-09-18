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

        public List<Funcionalidad> searchFuncionalidades(List<Rol> roles)
        {
            if (roles.Count <= 0)
            {
                throw new Exception("che loco no hay roles...");
            }

            List<Funcionalidad> funcionalidadesTotalesParaTodosLosRoles = new List<Funcionalidad>();
            foreach (var rol in roles)
            {
                funcionalidadesTotalesParaTodosLosRoles.AddRange(funcionalidadService.searchFuncionalidad(rol));
            }

            return funcionalidadesTotalesParaTodosLosRoles;
        }
    }
}