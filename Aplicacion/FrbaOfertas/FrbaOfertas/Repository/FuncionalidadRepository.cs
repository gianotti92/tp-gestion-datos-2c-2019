﻿using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface FuncionalidadRepository
    {
        List<Funcionalidad> searchFuncionalidad(Usuario usuario);
        Funcionalidad GetById(int id);
    }
}