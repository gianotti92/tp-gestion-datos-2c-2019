using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.AbmRol
{
    public partial class AbmRolMenuForm : Form
    {
        private FuncionalidadPorRolService funcionalidadPorRolService;
        private RolService rolService;

        public AbmRolMenuForm(RolService rolService, FuncionalidadPorRolService funcionalidadPorRolService)
        {
            this.funcionalidadPorRolService = funcionalidadPorRolService;
            this.rolService = rolService;
            InitializeComponent();
            cargarRoles();
            iniciarFiltro();
        }

        private void cargarRoles()
        {
            List<Rol> roles = funcionalidadPorRolService.searchRoles();
            this.dataGridView1.DataSource = new BindingSource(roles, null);
        }

        private void iniciarFiltro()
        {
            estadoCombo.Items.Add("Seleccionar");
            estadoCombo.Items.Add("Activo");
            estadoCombo.Items.Add("Inactivo");
            estadoCombo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionalidadService funcionalidadService =
                new FuncionalidadService(new FuncionalidadDao());
            AltaRolViewForm form = new AltaRolViewForm(funcionalidadService, new RolService(new RolDao()));
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;


            //use index in your gridView
            if (e.ColumnIndex == 0)
            {
                Rol rolAEliminar = (Rol) dataGridView1.CurrentRow.DataBoundItem;
                rolService.eliminar(rolAEliminar);
                cargarRoles();
            }
            else if (e.ColumnIndex == 1)
            {
                Rol rolAEditar = (Rol) dataGridView1.CurrentRow.DataBoundItem;
                rolAEditar = rolService.GetById(rolAEditar.id);
                ModificacionRolViewForm form = new ModificacionRolViewForm(rolAEditar,
                    new FuncionalidadService(new FuncionalidadDao()), rolService);
                this.Hide();
                form.Show();
            }
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }

        private void limpiarBtn_Click_1(object sender, EventArgs e)
        {
            filtroNombretxt.Text = "";
            estadoCombo.SelectedIndex = 0;
            cargarRoles();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            string filtroNombre = filtroNombretxt.Text;
            int estado = estadoCombo.SelectedIndex;



            if (!string.IsNullOrEmpty(filtroNombre) || esEstadoValido(estado))
            {
                
               
                List<Rol> roles = funcionalidadPorRolService.searchRoles(filtroNombre, estado);
                this.dataGridView1.DataSource = new BindingSource(roles, null);
                
                
            }
        }
        
        private bool esEstadoValido(int estado)
        {
            return estado == 1 || estado == 2;
        }

        private void AbmRolMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}