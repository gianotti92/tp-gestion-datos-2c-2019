﻿using System;
using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface RolRepository
    {
        Rol GetById(int id);
        void Create(Rol rol);
        void Update(Rol rol);
        List<Rol> searchRoles();
        void eliminar(Rol rolAEliminar);
    }
}