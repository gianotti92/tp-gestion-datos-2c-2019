using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Dao;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol
{
    public partial class ModificacionRolViewForm : Form
    {
       
        private FuncionalidadService funcionalidadService;
        private RolService rolService;
        private List<Funcionalidad> funcionalidades;
        private List<Funcionalidad> funcionalidadesSeleccionadas;
        private Rol rolAEditar;
        public ModificacionRolViewForm(Rol rolAEditar, FuncionalidadService funcionalidadService, RolService rolService)
        {
            this.funcionalidadService = funcionalidadService;
            this.rolService = rolService;
            this.rolAEditar = rolAEditar;
            InitializeComponent();
            cargarFuncionalidades();
            cargarHabilitar();
            cargarRolAModificar();
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
            this.habilitadoComboBox.SelectedItem = rolAEditar.activo.ToString();
        }
        
        private void cargarRolAModificar()
        {    
            funcionalidadesSeleccionadas = new List<Funcionalidad>();
            funcionalidadesSeleccionadas = rolAEditar.funcionalidades;
            foreach (var funcionalidad in rolAEditar.funcionalidades)
            {
                this.rolesListBox.Items.Add(funcionalidad.nombre);
            }

            this.nombreTxt.Text = rolAEditar.nombre;
        }
        
        private void AgregarFuncBtn_Click(object sender, EventArgs e)
        {
            int index = this.funcionalidadComboBox.SelectedIndex;
            Funcionalidad f = funcionalidades[index];
            if (!funcionalidadesSeleccionadas.Exists(F => F.id.Equals(f.id)))
            {  
                rolesListBox.Items.Add(f.nombre);
                funcionalidadesSeleccionadas.Add(f);

            }

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
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
            try
            {
                validarCreacion();
                rolAEditar.activo = Boolean.Parse(habilitadoComboBox.Text);
                rolAEditar.funcionalidades = funcionalidadesSeleccionadas;
                rolAEditar.nombre = nombreTxt.Text;
                rolService.Update(rolAEditar);
                this.Hide();

                RolRepository rolRepository = new RolDao();
                FuncionalidadPorRolService funcionalidadPorRolService = new FuncionalidadPorRolService(rolService, new FuncionalidadService(new FuncionalidadDao()));
                AbmRolMenuForm form = new AbmRolMenuForm(rolService, funcionalidadPorRolService);
                form.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmRolMenuForm form = new AbmRolMenuForm(rolService,new FuncionalidadPorRolService(rolService,funcionalidadService));
            this.Hide();
            form.Show();
        }

        private void validarCreacion()
        {

            if (nombreTxt.Text.Equals("") || rolesListBox.Items.Count.Equals(0))
            {
                SystemException ex = new SystemException("Debe completar el nombre y la lista de Funcionalidades");
                throw ex;
            }

        }

        private void ModificacionRolViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}