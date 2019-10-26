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
        private static RolDao RolDao { get; set; }
        private static RolService RolService { get; set; }
        private static UsuarioDao UsuarioDao {get; set;}
        private static UsuarioService UsuarioService {get; set;}

        private static ClienteDao clienteDao { get; set; }
        
        private static ClienteService clienteService { get; set; }

        public static RolDao GetRolDao()
        {
            if (RolDao == null)
            {
                RolDao = new RolDao();
            }
            return RolDao;
        }

        public static RolService GetRolService() 
        {
            if (RolService == null)
            {
                RolDao = GetRolDao();
                RolService = new RolService(RolDao);
            }
            return RolService;
        }

        public static UsuarioDao GetUsuarioDao() 
        {
            if (UsuarioDao == null)
            {
                UsuarioDao = new UsuarioDao();
            }
            return UsuarioDao;
        }

        public static UsuarioService GetUsuarioService()
        {
            if (UsuarioService == null)
            {
                UsuarioDao = GetUsuarioDao();
                UsuarioService = new UsuarioService(UsuarioDao);
            }
            return UsuarioService;
        }

        public static ClienteService getClienteService()
        {
            clienteDao = new ClienteDao();
            return new ClienteService(clienteDao);
        }
    }
}
