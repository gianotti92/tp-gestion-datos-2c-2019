using System.ComponentModel;

namespace FrbaOfertas.AbmRol
{
    partial class AltaRolViewForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.habilitadoComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.funcionalidadComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesListBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.habilitadoComboBox);
            this.groupBox1.Controls.Add(this.nombreTxt);
            this.groupBox1.Controls.Add(this.funcionalidadComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Rol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // habilitadoComboBox
            // 
            this.habilitadoComboBox.FormattingEnabled = true;
            this.habilitadoComboBox.Location = new System.Drawing.Point(232, 133);
            this.habilitadoComboBox.Name = "habilitadoComboBox";
            this.habilitadoComboBox.Size = new System.Drawing.Size(192, 21);
            this.habilitadoComboBox.TabIndex = 5;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(231, 32);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(192, 20);
            this.nombreTxt.TabIndex = 4;
            // 
            // funcionalidadComboBox
            // 
            this.funcionalidadComboBox.FormattingEnabled = true;
            this.funcionalidadComboBox.Location = new System.Drawing.Point(231, 68);
            this.funcionalidadComboBox.Name = "funcionalidadComboBox";
            this.funcionalidadComboBox.Size = new System.Drawing.Size(193, 21);
            this.funcionalidadComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Habilitar";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // rolesListBox
            // 
            this.rolesListBox.FormattingEnabled = true;
            this.rolesListBox.Location = new System.Drawing.Point(28, 211);
            this.rolesListBox.Name = "rolesListBox";
            this.rolesListBox.Size = new System.Drawing.Size(450, 69);
            this.rolesListBox.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Crear Rol";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AltaRolViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rolesListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaRolViewForm";
            this.Text = "AltaRolViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaRolViewForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox funcionalidadComboBox;
        private System.Windows.Forms.ListBox rolesListBox;
        private System.Windows.Forms.ComboBox habilitadoComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nombreTxt;
    }
}