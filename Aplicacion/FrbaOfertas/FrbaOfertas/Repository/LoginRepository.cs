﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface LoginRepository
    {
        Boolean validateLoginUser(PersonLogin personLogin);
    }
}
