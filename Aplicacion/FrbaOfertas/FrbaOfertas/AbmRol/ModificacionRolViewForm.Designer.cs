﻿using System.ComponentModel;

namespace FrbaOfertas.AbmRol
{
    partial class ModificacionRolViewForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarFuncBtn = new System.Windows.Forms.Button();
            this.habilitadoComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.funcionalidadComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesListBox = new System.Windows.Forms.ListBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.groupBox1.Controls.Add(this.AgregarFuncBtn);
            this.groupBox1.Controls.Add(this.habilitadoComboBox);
            this.groupBox1.Controls.Add(this.nombreTxt);
            this.groupBox1.Controls.Add(this.funcionalidadComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Rol";
            this.AgregarFuncBtn.Location = new System.Drawing.Point(397, 107);
            this.AgregarFuncBtn.Name = "AgregarFuncBtn";
            this.AgregarFuncBtn.Size = new System.Drawing.Size(97, 27);
            this.AgregarFuncBtn.TabIndex = 6;
            this.AgregarFuncBtn.Text = "Agregar";
            this.AgregarFuncBtn.UseVisualStyleBackColor = true;
            this.AgregarFuncBtn.Click += new System.EventHandler(this.AgregarFuncBtn_Click);
            this.habilitadoComboBox.FormattingEnabled = true;
            this.habilitadoComboBox.Location = new System.Drawing.Point(271, 153);
            this.habilitadoComboBox.Name = "habilitadoComboBox";
            this.habilitadoComboBox.Size = new System.Drawing.Size(223, 23);
            this.habilitadoComboBox.TabIndex = 5;
            this.nombreTxt.Location = new System.Drawing.Point(269, 37);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(223, 23);
            this.nombreTxt.TabIndex = 4;
            this.funcionalidadComboBox.FormattingEnabled = true;
            this.funcionalidadComboBox.Location = new System.Drawing.Point(269, 78);
            this.funcionalidadComboBox.Name = "funcionalidadComboBox";
            this.funcionalidadComboBox.Size = new System.Drawing.Size(224, 23);
            this.funcionalidadComboBox.TabIndex = 3;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Habilitar";
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionalidad";
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            this.rolesListBox.FormattingEnabled = true;
            this.rolesListBox.ItemHeight = 15;
            this.rolesListBox.Location = new System.Drawing.Point(10, 226);
            this.rolesListBox.Name = "rolesListBox";
            this.rolesListBox.Size = new System.Drawing.Size(524, 79);
            this.rolesListBox.TabIndex = 2;
            this.EliminarBtn.Location = new System.Drawing.Point(10, 312);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(99, 28);
            this.EliminarBtn.TabIndex = 6;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            this.ModificarBtn.Location = new System.Drawing.Point(437, 370);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(94, 32);
            this.ModificarBtn.TabIndex = 8;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.button4_Click);
            this.Cancelarbtn.Location = new System.Drawing.Point(12, 370);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(100, 32);
            this.Cancelarbtn.TabIndex = 7;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = true;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 417);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.rolesListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificacionRolViewForm";
            this.Text = "ModificacionRolViewForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox funcionalidadComboBox;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.ComboBox habilitadoComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox rolesListBox;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button AgregarFuncBtn;
    }
}