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
        private static FacturaDao facturaDao { get; set; }
        private static RolService RolService { get; set; }
        private static UsuarioDao UsuarioDao {get; set;}

        private static FuncionalidadPorRolService _funcionalidadPorRolService { get; set; }

        private static FuncionalidadService FuncionalidadService{ get; set; }

        private static UsuarioLoginService _usuarioLoginService { get; set; }

        private static OfertaService ofertaService { get; set; }
        private static UsuarioService UsuarioService {get; set;}
        private static DireccionService direccionService { get; set; }
        private static ProveedorService _proveedorService { get; set; }
        private static DireccionDao direccionDao { get; set; }
        private static ClienteDao clienteDao { get; set; }
        private static ClienteService clienteService { get; set; }
        private static CiudadService ciudadService { get; set; }
        private static RubroService rubroService { get; set; }
        private static FacturaService facturaService { get; set; }
        private static CiudadDao ciudadDao { get; set; }
        private static RubroDao _rubroDao { get; set; }
        private static CargarSaldoDao CargarSaldoDao { get; set; }
        private static CargarSalgoService CargarSaldoService { get; set; }
        
        private static ProveedorDao _proveedorDao { get; set; }
        private static OfertaDao ofertaDao { get; set; }
        private static CompraDao compraDao { get; set; }
        private static CompraService compraService { get; set; }

        private static ListadosDao listadoDao { get; set; }
        private static ListadoService listadoService { get; set; }

        private static FuncionalidadDao _funcionalidadDao { get; set; }

        public static FuncionalidadDao getFuncionalidadDao()
        {
            if (_funcionalidadDao == null)
            {
                _funcionalidadDao = new FuncionalidadDao();
            }

            return _funcionalidadDao;
        }

        public static RolDao GetRolDao()
        {
            if (RolDao == null)
            {
                RolDao = new RolDao();
            }
            return RolDao;
        }

        public static FacturaDao getFacturaDao()
        {
            if (facturaDao == null)
            {
                facturaDao = new FacturaDao();
            }

            return facturaDao;
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

        public static DireccionDao getDireccionDao()
        {
            if (direccionDao == null)
            {
                direccionDao = new DireccionDao();
            }
            return direccionDao;
        }

        public static DireccionService getDireccionService()
        {
            direccionDao = new DireccionDao();
            return new DireccionService(direccionDao);
        }

        public static RubroService getRubroService()
        {
            _rubroDao = new RubroDao();
            return new RubroService(_rubroDao);
        }

        public static CiudadService GetCiudadService()
        {
            ciudadDao = new CiudadDao();
            return new CiudadService(ciudadDao);
        }
        
        public static ProveedorService getProveedorService()
        {
            _proveedorDao = new ProveedorDao();
            return new ProveedorService(_proveedorDao);
        }

        public static CargarSaldoDao getCargaSaldoDao()
        {
            if (CargarSaldoDao == null)
            {
                CargarSaldoDao = new CargarSaldoDao();
            }
            return CargarSaldoDao;
        }

        public static CargarSalgoService getCargarSalgoService()
        {
            if (CargarSaldoService == null)
            {
                CargarSaldoDao = getCargaSaldoDao();
                CargarSaldoService = new CargarSalgoService(CargarSaldoDao);
            }
            return CargarSaldoService;
        }

        public static OfertaService getOfertaService()
        {
            if (ofertaService == null)
            {
                ofertaDao = new OfertaDao();
                ofertaService = new OfertaService(ofertaDao);
            }

            return ofertaService;
        }

        public static FacturaService getFacturaService()
        {
            if (facturaService == null)
            {
                facturaService = new FacturaService(getFacturaDao());
            }

            return facturaService;
        }

        public static CompraDao getCompraDao()
        {
            if (compraDao == null)
            {
                compraDao = new CompraDao();
            }

            return compraDao;
        }

        public static CompraService getCompraService()
        {
            if (compraService == null)
            {
                compraDao = getCompraDao();
                compraService = new CompraService(compraDao);
            }
            return compraService;
        }

        public static ListadosDao getListadoDao()
        {
            if (listadoDao == null)
            {
                listadoDao = new ListadosDao();
            }

            return listadoDao;
        }

        public static ListadoService getListadoService()
        {
            if (listadoService == null)
            {
                listadoDao = getListadoDao();
                listadoService = new ListadoService(listadoDao);
            }
            return listadoService;
        }

        public static UsuarioLoginService getUsuarioLoginService()
        {
            if (_usuarioLoginService == null)
            {
                _usuarioLoginService = new UsuarioLoginService(getFuncionalidadService(), GetRolService(),
                    GetUsuarioService());
            }

            return _usuarioLoginService;
        }

        public static FuncionalidadService getFuncionalidadService()
        {
            if (FuncionalidadService == null)
            {
                FuncionalidadService = new FuncionalidadService(getFuncionalidadDao());
            }
            return FuncionalidadService;
        }

        public static FuncionalidadPorRolService getFuncionalidadPorRolService()
        {
            if (_funcionalidadPorRolService == null)
            {
                _funcionalidadPorRolService = new FuncionalidadPorRolService(GetRolService(), getFuncionalidadService());
            }

            return _funcionalidadPorRolService;
        }
    }
}
