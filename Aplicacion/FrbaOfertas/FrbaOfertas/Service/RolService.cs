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

        public Rol GetById(int id)
        {
            return rolRepository.GetById(id);
        }

        public void Create(Rol rol)
        {
            rolRepository.Create(rol);
        }

        public void Update(Rol rol)
        {
            rolRepository.Update(rol);
        }
        
        public List<Rol> searchRoles(string nombre, int estado)
        {
            return rolRepository.searchRoles(nombre, estado);
        }

        public List<Rol> searchRoles()
        {
            return rolRepository.searchRoles();
        }

        public void eliminar(Rol rolAEliminar)
        {
            rolRepository.eliminar(rolAEliminar);
        }

        public List<Rol> GetAll()
        {
            return rolRepository.GetAll();
        }
    }
}
