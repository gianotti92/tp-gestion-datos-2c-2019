﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaOfertas.AbmRol;
using FrbaOfertas.Entities;
using FrbaOfertas.Service;
using FrbaOfertas.Utils;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ComprarOfertaForm1 : Form
    {
        private OfertaService ofertaService;
        private ProveedorService proveedorService;
        private ClienteService clienteService;

        private List<Oferta> ofertas;
        
        public ComprarOfertaForm1(OfertaService ofertaService, ProveedorService proveedorService,
            ClienteService clienteService)
        {
            this.ofertaService = ofertaService;
            this.proveedorService = proveedorService;
            this.clienteService = clienteService;
            InitializeComponent();
            inicializarFiltro();
            cargarDataGrid();
        }

        private void inicializarFiltro()
        {
            List<Proovedor> proveedores = proveedorService.searchProovedores();
            filtroProvCombo.Items.Add("Seleccionar");
            filtroProvCombo.SelectedIndex = 0;
            proveedores.ForEach(p => filtroProvCombo.Items.Add(p.razonSocial));
        }


        private void cargarDataGrid()
        {
            ofertas = ofertaService.searchOfertasVigentes();
            compraOfertaDgw.DataSource = new BindingSource(ofertas, null);
        }
        
        private void volverBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionarFuncionalidadForm1 seleccionFuncionalidad =
                new SeleccionarFuncionalidadForm1(FuncionalidadUtil.Funcionalidades);
            seleccionFuncionalidad.Show();
        }
        
        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            inicializarFiltro();
            cargarDataGrid();
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filtroDescTxt.Text) || filtroProvCombo.SelectedIndex != 0)
            {
                string text = filtroDescTxt.Text;
                int provId = filtroProvCombo.SelectedIndex;
                ofertas = ofertaService.searchOfertasVigentes(text, provId);
                compraOfertaDgw.DataSource = new BindingSource(ofertas, null);
            }
        }

        private void compraOfertaDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = clienteService.GetClienteByUsername(UsuarioUtil.Usuario.userName);
            
            
            Oferta ofertaSeleccionada = ofertas[e.ColumnIndex];
            string fechaDia = System.Configuration.ConfigurationManager.AppSettings.Get("fecha_dia");
            string nombreApellido = cliente.nombre + " " + cliente.apellido;

            if (!isCompraValida(ofertaSeleccionada))
            {
                MessageBox.Show("No se pudo comprar por falta de stock");
            }
            MessageBox.Show("Compra finalizada con exito, cod compra : 12323");
        }

        private bool isCompraValida(Oferta ofertaSeleccionada)
        {
            return ofertaSeleccionada.stockDisponible > 0;
        }
    }
}