using System.Data;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using System.Collections.Generic;

namespace FrbaOfertas.AbmRol
{
    public partial class MenuRolForm : Form
    {
        public MenuRolForm()
        {
            InitializeComponent();
            List<Rol> roles = new List<Rol>();
            Rol rol = new Rol();
            rol.nombre = "pepe";
            roles.Add(rol);
            this.dataGridView1.DataSource = new BindingSource(roles, null);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}