using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol.ejecutores;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmRol
{
    public partial class SeleccionarFuncionalidadForm1 : Form
    {
        public SeleccionarFuncionalidadForm1(List<Funcionalidad> funcionalidades)
        {
            InitializeComponent();
            //TODO:pensar un nombre a ejecutar x dios jajaja
            List<BotonFuncionalidadAEjecutar> botonesAEjecutar = generarBotonesCorrespondientes(funcionalidades);
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            foreach (var botonAEjecutar in botonesAEjecutar)
            {
                Button b = new Button();
                b.Text = botonAEjecutar.nombreParaMostrar;
                b.AutoSize = true;
                b.Click += new EventHandler(botonAEjecutar.execute);
                b.Visible = true;
                
                panel.Controls.Add(b);
            }
        }

        private List<BotonFuncionalidadAEjecutar> generarBotonesCorrespondientes(List<Funcionalidad> funcionalidades)
        {
            List<BotonFuncionalidadAEjecutar> listaBotonesFuncionalidadAEjecutar =
                new List<BotonFuncionalidadAEjecutar>();
            foreach (var funcionalidad in funcionalidades)
            {
                if (esProveedorInhabilitadoCrearOfertas(funcionalidad))
                    listaBotonesFuncionalidadAEjecutar.Add(EjecutorFactory.create(funcionalidad, this));
            }

            return listaBotonesFuncionalidadAEjecutar;
        }

        private bool esProveedorInhabilitadoCrearOfertas(Funcionalidad funcionalidad)
        {
            return !(funcionalidad.id == 8 && Utils.UsuarioUtil.Usuario.tipoUsuario == TipoUsuario.PROVEEDOR && !Utils.UsuarioUtil.Usuario.habilitado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form entregaCupon = new ConsumoOferta.ConsumoOferta(ServiceDependencies.getCompraService(), ServiceDependencies.getOfertaService());
            entregaCupon.Show();
        }

        private void SeleccionarFuncionalidadForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();

        }
    }
}