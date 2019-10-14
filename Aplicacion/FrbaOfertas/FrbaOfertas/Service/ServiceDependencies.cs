using FrbaOfertas.Dao;
using FrbaOfertas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Service
{
    public static class ServiceDependencies
    {
        private static UsuarioRepository UsuarioDAO {get; set;}
        private static UsuarioService UsuarioService {get; set;}

        public static UsuarioService GetUsuarioService()
        {
            if (UsuarioService == null)
            {
                UsuarioDAO = new UsuarioDao();
                UsuarioService = new UsuarioService(UsuarioDAO);
            }
            return UsuarioService;
        }
    }
}
