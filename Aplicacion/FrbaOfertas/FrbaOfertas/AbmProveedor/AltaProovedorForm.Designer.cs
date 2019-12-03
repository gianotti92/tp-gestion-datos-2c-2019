using System.ComponentModel;

namespace FrbaOfertas.AbmProveedor
{
    partial class AltaProovedorForm
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
            this.creatBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.rubroCombo = new System.Windows.Forms.ComboBox();
            this.contactotxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.cuitTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ciudadCombo = new System.Windows.Forms.ComboBox();
            this.codigoPostaltxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.localidadTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dptotxt = new System.Windows.Forms.TextBox();
            this.pisoTxt = new System.Windows.Forms.TextBox();
            this.nroTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calleTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.razonSocialTxt = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbDatosUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.creatBtn.Location = new System.Drawing.Point(267, 591);
            this.creatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(95, 31);
            this.creatBtn.TabIndex = 10;
            this.creatBtn.Text = "Modificar";
            this.creatBtn.UseVisualStyleBackColor = true;
            this.creatBtn.Click += new System.EventHandler(this.creatBtn_Click);
            this.volverBtn.Location = new System.Drawing.Point(43, 596);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(86, 29);
            this.volverBtn.TabIndex = 9;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            this.gbDatosUsuario.Controls.Add(this.rubroCombo);
            this.gbDatosUsuario.Controls.Add(this.contactotxt);
            this.gbDatosUsuario.Controls.Add(this.label12);
            this.gbDatosUsuario.Controls.Add(this.telTxt);
            this.gbDatosUsuario.Controls.Add(this.cuitTxt);
            this.gbDatosUsuario.Controls.Add(this.groupBox1);
            this.gbDatosUsuario.Controls.Add(this.label3);
            this.gbDatosUsuario.Controls.Add(this.label2);
            this.gbDatosUsuario.Controls.Add(this.label1);
            this.gbDatosUsuario.Controls.Add(this.mailTxt);
            this.gbDatosUsuario.Controls.Add(this.lblPassword);
            this.gbDatosUsuario.Controls.Add(this.razonSocialTxt);
            this.gbDatosUsuario.Controls.Add(this.lblUsername);
            this.gbDatosUsuario.Location = new System.Drawing.Point(11, 16);
            this.gbDatosUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Size = new System.Drawing.Size(411, 571);
            this.gbDatosUsuario.TabIndex = 8;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Proveedor";
            this.rubroCombo.FormattingEnabled = true;
            this.rubroCombo.Location = new System.Drawing.Point(111, 152);
            this.rubroCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rubroCombo.Name = "rubroCombo";
            this.rubroCombo.Size = new System.Drawing.Size(246, 28);
            this.rubroCombo.TabIndex = 8;
            this.contactotxt.Location = new System.Drawing.Point(111, 231);
            this.contactotxt.Margin = new System.Windows.Forms.Padding(2);
            this.contactotxt.Name = "contactotxt";
            this.contactotxt.Size = new System.Drawing.Size(245, 27);
            this.contactotxt.TabIndex = 13;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Contacto";
            this.telTxt.Location = new System.Drawing.Point(111, 188);
            this.telTxt.Margin = new System.Windows.Forms.Padding(2);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(246, 27);
            this.telTxt.TabIndex = 11;
            this.cuitTxt.Location = new System.Drawing.Point(111, 116);
            this.cuitTxt.Margin = new System.Windows.Forms.Padding(2);
            this.cuitTxt.Name = "cuitTxt";
            this.cuitTxt.Size = new System.Drawing.Size(246, 27);
            this.cuitTxt.TabIndex = 9;
            this.groupBox1.Controls.Add(this.ciudadCombo);
            this.groupBox1.Controls.Add(this.codigoPostaltxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.localidadTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dptotxt);
            this.groupBox1.Controls.Add(this.pisoTxt);
            this.groupBox1.Controls.Add(this.nroTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.calleTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(34, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(358, 266);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            this.ciudadCombo.FormattingEnabled = true;
            this.ciudadCombo.Location = new System.Drawing.Point(75, 199);
            this.ciudadCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ciudadCombo.Name = "ciudadCombo";
            this.ciudadCombo.Size = new System.Drawing.Size(245, 28);
            this.ciudadCombo.TabIndex = 9;
            this.codigoPostaltxt.Location = new System.Drawing.Point(75, 161);
            this.codigoPostaltxt.Margin = new System.Windows.Forms.Padding(2);
            this.codigoPostaltxt.Name = "codigoPostaltxt";
            this.codigoPostaltxt.Size = new System.Drawing.Size(246, 27);
            this.codigoPostaltxt.TabIndex = 18;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "CP";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Localidad";
            this.localidadTxt.Location = new System.Drawing.Point(75, 118);
            this.localidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.localidadTxt.Name = "localidadTxt";
            this.localidadTxt.Size = new System.Drawing.Size(246, 27);
            this.localidadTxt.TabIndex = 15;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dpto";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Piso";
            this.dptotxt.Location = new System.Drawing.Point(273, 81);
            this.dptotxt.Margin = new System.Windows.Forms.Padding(2);
            this.dptotxt.Name = "dptotxt";
            this.dptotxt.Size = new System.Drawing.Size(50, 27);
            this.dptotxt.TabIndex = 12;
            this.pisoTxt.Location = new System.Drawing.Point(171, 81);
            this.pisoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.pisoTxt.Name = "pisoTxt";
            this.pisoTxt.Size = new System.Drawing.Size(54, 27);
            this.pisoTxt.TabIndex = 11;
            this.nroTxt.Location = new System.Drawing.Point(75, 81);
            this.nroTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nroTxt.Name = "nroTxt";
            this.nroTxt.Size = new System.Drawing.Size(52, 27);
            this.nroTxt.TabIndex = 10;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nro";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ciudad";
            this.calleTxt.Location = new System.Drawing.Point(75, 40);
            this.calleTxt.Margin = new System.Windows.Forms.Padding(2);
            this.calleTxt.Name = "calleTxt";
            this.calleTxt.Size = new System.Drawing.Size(246, 27);
            this.calleTxt.TabIndex = 3;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Calle";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rubro";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cuit";
            this.mailTxt.Location = new System.Drawing.Point(111, 80);
            this.mailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(246, 27);
            this.mailTxt.TabIndex = 5;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 84);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mail";
            this.razonSocialTxt.Location = new System.Drawing.Point(111, 44);
            this.razonSocialTxt.Margin = new System.Windows.Forms.Padding(2);
            this.razonSocialTxt.Name = "razonSocialTxt";
            this.razonSocialTxt.Size = new System.Drawing.Size(246, 27);
            this.razonSocialTxt.TabIndex = 3;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(19, 48);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Razon Social";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 644);
            this.Controls.Add(this.creatBtn);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.gbDatosUsuario);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltaProovedorForm";
            this.Text = "AltaProovedorForm";
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox razonSocialTxt;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox calleTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nroTxt;
        private System.Windows.Forms.TextBox pisoTxt;
        private System.Windows.Forms.TextBox dptotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox localidadTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox codigoPostaltxt;
        private System.Windows.Forms.ComboBox ciudadCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cuitTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox contactotxt;
        private System.Windows.Forms.ComboBox rubroCombo;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button creatBtn;
    }
}