﻿using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface FuncionalidadRepository
    {
        List<Funcionalidad> searchFuncionalidad(Rol rol);
    }
}