﻿namespace FrbaOfertas.AbmUsuario
{
    partial class ABMUsuarioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRolAsignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMB Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserName,
            this.clRolAsignado,
            this.clTipoUsuario,
            this.clEditar,
            this.clEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(59, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(543, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(59, 283);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 40);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "UserName";
            this.clUserName.Name = "clUserName";
            // 
            // clRolAsignado
            // 
            this.clRolAsignado.HeaderText = "RolAsignado";
            this.clRolAsignado.Name = "clRolAsignado";
            // 
            // clTipoUsuario
            // 
            this.clTipoUsuario.HeaderText = "TipoUsuario";
            this.clTipoUsuario.Name = "clTipoUsuario";
            // 
            // clEditar
            // 
            this.clEditar.DataPropertyName = "Editar";
            this.clEditar.HeaderText = "Editar";
            this.clEditar.Name = "clEditar";
            this.clEditar.Text = "";
            // 
            // clEliminar
            // 
            this.clEliminar.HeaderText = "Eliminar";
            this.clEliminar.Name = "clEliminar";
            // 
            // ABMUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 335);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ABMUsuarioForm";
            this.Text = "ABMUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRolAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipoUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn clEditar;
        private System.Windows.Forms.DataGridViewButtonColumn clEliminar;
    }
}