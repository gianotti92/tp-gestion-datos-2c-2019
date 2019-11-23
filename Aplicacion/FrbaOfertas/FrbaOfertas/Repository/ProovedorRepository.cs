using System.Collections.Generic;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public interface ProovedorRepository
    {
        List<Proovedor> searchProovedores();
        void save(Proovedor proveedor);
        Proovedor getProveedor(int idProveedor);
        Proovedor getProveedorConUsuario(string userName);
        List<Proovedor> searchProovedoresPorFiltro(string razonsocialFiltro, string cuitFiltro, string mailFiltro);
        void Delete(int id);
        void update(Proovedor proveedor);
    }
}