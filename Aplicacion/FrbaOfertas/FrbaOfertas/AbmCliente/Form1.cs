using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.AbmUsuario;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.AbmCliente
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes;
        private ClienteService _clienteService;
      
        public Form1(ClienteService clienteService)
        {
            this._clienteService = clienteService;
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            clientes = _clienteService.searchClientes();
            //clientes = clientes.Where(clie => estaHabilitado(clie)).ToList();
            this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            nombreFiltroTxt.Text = "";
            mailFiltroTxt.Text = "";
            DniFilroTxt.Text = "";
            ApellidoFiltroTxt.Text = "";
            clientes = _clienteService.searchClientes();
            //clientes = clientes.Where(clie => estaHabilitado(clie)).ToList();
            this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            string nombreFiltro = nombreFiltroTxt.Text;
            string apellidoFiltro = ApellidoFiltroTxt.Text;
            string dniFiltro = DniFilroTxt.Text;
            string mailFIltro = mailFiltroTxt.Text;

            clientes = _clienteService.searchClientesByFiltro(nombreFiltro, apellidoFiltro, dniFiltro, mailFIltro );
            //clientes = clientes.Where(clie => estaHabilitado(clie)).ToList();
            this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
        }

        private void ClienteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//ELIMNAR
            {
                Cliente c = (Cliente)ClienteGrid.CurrentRow.DataBoundItem;
                _clienteService.Delete(c.id);
                clientes = _clienteService.searchClientes();
                //clientes = clientes.Where(cli => estaHabilitado(cli)).ToList();
                this.ClienteGrid.DataSource = new BindingSource(clientes, null);
            }
            else if (e.ColumnIndex == 1)//EDITAR
            {
                Cliente c = (Cliente)ClienteGrid.CurrentRow.DataBoundItem;
                AltaCliente formAlta = new AltaCliente(c, ServiceDependencies.getClienteService());
                this.Hide();
                formAlta.Show();
            }
            else if ((e.ColumnIndex == 2)) //habilitar
            {
                Cliente c = (Cliente)ClienteGrid.CurrentRow.DataBoundItem;
                _clienteService.habilitarCliente(c.id);
                clientes = _clienteService.searchClientes();
                //clientes = clientes.Where(cli => estaHabilitado(cli)).ToList();
                this.ClienteGrid.DataSource = new BindingSource(clientes, null);

            }




        }

        private bool estaHabilitado(Cliente cliente)
        {
            Usuario user = ServiceDependencies.GetUsuarioDao().getUsuario(cliente.usuario);

            return user.habilitado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMUsuarioAltaForm altaUser = new ABMUsuarioAltaForm(false,this, null);
            this.Hide();
            altaUser.Show();
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
    }
}