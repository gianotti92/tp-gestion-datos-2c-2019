using System;
using System.Collections.Generic;
using System.Configuration;
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
        private DateTime fechaDelDia = DateTime.Parse(ConfigurationManager.AppSettings["fecha_dia"]);


        public AltaOfertaForm(OfertaService ofertaService, ProveedorService proovedorService)
        {
            this.ofertaService = ofertaService;
            this.proovedorService = proovedorService;
            InitializeComponent();
            llenarComboProovedor();
            fechaPublicPicker.Value = fechaDelDia;
            fechaPublicPicker.MinDate = fechaDelDia;
            fechaVencPicker.Value = fechaDelDia;
            fechaVencPicker.MinDate = fechaDelDia;
        }

        private void llenarComboProovedor()
        {
            ProovedorCmb.DropDownStyle = ComboBoxStyle.DropDownList;


            if (UsuarioUtil.Usuario.tipoUsuario.Equals(TipoUsuario.PROVEEDOR))
            {


                proveedor = proovedorService.getProveedorConUsuario(UsuarioUtil.Usuario.userName);
                proovedores = new List<Proovedor> { proveedor };
                 
                proovedorBindingSource.DataSource = proovedores;

                //ProovedorCmb.Items.Add( proveedor );
       


            }
            else
            {
                proovedores = proovedorService.searchProovedores();
                //foreach (var proovedor in proovedores)
                //{
                //    ProovedorCmb.Items.Add(proovedor.razonSocial);
                //}
                proovedorBindingSource.DataSource = proovedores;

            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            AbmOfertasForm form = new AbmOfertasForm(new OfertaService(new OfertaDao()), new ProveedorService(new ProveedorDao()));
            this.Hide();
            form.Show();
        }

        private void CrearBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                validarDatosOferta();
                Oferta oferta = new Oferta();
                oferta.descripcion = DescripcionTxt.Text;
                oferta.precio = int.Parse(PrecioTxt.Text);
                oferta.precioLista = int.Parse(PrecioListaTxt.Text);
                oferta.stockDisponible = int.Parse(stockTxt.Text);
                // fecha debe ser igual o mayor a la fecha actual
                oferta.fechaPublicacion = fechaPublicPicker.Value;
                oferta.fechaVencimiento = fechaVencPicker.Value;
                oferta.cantidadMaximaPorCompra = int.Parse(MaxPorClienteTxt.Text);
                Proovedor proovedorSeleccionado = (Proovedor) ProovedorCmb.SelectedItem;

                oferta.proovedorId = proovedorSeleccionado.id;

                oferta.id = ofertaService.saveOferta(oferta);

                MessageBox.Show("Se creo la oferta N°: " + oferta.id.ToString(), "Oferta Creada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                AbmOfertasForm form = new AbmOfertasForm(new OfertaService(new OfertaDao()),
                    new ProveedorService(new ProveedorDao()));
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void validarDatosOferta()
        {
            SystemException ex = null;
            if (string.IsNullOrEmpty(DescripcionTxt.Text)) 
                ex = new SystemException("Descripción es obligatorio");
            if (string.IsNullOrEmpty(stockTxt.Text)) 
                ex = new SystemException("Stock Disponible es obligatorio");
            if (string.IsNullOrEmpty(MaxPorClienteTxt.Text)) 
                ex = new SystemException("Cantidad Maxima por Cliente es obligatorio");
            if (string.IsNullOrEmpty(PrecioListaTxt.Text)) 
                ex = new SystemException("Precio de Lista es obligatorio");
            if (string.IsNullOrEmpty(PrecioTxt.Text)) 
                ex = new SystemException("Precio de Oferta es obligatorio");
            if (ex != null) throw ex;
        }

        private void PrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros Decimales1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))


            {

                MessageBox.Show("Solo se permiten numeros Decimales2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void PrecioListaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                MessageBox.Show("Solo se permiten numeros Enteros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }


        }
        private void AltaOfertaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}