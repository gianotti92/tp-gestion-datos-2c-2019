using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.CrearOferta
{
    public partial class AltaOfertaForm : Form
    {
        private OfertaService ofertaService;
        private ProveedorService proovedorService;

        private List<Proovedor> proovedores;
        private Proovedor proveedor;

        public AltaOfertaForm(OfertaService ofertaService, ProveedorService proovedorService)
        {
            this.ofertaService = ofertaService;
            this.proovedorService = proovedorService;
            InitializeComponent();
            llenarComboProovedor();
        }

        private void llenarComboProovedor()
        {

            if (UsuarioUtil.Usuario.tipoUsuario.Equals(TipoUsuario.PROVEEDOR))
            {

                proveedor = proovedorService.getProveedorConUsuario(UsuarioUtil.Usuario.userName);
                ProovedorCmb.Items.Add( proveedor.razonSocial );
            }
            else
            {
                proovedores = proovedorService.searchProovedores();
                foreach (var proovedor in proovedores)
                {
                    ProovedorCmb.Items.Add(proovedor.razonSocial);
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            AbmOfertasForm form = new AbmOfertasForm(new OfertaService(new OfertaDao()));
            this.Hide();
            form.Show();
        }

        private void CrearBtn_Click_1(object sender, EventArgs e)
        {
            Oferta oferta = new Oferta();
            oferta.descripcion = DescripcionTxt.Text;
            oferta.precio = int.Parse(PrecioTxt.Text);
            oferta.precioLista = int.Parse(PrecioListaTxt.Text);
            oferta.stockDisponible = int.Parse(stockTxt.Text);
            oferta.fechaPublicacion = fechaPublicPicker.Value;
            oferta.fechaVencimiento = fechaVencPicker.Value;
            oferta.cantidadMaximaPorCompra = int.Parse(MaxPorClienteTxt.Text);
            int index = ProovedorCmb.SelectedIndex;
            Proovedor proovedorSeleccionado = proovedores[index];
            oferta.proovedorId = proovedorSeleccionado.id;

            ofertaService.saveOferta(oferta);

        }
    }
}