﻿using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class RolService
    {
        private RolRepository rolRepository;

        public RolService(RolRepository rolRepository)
        {
            this.rolRepository = rolRepository;
        }

        public void Create(Rol rol)
        {
            rolRepository.Create(rol);
        }

        public List<Rol> searchRoles(string usuario)
        {
            return rolRepository.searchRoles(usuario);
        }
    }
}
