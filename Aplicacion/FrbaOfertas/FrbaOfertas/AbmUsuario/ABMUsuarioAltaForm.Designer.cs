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
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.cbTipoUsuario);
            this.gbDatosUsuario.Controls.Add(this.lblTipoUsuario);
            this.gbDatosUsuario.Controls.Add(this.txtPassword);
            this.gbDatosUsuario.Controls.Add(this.lblPassword);
            this.gbDatosUsuario.Controls.Add(this.txtUsername);
            this.gbDatosUsuario.Controls.Add(this.lblUsername);
            this.gbDatosUsuario.Location = new System.Drawing.Point(31, 21);
            this.gbDatosUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosUsuario.Size = new System.Drawing.Size(321, 180);
            this.gbDatosUsuario.TabIndex = 0;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Usuario";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(93, 102);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(176, 21);
            this.cbTipoUsuario.TabIndex = 9;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(26, 105);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblTipoUsuario.TabIndex = 8;
            this.lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(26, 70);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 29);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(26, 36);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Location = new System.Drawing.Point(267, 220);
            this.siguienteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(71, 27);
            this.siguienteBtn.TabIndex = 1;
            this.siguienteBtn.Text = "Siguiente";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(57, 219);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 27);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(142, 219);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(101, 28);
            this.btnLimpiarCampos.TabIndex = 3;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // ABMUsuarioAltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 285);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.gbDatosUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ABMUsuarioAltaForm";
            this.Text = "ABMUsuarioAltaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMUsuarioAltaForm_FormClosing);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button siguienteBtn;
    }
}