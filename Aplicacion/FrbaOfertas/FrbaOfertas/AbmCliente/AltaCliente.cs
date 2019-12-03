﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;

namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private Cliente c;
        private ClienteService _clienteService;
        public AltaCliente(Cliente c, ClienteService clienteService)
        {
            this.c = c;
            this._clienteService = clienteService;
            InitializeComponent();
            llenarCampos();
        }

        private DireccionService direccionService
        {
            get { return ServiceDependencies.getDireccionService(); }
        }
        private void llenarCampos()
        {
            apellidotxt.Text = c.apellido;
            nombreTxt.Text = c.nombre;
            mailTxt.Text = c.mail;
            dniTxt.Text = c.dni.ToString();
            telefonoTxt.Text = c.telefono.ToString();
            fechaNacPicker1.Value = Convert.ToDateTime(c.fechaNac);

            if (c.direccion != null)
            {
                calleTxt.Text = c.direccion.calle;
                nroTxt.Text = c.direccion.nro;
                dptotxt.Text = c.direccion.depto;
                localidadTxt.Text = c.direccion.localidad;
                codigoPostaltxt.Text = Convert.ToString(c.direccion.codigoPostal);
            }
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                    c.apellido = apellidotxt.Text;
                    c.nombre = nombreTxt.Text;
                    c.mail = mailTxt.Text;
                    c.dni = Convert.ToInt32(dniTxt.Text);
                    c.telefono = Convert.ToInt32(telefonoTxt.Text);
                    c.fechaNac = fechaNacPicker1.Text;

                    c.direccion.calle = calleTxt.Text;
                    c.direccion.piso = pisoTxt.Text;
                    c.direccion.nro = nroTxt.Text;
                    c.direccion.depto = dptotxt.Text;
                    c.direccion.localidad = localidadTxt.Text;
                    c.direccion.codigoPostal = codigoPostaltxt.Text;
                    _clienteService.UpdateCliente(c);

                    ServiceDependencies.getDireccionDao().updateDireccion(c.direccion);

                    MessageBox.Show("Usuario actualizado correctamente");

                    Form1 form = new Form1(ServiceDependencies.getClienteService());
                    this.Hide();
                    form.Show();

            }
            else
            {
                MessageBox.Show("Los campos con * son obligatorios y para aquellos que poseen "
                                + "un desplegable, se debe seleccionar una opcion de ellas", "Advertencia");
            }
        }

        private bool isValid()
        {
            Boolean valid = true;

            if (dniTxt.Text.Length > 0)
            {
                for (int i = 0; i < dniTxt.Text.Length; i++)
                {
                    char c = dniTxt.Text[0];
                    if (!char.IsControl(c) && !char.IsDigit(c) && (c != '.'))
                    {
                        valid = false;
                    }
                }
            }

            if (telefonoTxt.Text.Length > 0)
            {
                for (int i = 0; i < telefonoTxt.Text.Length; i++)
                {
                    char c = telefonoTxt.Text[0];
                    if (!char.IsControl(c) && !char.IsDigit(c) && (c != '.'))
                    {
                        valid = false;
                    }
                }
            }

            if (codigoPostaltxt.Text.Length > 0)
            {
                for (int i = 0; i < codigoPostaltxt.Text.Length; i++)
                {
                    char c = codigoPostaltxt.Text[0];
                    if (!char.IsControl(c) && !char.IsDigit(c) && (c != '.'))
                    {
                        valid = false;
                    }
                }
            }

            valid = camposValidos();

            return valid;
        }

        private bool camposValidos()
        {
           return !string.IsNullOrEmpty(nombreTxt.Text) && 
                  !string.IsNullOrEmpty(dniTxt.Text) && 
                  !string.IsNullOrEmpty(mailTxt.Text) && 
                  !string.IsNullOrEmpty(telefonoTxt.Text) && 
                  !string.IsNullOrEmpty(fechaNacPicker1.Text) && 
                  !string.IsNullOrEmpty(calleTxt.Text) && 
                  !string.IsNullOrEmpty(nroTxt.Text) && 
                  !string.IsNullOrEmpty(codigoPostaltxt.Text) && 
                  !string.IsNullOrEmpty(localidadTxt.Text) && 
                  !string.IsNullOrEmpty(apellidotxt.Text);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(ServiceDependencies.getClienteService());
            this.Hide();
            form.Show();
        }
        
    }
}