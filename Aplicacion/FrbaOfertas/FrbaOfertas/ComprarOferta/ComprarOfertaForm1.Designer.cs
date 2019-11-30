﻿using System.ComponentModel;

namespace FrbaOfertas.ComprarOferta
{
    partial class ComprarOfertaForm1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.filtroDescTxt = new System.Windows.Forms.TextBox();
            this.filtroProvCombo = new System.Windows.Forms.ComboBox();
            this.proovedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadOfertas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compraOfertaDgw = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.volverBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.proovedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.compraOfertaDgw)).BeginInit();
            this.SuspendLayout();
            this.groupBox1.Controls.Add(this.filtrarBtn);
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.filtroDescTxt);
            this.groupBox1.Controls.Add(this.filtroProvCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(464, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            this.filtrarBtn.Location = new System.Drawing.Point(299, 159);
            this.filtrarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(135, 40);
            this.filtrarBtn.TabIndex = 5;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            this.limpiarBtn.Location = new System.Drawing.Point(26, 159);
            this.limpiarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(135, 40);
            this.limpiarBtn.TabIndex = 4;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            this.filtroDescTxt.Location = new System.Drawing.Point(147, 96);
            this.filtroDescTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroDescTxt.Name = "filtroDescTxt";
            this.filtroDescTxt.Size = new System.Drawing.Size(223, 27);
            this.filtroDescTxt.TabIndex = 3;
            this.filtroProvCombo.DataSource = this.proovedorBindingSource;
            this.filtroProvCombo.DisplayMember = "razonSocial";
            this.filtroProvCombo.FormattingEnabled = true;
            this.filtroProvCombo.Location = new System.Drawing.Point(145, 44);
            this.filtroProvCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtroProvCombo.Name = "filtroProvCombo";
            this.filtroProvCombo.Size = new System.Drawing.Size(228, 28);
            this.filtroProvCombo.TabIndex = 2;
            this.filtroProvCombo.ValueMember = "id";
            this.proovedorBindingSource.DataSource = typeof(FrbaOfertas.Entities.Proovedor);
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            this.CantidadOfertas.Location = new System.Drawing.Point(94, 309);
            this.CantidadOfertas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CantidadOfertas.Name = "CantidadOfertas";
            this.CantidadOfertas.Size = new System.Drawing.Size(226, 27);
            this.CantidadOfertas.TabIndex = 7;
            this.CantidadOfertas.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.CantidadOfertas_KeyPress);
            this.label3.Location = new System.Drawing.Point(18, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            this.compraOfertaDgw.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraOfertaDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Eliminar});
            this.compraOfertaDgw.Location = new System.Drawing.Point(34, 371);
            this.compraOfertaDgw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compraOfertaDgw.Name = "compraOfertaDgw";
            this.compraOfertaDgw.Size = new System.Drawing.Size(819, 240);
            this.compraOfertaDgw.TabIndex = 3;
            this.compraOfertaDgw.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.compraOfertaDgw_CellContentClick);
            this.Eliminar.HeaderText = "Comprar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Comprar";
            this.Eliminar.ToolTipText = "Comprar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.volverBtn.Location = new System.Drawing.Point(34, 631);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(135, 40);
            this.volverBtn.TabIndex = 6;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click_1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 706);
            this.Controls.Add(this.CantidadOfertas);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compraOfertaDgw);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComprarOfertaForm1";
            this.Text = "ComprarOfertaForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprarOfertaForm1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.proovedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.compraOfertaDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filtroProvCombo;
        private System.Windows.Forms.DataGridView compraOfertaDgw;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.TextBox filtroDescTxt;
        private System.Windows.Forms.TextBox CantidadOfertas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource proovedorBindingSource;
    }
}