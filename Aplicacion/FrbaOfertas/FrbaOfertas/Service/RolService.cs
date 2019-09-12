using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Service
{
    public interface RolService
    {
        int getRolType(PersonLogin personLogin);
    }
}
