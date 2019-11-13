namespace FrbaOfertas.Facturar
{
    partial class FacturarProveedorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.listadoOfertasGrid)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion";
            // 
            // NroFactTxt
            // 
            this.NroFactTxt.Location = new System.Drawing.Point(78, 343);
            this.NroFactTxt.Name = "NroFactTxt";
            this.NroFactTxt.ReadOnly = true;
            this.NroFactTxt.Size = new System.Drawing.Size(84, 23);
            this.NroFactTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nro Factura";
            // 
            // totalFacttxt
            // 
            this.totalFacttxt.Location = new System.Drawing.Point(283, 343);
            this.totalFacttxt.Name = "totalFacttxt";
            this.totalFacttxt.ReadOnly = true;
            this.totalFacttxt.Size = new System.Drawing.Size(84, 23);
            this.totalFacttxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(192, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total a Facturar";
            // 
            // listadoOfertasGrid
            // 
            this.listadoOfertasGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoOfertasGrid.Location = new System.Drawing.Point(13, 140);
            this.listadoOfertasGrid.Name = "listadoOfertasGrid";
            this.listadoOfertasGrid.Size = new System.Drawing.Size(365, 173);
            this.listadoOfertasGrid.TabIndex = 6;
            // 
            // finFactDate
            // 
            this.finFactDate.Location = new System.Drawing.Point(87, 54);
            this.finFactDate.Name = "finFactDate";
            this.finFactDate.Size = new System.Drawing.Size(265, 23);
            this.finFactDate.TabIndex = 5;
            // 
            // inicioFactDate
            // 
            this.inicioFactDate.Location = new System.Drawing.Point(87, 22);
            this.inicioFactDate.Name = "inicioFactDate";
            this.inicioFactDate.Size = new System.Drawing.Size(265, 23);
            this.inicioFactDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // ProveedorCombo
            // 
            this.ProveedorCombo.FormattingEnabled = true;
            this.ProveedorCombo.Location = new System.Drawing.Point(87, 88);
            this.ProveedorCombo.Name = "ProveedorCombo";
            this.ProveedorCombo.Size = new System.Drawing.Size(265, 23);
            this.ProveedorCombo.TabIndex = 0;
            this.ProveedorCombo.SelectedIndexChanged +=
                new System.EventHandler(this.ProveedorCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FacturarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturarProveedorForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.listadoOfertasGrid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProveedorCombo;
        private System.Windows.Forms.DateTimePicker inicioFactDate;
        private System.Windows.Forms.DateTimePicker finFactDate;
        private System.Windows.Forms.DataGridView listadoOfertasGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalFacttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NroFactTxt;
    }
}