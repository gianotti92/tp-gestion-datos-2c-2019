﻿using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface FuncionalidadRepository
    {
        Funcionalidad GetById(int id);
        List<Funcionalidad> searchFuncionalidad(Usuario usuario);
    }
}