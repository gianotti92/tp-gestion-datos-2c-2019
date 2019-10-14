using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol
{
    public partial class AltaRolViewForm : Form
    {
        private FuncionalidadService funcionalidadService;
        private RolService rolService;
        private List<Funcionalidad> funcionalidades;
        private List<Funcionalidad> funcionalidadesSeleccionadas;
        public AltaRolViewForm(FuncionalidadService funcionalidadService, RolService rolService)
        {
            this.funcionalidadService = funcionalidadService;
            this.rolService = rolService;
            InitializeComponent();
            cargarFuncionalidades();
            cargarHabilitar();
            funcionalidadesSeleccionadas = new List<Funcionalidad>();
        }

        private void cargarFuncionalidades()
        {
            funcionalidades = funcionalidadService.searchFuncionalidades();
            foreach (var f in funcionalidades)
            {
                this.funcionalidadComboBox.Items.Add(f.nombre);
            }
        }

        private void cargarHabilitar()
        {
            this.habilitadoComboBox.Items.Add("True");
            this.habilitadoComboBox.Items.Add("False");
            this.habilitadoComboBox.SelectedItem = "True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = this.funcionalidadComboBox.SelectedIndex;
            Funcionalidad f = funcionalidades[index];
            rolesListBox.Items.Add(f.nombre);
            funcionalidadesSeleccionadas.Add(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = rolesListBox.SelectedIndex;
          
            if (funcionalidades.Count > 0 && index != -1)
            {
                Funcionalidad f = funcionalidadesSeleccionadas[index];
                funcionalidadesSeleccionadas.Remove(f);
                rolesListBox.Items.RemoveAt(index);
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rol rolAGuardar = new Rol();
            rolAGuardar.activo = Boolean.Parse(habilitadoComboBox.Text);
            rolAGuardar.funcionalidades = funcionalidadesSeleccionadas;
            rolAGuardar.nombre = nombreTxt.Text; 
            rolService.Create(rolAGuardar);
            this.Hide();
            
            RolRepository rolRepository = new RolDao();
            FuncionalidadPorRolService funcionalidadPorRolService = new FuncionalidadPorRolService(rolService, new FuncionalidadService(new FuncionalidadDao()));
            AbmRolMenuForm form = new AbmRolMenuForm(rolService,funcionalidadPorRolService);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmRolMenuForm form = new AbmRolMenuForm(rolService, new FuncionalidadPorRolService(rolService,funcionalidadService));
            form.Show();
        }
    }
}