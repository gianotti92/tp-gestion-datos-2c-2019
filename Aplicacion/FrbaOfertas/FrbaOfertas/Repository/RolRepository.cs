﻿using System;
using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface RolRepository
    {
        List<Rol> searchRoles(string usuario);
    }
}