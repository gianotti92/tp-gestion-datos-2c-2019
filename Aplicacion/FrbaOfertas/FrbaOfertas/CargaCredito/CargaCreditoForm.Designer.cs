﻿namespace FrbaOfertas.CargaCredito
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCargaCredito = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbDatosTarjeta = new System.Windows.Forms.GroupBox();
            this.dtpFechaVencimientoTarjeta = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.lblCodigoSeguridadTarjeta = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtNombreTarjeta = new System.Windows.Forms.TextBox();
            this.lblNombreTarjeta = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargarCredito = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gbCargaCredito.SuspendLayout();
            this.gbDatosTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargaCredito
            // 
            this.gbCargaCredito.Controls.Add(this.txtMonto);
            this.gbCargaCredito.Controls.Add(this.lblMonto);
            this.gbCargaCredito.Controls.Add(this.cbTipoPago);
            this.gbCargaCredito.Controls.Add(this.lblTipoPago);
            this.gbCargaCredito.Controls.Add(this.txtCliente);
            this.gbCargaCredito.Controls.Add(this.lblCliente);
            this.gbCargaCredito.Location = new System.Drawing.Point(39, 32);
            this.gbCargaCredito.Name = "gbCargaCredito";
            this.gbCargaCredito.Size = new System.Drawing.Size(566, 210);
            this.gbCargaCredito.TabIndex = 0;
            this.gbCargaCredito.TabStop = false;
            this.gbCargaCredito.Text = "Datos carga crédito";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(189, 158);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(326, 26);
            this.txtMonto.TabIndex = 7;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(23, 161);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(54, 20);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(189, 97);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(326, 28);
            this.cbTipoPago.TabIndex = 5;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(23, 100);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(76, 20);
            this.lblTipoPago.TabIndex = 4;
            this.lblTipoPago.Text = "TipoPago";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(189, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(326, 26);
            this.txtCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(23, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // gbDatosTarjeta
            // 
            this.gbDatosTarjeta.Controls.Add(this.dtpFechaVencimientoTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.txtCodigoSeguridad);
            this.gbDatosTarjeta.Controls.Add(this.lblCodigoSeguridadTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.lblFechaVencimiento);
            this.gbDatosTarjeta.Controls.Add(this.txtNombreTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.lblNombreTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.lblNumero);
            this.gbDatosTarjeta.Location = new System.Drawing.Point(39, 262);
            this.gbDatosTarjeta.Name = "gbDatosTarjeta";
            this.gbDatosTarjeta.Size = new System.Drawing.Size(566, 261);
            this.gbDatosTarjeta.TabIndex = 1;
            this.gbDatosTarjeta.TabStop = false;
            this.gbDatosTarjeta.Text = "Datos tarjeta";
            // 
            // dtpFechaVencimientoTarjeta
            // 
            this.dtpFechaVencimientoTarjeta.Location = new System.Drawing.Point(189, 155);
            this.dtpFechaVencimientoTarjeta.Name = "dtpFechaVencimientoTarjeta";
            this.dtpFechaVencimientoTarjeta.Size = new System.Drawing.Size(326, 26);
            this.dtpFechaVencimientoTarjeta.TabIndex = 15;
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(189, 209);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(326, 26);
            this.txtCodigoSeguridad.TabIndex = 14;
            // 
            // lblCodigoSeguridadTarjeta
            // 
            this.lblCodigoSeguridadTarjeta.AutoSize = true;
            this.lblCodigoSeguridadTarjeta.Location = new System.Drawing.Point(23, 212);
            this.lblCodigoSeguridadTarjeta.Name = "lblCodigoSeguridadTarjeta";
            this.lblCodigoSeguridadTarjeta.Size = new System.Drawing.Size(133, 20);
            this.lblCodigoSeguridadTarjeta.TabIndex = 13;
            this.lblCodigoSeguridadTarjeta.Text = "Código seguridad";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(23, 160);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(142, 20);
            this.lblFechaVencimiento.TabIndex = 12;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // txtNombreTarjeta
            // 
            this.txtNombreTarjeta.Location = new System.Drawing.Point(189, 103);
            this.txtNombreTarjeta.Name = "txtNombreTarjeta";
            this.txtNombreTarjeta.Size = new System.Drawing.Size(326, 26);
            this.txtNombreTarjeta.TabIndex = 11;
            // 
            // lblNombreTarjeta
            // 
            this.lblNombreTarjeta.AutoSize = true;
            this.lblNombreTarjeta.Location = new System.Drawing.Point(23, 109);
            this.lblNombreTarjeta.Name = "lblNombreTarjeta";
            this.lblNombreTarjeta.Size = new System.Drawing.Size(65, 20);
            this.lblNombreTarjeta.TabIndex = 10;
            this.lblNombreTarjeta.Text = "Nombre";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(189, 53);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(326, 26);
            this.txtNumeroTarjeta.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(23, 59);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Número";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(39, 557);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 35);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargarCredito
            // 
            this.btnCargarCredito.Location = new System.Drawing.Point(470, 557);
            this.btnCargarCredito.Name = "btnCargarCredito";
            this.btnCargarCredito.Size = new System.Drawing.Size(135, 35);
            this.btnCargarCredito.TabIndex = 3;
            this.btnCargarCredito.Text = "Cargar crédito";
            this.btnCargarCredito.UseVisualStyleBackColor = true;
            this.btnCargarCredito.Click += new System.EventHandler(this.btnCargarCredito_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(249, 557);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(135, 35);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 613);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCargarCredito);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbDatosTarjeta);
            this.Controls.Add(this.gbCargaCredito);
            this.Name = "Form1";
            this.Text = "Carga crédito";
            this.gbCargaCredito.ResumeLayout(false);
            this.gbCargaCredito.PerformLayout();
            this.gbDatosTarjeta.ResumeLayout(false);
            this.gbDatosTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaCredito;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox gbDatosTarjeta;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoTarjeta;
        private System.Windows.Forms.TextBox txtCodigoSeguridad;
        private System.Windows.Forms.Label lblCodigoSeguridadTarjeta;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtNombreTarjeta;
        private System.Windows.Forms.Label lblNombreTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargarCredito;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}