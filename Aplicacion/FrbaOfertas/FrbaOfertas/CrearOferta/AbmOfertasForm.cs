using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.CrearOferta
{
    public partial class AbmOfertasForm : Form
    {
        private OfertaService ofertaService;
        private ProveedorService proovedorService;
        private Proovedor proveedor;

        public AbmOfertasForm(OfertaService ofertaService, ProveedorService proovedorService)
        {
            this.ofertaService = ofertaService;
            this.proovedorService = proovedorService;
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            List<Oferta> ofertas;

            if (UsuarioUtil.Usuario.tipoUsuario.Equals(TipoUsuario.PROVEEDOR))
            {
                proveedor = proovedorService.getProveedorConUsuario(UsuarioUtil.Usuario.userName);

                ofertas = ofertaService.searchOfertasByProveedor(proveedor.id);
                OfertaDataGridView.DataSource = new BindingSource(ofertas, null);
            }


    
            else
            {
                ofertas = ofertaService.searchOfertas();
                OfertaDataGridView.DataSource = new BindingSource(ofertas, null);
            }
        }

        private void crearOfertaBtn_Click(object sender, EventArgs e)
        {
            AltaOfertaForm altaOfertaForm = new AltaOfertaForm(new OfertaService(new OfertaDao()), new ProveedorService(new ProveedorDao()));
            this.Hide();
            altaOfertaForm.Show();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }

        private void AbmOfertasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}