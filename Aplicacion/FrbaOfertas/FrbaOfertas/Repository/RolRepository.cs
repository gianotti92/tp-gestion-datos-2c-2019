﻿using System;
using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface RolRepository
    {
        void Create(Rol rol);
        List<Rol> searchRoles(string usuario);
    }
}