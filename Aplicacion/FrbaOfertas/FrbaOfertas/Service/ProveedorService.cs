using System;
using System.Collections.Generic;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Service
{
    public class ProveedorService
    {
        private ProovedorRepository proovedorRepository;

        public ProveedorService(ProovedorRepository proovedorRepository)
        {
            this.proovedorRepository = proovedorRepository;
        }

        public Proovedor getProveedor (int idProveedor)
        {
             return proovedorRepository.getProveedor(idProveedor);
        }

        public List<Proovedor> searchProovedores()
        {
            return proovedorRepository.searchProovedores();
        }

        public void save(Proovedor proveedor)
        {
            proovedorRepository.save(proveedor);
        }

        public Proovedor getProveedorConUsuario(string userName)
        {
            return proovedorRepository.getProveedorConUsuario(userName);
        }

        public List<Proovedor> searchProovedoresPorFiltro(string razonsocialFiltro, string cuitFiltro, string mailFiltro)
        {
            return proovedorRepository.searchProovedoresPorFiltro(razonsocialFiltro, cuitFiltro, mailFiltro);
        }

        public void Delete(int id)
        {
            proovedorRepository.Delete(id);
        }

        public void update(Proovedor proveedor)
        {
            proovedorRepository.update(proveedor);
        }

        public bool esRazonSocialRepetido(string razonSocial)
        {
            return proovedorRepository.esRazonSocialRepetido(razonSocial);
        }

        public bool esCUITRepetido(string cuit)
        {
            return proovedorRepository.esCUITRepetido(cuit);
        }
    }
}