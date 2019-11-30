namespace FrbaOfertas.CargaCredito
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
            this.gbCargaCredito.Location = new System.Drawing.Point(26, 21);
            this.gbCargaCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCargaCredito.Name = "gbCargaCredito";
            this.gbCargaCredito.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCargaCredito.Size = new System.Drawing.Size(377, 136);
            this.gbCargaCredito.TabIndex = 0;
            this.gbCargaCredito.TabStop = false;
            this.gbCargaCredito.Text = "Datos carga crédito";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(126, 103);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(219, 20);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(15, 105);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(126, 63);
            this.cbTipoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(219, 21);
            this.cbTipoPago.TabIndex = 5;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(15, 65);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(53, 13);
            this.lblTipoPago.TabIndex = 4;
            this.lblTipoPago.Text = "TipoPago";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(126, 27);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(219, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 29);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
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
            this.gbDatosTarjeta.Location = new System.Drawing.Point(26, 170);
            this.gbDatosTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosTarjeta.Name = "gbDatosTarjeta";
            this.gbDatosTarjeta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosTarjeta.Size = new System.Drawing.Size(377, 170);
            this.gbDatosTarjeta.TabIndex = 1;
            this.gbDatosTarjeta.TabStop = false;
            this.gbDatosTarjeta.Text = "Datos tarjeta";
            // 
            // dtpFechaVencimientoTarjeta
            // 
            this.dtpFechaVencimientoTarjeta.Location = new System.Drawing.Point(126, 101);
            this.dtpFechaVencimientoTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaVencimientoTarjeta.Name = "dtpFechaVencimientoTarjeta";
            this.dtpFechaVencimientoTarjeta.Size = new System.Drawing.Size(219, 20);
            this.dtpFechaVencimientoTarjeta.TabIndex = 15;
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(126, 136);
            this.txtCodigoSeguridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(219, 20);
            this.txtCodigoSeguridad.TabIndex = 14;
            // 
            // lblCodigoSeguridadTarjeta
            // 
            this.lblCodigoSeguridadTarjeta.AutoSize = true;
            this.lblCodigoSeguridadTarjeta.Location = new System.Drawing.Point(15, 138);
            this.lblCodigoSeguridadTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoSeguridadTarjeta.Name = "lblCodigoSeguridadTarjeta";
            this.lblCodigoSeguridadTarjeta.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoSeguridadTarjeta.TabIndex = 13;
            this.lblCodigoSeguridadTarjeta.Text = "Código seguridad";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(15, 104);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(97, 13);
            this.lblFechaVencimiento.TabIndex = 12;
            this.lblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // txtNombreTarjeta
            // 
            this.txtNombreTarjeta.Location = new System.Drawing.Point(126, 67);
            this.txtNombreTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreTarjeta.Name = "txtNombreTarjeta";
            this.txtNombreTarjeta.Size = new System.Drawing.Size(219, 20);
            this.txtNombreTarjeta.TabIndex = 11;
            // 
            // lblNombreTarjeta
            // 
            this.lblNombreTarjeta.AutoSize = true;
            this.lblNombreTarjeta.Location = new System.Drawing.Point(15, 71);
            this.lblNombreTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreTarjeta.Name = "lblNombreTarjeta";
            this.lblNombreTarjeta.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTarjeta.TabIndex = 10;
            this.lblNombreTarjeta.Text = "Nombre";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(126, 34);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(219, 20);
            this.txtNumeroTarjeta.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 38);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Número";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(26, 362);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(74, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargarCredito
            // 
            this.btnCargarCredito.Location = new System.Drawing.Point(313, 362);
            this.btnCargarCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarCredito.Name = "btnCargarCredito";
            this.btnCargarCredito.Size = new System.Drawing.Size(90, 23);
            this.btnCargarCredito.TabIndex = 3;
            this.btnCargarCredito.Text = "Cargar crédito";
            this.btnCargarCredito.UseVisualStyleBackColor = true;
            this.btnCargarCredito.Click += new System.EventHandler(this.btnCargarCredito_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(166, 362);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(90, 23);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 398);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCargarCredito);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbDatosTarjeta);
            this.Controls.Add(this.gbCargaCredito);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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