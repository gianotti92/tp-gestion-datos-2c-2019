﻿namespace FrbaOfertas.AbmRol
{
    partial class SeleccionarFuncionalidadForm1
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
            this.components = new System.ComponentModel.Container();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataSource = typeof(FrbaOfertas.Entities.Rol);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrega Cupon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionarFuncionalidadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 301);
            this.Controls.Add(this.button1);
            this.Name = "SeleccionarFuncionalidadForm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.Button button1;
    }
}