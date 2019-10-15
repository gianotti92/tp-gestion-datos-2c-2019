namespace FrbaOfertas.AbmUsuario
{
    partial class ABMUsuarioAltaForm
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
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lbRoles = new System.Windows.Forms.ListBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.gbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.btnAgregarRol);
            this.gbDatosUsuario.Controls.Add(this.btnEliminarRol);
            this.gbDatosUsuario.Controls.Add(this.lbRoles);
            this.gbDatosUsuario.Controls.Add(this.cbTipoUsuario);
            this.gbDatosUsuario.Controls.Add(this.lblTipoUsuario);
            this.gbDatosUsuario.Controls.Add(this.cbRol);
            this.gbDatosUsuario.Controls.Add(this.lblRol);
            this.gbDatosUsuario.Controls.Add(this.txtPassword);
            this.gbDatosUsuario.Controls.Add(this.lblPassword);
            this.gbDatosUsuario.Controls.Add(this.txtUsername);
            this.gbDatosUsuario.Controls.Add(this.lblUsername);
            this.gbDatosUsuario.Location = new System.Drawing.Point(47, 34);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(594, 410);
            this.gbDatosUsuario.TabIndex = 0;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(292, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(262, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(39, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(292, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(262, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(39, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(39, 213);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 20);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(292, 205);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(262, 28);
            this.cbRol.TabIndex = 7;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(292, 153);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(262, 28);
            this.cbTipoUsuario.TabIndex = 9;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(39, 161);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(98, 20);
            this.lblTipoUsuario.TabIndex = 8;
            this.lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // lbRoles
            // 
            this.lbRoles.FormattingEnabled = true;
            this.lbRoles.ItemHeight = 20;
            this.lbRoles.Location = new System.Drawing.Point(292, 256);
            this.lbRoles.Name = "lbRoles";
            this.lbRoles.Size = new System.Drawing.Size(262, 84);
            this.lbRoles.TabIndex = 10;
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(425, 357);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(129, 37);
            this.btnEliminarRol.TabIndex = 11;
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(534, 466);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(107, 31);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(47, 466);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(266, 466);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(152, 31);
            this.btnLimpiarCampos.TabIndex = 3;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(292, 357);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(116, 37);
            this.btnAgregarRol.TabIndex = 12;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // ABMUsuarioAltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 520);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gbDatosUsuario);
            this.Name = "ABMUsuarioAltaForm";
            this.Text = "ABMUsuarioAltaForm";
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.ListBox lbRoles;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnAgregarRol;
    }
}