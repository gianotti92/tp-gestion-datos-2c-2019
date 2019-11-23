using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.AbmUsuario;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.AbmProveedor
{
    public partial class Form1 : Form
    {
        private List<Proovedor> proveedores;
        private ProveedorService _proveedorService;
        public Form1(ProveedorService proveedorService)
        {
            this._proveedorService = proveedorService;
            InitializeComponent();
            llenarDatagrid();
        }

        private void llenarDatagrid()
        {
            proveedores = _proveedorService.searchProovedores();
            ProvGrid.DataSource = new BindingSource(proveedores, null);
        }

        private void ClienteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)//ELIMNAR
            {
                Proovedor c = (Proovedor)ProvGrid.CurrentRow.DataBoundItem;
                _proveedorService.Delete(c.id);
                proveedores = _proveedorService.searchProovedores();
                ProvGrid.DataSource = new BindingSource(proveedores, null);
            }
            else if (e.ColumnIndex == 1)//EDITAR
            {
                Proovedor c = (Proovedor)ProvGrid.CurrentRow.DataBoundItem;
                AltaProovedorForm formAlta = new AltaProovedorForm(c, ServiceDependencies.GetCiudadService(),
                    ServiceDependencies.getRubroService(), ServiceDependencies.getDireccionService(), ServiceDependencies.getProveedorService());
                this.Hide();
                formAlta.Show();
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            razonSocialFiltroTxt.Text = "";
            CuitFiltroTxt.Text = "";
            mailFiltroTxt.Text = "";
            
            proveedores = _proveedorService.searchProovedores();
            ProvGrid.DataSource = new BindingSource(proveedores, null);
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            string razonsocialFiltro = razonSocialFiltroTxt.Text;
            string cuitFiltro = CuitFiltroTxt.Text;
            string mailFiltro = mailFiltroTxt.Text;
            proveedores = _proveedorService.searchProovedoresPorFiltro(razonsocialFiltro, cuitFiltro, mailFiltro);
            ProvGrid.DataSource = new BindingSource(proveedores, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMUsuarioAltaForm altaUser = new ABMUsuarioAltaForm(null, this);
            this.Hide();
            altaUser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }
    }
}
