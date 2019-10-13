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

namespace FrbaOfertas.AbmRol
{
    public partial class AbmRolMenuForm : Form
    {
        public AbmRolMenuForm()
        {
            InitializeComponent();
            cargarRoles();
        }

        private void cargarRoles()
        {
            RolRepository rolRepository = new RolDao();
            RolService rolService = new RolService(rolRepository);
            FuncionalidadPorRolService funcionalidadPorRolService = new FuncionalidadPorRolService(rolService, new FuncionalidadService(new FuncionalidadDao()));
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
    }
}
