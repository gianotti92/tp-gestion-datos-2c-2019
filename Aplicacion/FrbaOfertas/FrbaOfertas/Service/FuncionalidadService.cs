﻿﻿using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class FuncionalidadService
    {
        private FuncionalidadRepository funcionalidadRepository;

        public FuncionalidadService(FuncionalidadRepository funcionalidadRepository)
        {
            this.funcionalidadRepository = funcionalidadRepository;
        }

        public List<Funcionalidad> searchFuncionalidad(Usuario usuario)
        {
            return funcionalidadRepository.searchFuncionalidad(usuario);
        }
    }
}