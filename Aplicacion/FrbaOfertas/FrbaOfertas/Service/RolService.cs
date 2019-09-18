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
            rolRepository = rolRepository;
        }

        public List<Rol> searchRoles(string usuario)
        {
            return rolRepository.searchRoles(usuario);
        }
    }
}
