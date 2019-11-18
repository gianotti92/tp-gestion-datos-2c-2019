using System.ComponentModel;

namespace FrbaOfertas.Facturar
{
    partial class FacturarProveedorForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NroFactTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalFacttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listadoOfertasGrid = new System.Windows.Forms.DataGridView();
            this.finFactDate = new System.Windows.Forms.DateTimePicker();
            this.inicioFactDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProveedorCombo = new System.Windows.Forms.ComboBox();
            this.btnFacturarOfertas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoOfertasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NroFactTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.totalFacttxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listadoOfertasGrid);
            this.groupBox1.Controls.Add(this.finFactDate);
            this.groupBox1.Controls.Add(this.inicioFactDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProveedorCombo);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(503, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion";
            // 
            // NroFactTxt
            // 
            this.NroFactTxt.Location = new System.Drawing.Point(100, 457);
            this.NroFactTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NroFactTxt.Name = "NroFactTxt";
            this.NroFactTxt.ReadOnly = true;
            this.NroFactTxt.Size = new System.Drawing.Size(107, 26);
            this.NroFactTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nro Factura";
            // 
            // totalFacttxt
            // 
            this.totalFacttxt.Location = new System.Drawing.Point(364, 457);
            this.totalFacttxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalFacttxt.Name = "totalFacttxt";
            this.totalFacttxt.ReadOnly = true;
            this.totalFacttxt.Size = new System.Drawing.Size(107, 26);
            this.totalFacttxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(235, 461);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total a Facturar";
            // 
            // listadoOfertasGrid
            // 
            this.listadoOfertasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoOfertasGrid.Location = new System.Drawing.Point(17, 187);
            this.listadoOfertasGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listadoOfertasGrid.Name = "listadoOfertasGrid";
            this.listadoOfertasGrid.Size = new System.Drawing.Size(469, 231);
            this.listadoOfertasGrid.TabIndex = 6;
            // 
            // finFactDate
            // 
            this.finFactDate.Location = new System.Drawing.Point(112, 72);
            this.finFactDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finFactDate.Name = "finFactDate";
            this.finFactDate.Size = new System.Drawing.Size(340, 26);
            this.finFactDate.TabIndex = 5;
            // 
            // inicioFactDate
            // 
            this.inicioFactDate.Location = new System.Drawing.Point(112, 29);
            this.inicioFactDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioFactDate.Name = "inicioFactDate";
            this.inicioFactDate.Size = new System.Drawing.Size(340, 26);
            this.inicioFactDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // ProveedorCombo
            // 
            this.ProveedorCombo.FormattingEnabled = true;
            this.ProveedorCombo.Location = new System.Drawing.Point(112, 117);
            this.ProveedorCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProveedorCombo.Name = "ProveedorCombo";
            this.ProveedorCombo.Size = new System.Drawing.Size(340, 28);
            this.ProveedorCombo.TabIndex = 0;
            // 
            // btnFacturarOfertas
            // 
            this.btnFacturarOfertas.Location = new System.Drawing.Point(328, 547);
            this.btnFacturarOfertas.Name = "btnFacturarOfertas";
            this.btnFacturarOfertas.Size = new System.Drawing.Size(173, 44);
            this.btnFacturarOfertas.TabIndex = 4;
            this.btnFacturarOfertas.Text = "Facturar ofertas";
            this.btnFacturarOfertas.UseVisualStyleBackColor = true;
            this.btnFacturarOfertas.Click += new System.EventHandler(this.btnFacturarOfertas_Click);
            // 
            // FacturarProveedorForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 621);
            this.Controls.Add(this.btnFacturarOfertas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacturarProveedorForm1";
            this.Text = "FacturarProveedorForm1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoOfertasGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ProveedorCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inicioFactDate;
        private System.Windows.Forms.DateTimePicker finFactDate;
        private System.Windows.Forms.DataGridView listadoOfertasGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalFacttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NroFactTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFacturarOfertas;
    }
}