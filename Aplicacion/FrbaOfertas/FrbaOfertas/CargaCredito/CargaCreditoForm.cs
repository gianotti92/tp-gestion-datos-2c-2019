using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CargaCredito
{
    public partial class Form1 : Form
    {
        private Usuario Usuario { get { return UsuarioUtil.Usuario; } }
        private ClienteService ClienteService { get { return ServiceDependencies.getClienteService(); } }
        private CargarSalgoService CargarSalgoService { get { return ServiceDependencies.getCargarSalgoService(); } }

        public Form1()
        {
            InitializeComponent();
            CargarCliente();
            CargarTipoCargo();
        }

        private void CargarCliente()
        {
            txtCliente.Text = Usuario.userName;
            txtCliente.Enabled = false;
        }

        private void CargarTipoCargo()
        {
            cbTipoPago.Items.Add("Seleccionar");
            cbTipoPago.Items.Add(TipoPago.CREDITO.ToString());
            cbTipoPago.Items.Add(TipoPago.DEBITO.ToString());
            cbTipoPago.SelectedItem = "Seleccionar";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void Volver()
        {
            this.Hide();
            AbmRol.SeleccionarFuncionalidadForm1 seleccionFuncionalidadForm = new AbmRol.SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidadForm.Show();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            cbTipoPago.SelectedItem = "Seleccionar";
            txtMonto.Text = "";
            txtNumeroTarjeta.Text = "";
            txtNombreTarjeta.Text = "";
            dtpFechaVencimientoTarjeta.Text = DateTime.Now.ToString();
            txtCodigoSeguridad.Text = "";
        }

        private void btnCargarCredito_Click(object sender, EventArgs e)
        {
            if (SonCamposValidos())
            {
                Cliente cliente = ClienteService.GetClienteByUsername(Usuario.userName);
                cliente.saldo += Convert.ToDouble(txtMonto.Text);
                ClienteService.UpdateCliente(cliente);

                CargaSaldo cargaSaldo = new CargaSaldo();
                cargaSaldo.idCliente = cliente.id;
                cargaSaldo.fecha = DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["fecha_dia"]);
                cargaSaldo.monto = Convert.ToDouble(txtMonto.Text);
                cargaSaldo.tipoPago = (TipoPago)(Convert.ToInt32(cbTipoPago.SelectedIndex));
                cargaSaldo.numeroTarjeta = Convert.ToInt32(txtNumeroTarjeta.Text);
                cargaSaldo.nombreTarjeta = txtNombreTarjeta.Text;
                cargaSaldo.fechaVencimientoTarjeta = DateTime.Parse(dtpFechaVencimientoTarjeta.Text);
                cargaSaldo.codigoSeguridadTarjeta = Convert.ToInt32(txtCodigoSeguridad.Text);

                CargarSalgoService.SaveCargarSaldo(cargaSaldo);

                Volver();
            }
        }

        private bool SonCamposValidos()
        {
            bool sonNumericos = true;

            try
            {
                Convert.ToInt32(txtNumeroTarjeta.Text);
                Convert.ToDouble(txtMonto.Text);
                Convert.ToInt32(txtCodigoSeguridad.Text);
            }
            catch (Exception e)
            {
                sonNumericos = false;
            }


            if(txtMonto.Text == "" || txtNumeroTarjeta.Text == "" || txtNombreTarjeta.Text == "" || txtCodigoSeguridad.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios");
                return false;
            }
            if(cbTipoPago.SelectedItem.ToString().Equals("Seleccionar"))
            {
                MessageBox.Show("Debe seleccionar un tipo de pago");
                return false;
            }
            if (sonNumericos && Convert.ToDouble(txtMonto.Text) < 0)
            {
                MessageBox.Show("El monto a acreditar no puede ser negativo");
                return false;
            }

            if (!sonNumericos)
            {
                MessageBox.Show("Campos numericos invalidos");
                return false;  
            }

            return true;
        }
    }
}
