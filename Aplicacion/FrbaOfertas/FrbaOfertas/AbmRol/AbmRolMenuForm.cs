using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;
using FrbaOfertas.Util;

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
        }

        private void cargarRoles()
        {
            List<Rol> roles = funcionalidadPorRolService.searchRoles();
            this.dataGridView1.DataSource = new BindingSource(roles,null);
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
            DataGridView dgv = (DataGridView)sender;


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
           Form1 seleccionFuncionalidad = new Form1(BotonesMenu.botonesMenu());
           seleccionFuncionalidad.Show();
        }
    }
}
