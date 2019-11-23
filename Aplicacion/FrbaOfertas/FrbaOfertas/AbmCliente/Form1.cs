using System;
using System.Collections.Generic;
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
            this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            nombreFiltroTxt.Text = "";
            mailFiltroTxt.Text = "";
            DniFilroTxt.Text = "";
            ApellidoFiltroTxt.Text = "";
            clientes = _clienteService.searchClientes();
            this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            string nombreFiltro = nombreFiltroTxt.Text;
            string apellidoFiltro = ApellidoFiltroTxt.Text;
            string dniFiltro = DniFilroTxt.Text;
            string mailFIltro = mailFiltroTxt.Text;

            clientes = _clienteService.searchClientesByFiltro(nombreFiltro, apellidoFiltro, dniFiltro, mailFIltro );
            this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
        }

        private void ClienteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//ELIMNAR
            {
                Cliente c = (Cliente)ClienteGrid.CurrentRow.DataBoundItem;
                _clienteService.Delete(c.id);
                clientes = _clienteService.searchClientes();
                this.ClienteGrid.DataSource = new BindingSource(clientes, null); 
            }
            else if (e.ColumnIndex == 1)//EDITAR
            {
                Cliente c = (Cliente)ClienteGrid.CurrentRow.DataBoundItem;
                AltaCliente formAlta = new AltaCliente(c,ServiceDependencies.getClienteService());
                this.Hide();
                formAlta.Show();
            }
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
            ABMUsuarioAltaForm altaUser = new ABMUsuarioAltaForm(this, null);
            this.Hide();
            altaUser.Show();
        }
    }
}