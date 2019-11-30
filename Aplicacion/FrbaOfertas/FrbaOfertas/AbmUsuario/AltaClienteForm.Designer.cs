using System.ComponentModel;

namespace FrbaOfertas.AbmUsuario
{
    partial class AltaClienteForm
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
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.fechaNacPicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.creatBtn = new System.Windows.Forms.Button();
            this.gbDatosUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.fechaNacPicker1);
            this.gbDatosUsuario.Controls.Add(this.label12);
            this.gbDatosUsuario.Controls.Add(this.telefonoTxt);
            this.gbDatosUsuario.Controls.Add(this.mailTxt);
            this.gbDatosUsuario.Controls.Add(this.dniTxt);
            this.gbDatosUsuario.Controls.Add(this.groupBox1);
            this.gbDatosUsuario.Controls.Add(this.label3);
            this.gbDatosUsuario.Controls.Add(this.label2);
            this.gbDatosUsuario.Controls.Add(this.label1);
            this.gbDatosUsuario.Controls.Add(this.apellidotxt);
            this.gbDatosUsuario.Controls.Add(this.lblPassword);
            this.gbDatosUsuario.Controls.Add(this.nombreTxt);
            this.gbDatosUsuario.Controls.Add(this.lblUsername);
            this.gbDatosUsuario.Location = new System.Drawing.Point(10, 12);
            this.gbDatosUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosUsuario.Size = new System.Drawing.Size(360, 397);
            this.gbDatosUsuario.TabIndex = 6;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos Cliente";
            // 
            // fechaNacPicker1
            // 
            this.fechaNacPicker1.Location = new System.Drawing.Point(96, 170);
            this.fechaNacPicker1.Name = "fechaNacPicker1";
            this.fechaNacPicker1.Size = new System.Drawing.Size(217, 23);
            this.fechaNacPicker1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Fecha Nac";
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(97, 141);
            this.telefonoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(216, 23);
            this.telefonoTxt.TabIndex = 11;
            this.telefonoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numero_KeyPress);
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(97, 114);
            this.mailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(216, 23);
            this.mailTxt.TabIndex = 10;
            // 
            // dniTxt
            // 
            this.dniTxt.Location = new System.Drawing.Point(97, 87);
            this.dniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(216, 23);
            this.dniTxt.TabIndex = 9;
            this.dniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numero_KeyPress);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(30, 207);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(313, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            // 
            // codigoPostaltxt
            // 
            this.codigoPostaltxt.Location = new System.Drawing.Point(66, 121);
            this.codigoPostaltxt.Margin = new System.Windows.Forms.Padding(2);
            this.codigoPostaltxt.Name = "codigoPostaltxt";
            this.codigoPostaltxt.Size = new System.Drawing.Size(216, 23);
            this.codigoPostaltxt.TabIndex = 18;
            this.codigoPostaltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numero_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "CP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Localidad";
            // 
            // localidadTxt
            // 
            this.localidadTxt.Location = new System.Drawing.Point(66, 88);
            this.localidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.localidadTxt.Name = "localidadTxt";
            this.localidadTxt.Size = new System.Drawing.Size(216, 23);
            this.localidadTxt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dpto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Piso";
            // 
            // dptotxt
            // 
            this.dptotxt.Location = new System.Drawing.Point(239, 61);
            this.dptotxt.Margin = new System.Windows.Forms.Padding(2);
            this.dptotxt.Name = "dptotxt";
            this.dptotxt.Size = new System.Drawing.Size(44, 23);
            this.dptotxt.TabIndex = 12;
            // 
            // pisoTxt
            // 
            this.pisoTxt.Location = new System.Drawing.Point(150, 61);
            this.pisoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.pisoTxt.Name = "pisoTxt";
            this.pisoTxt.Size = new System.Drawing.Size(48, 23);
            this.pisoTxt.TabIndex = 11;
            // 
            // nroTxt
            // 
            this.nroTxt.Location = new System.Drawing.Point(66, 61);
            this.nroTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nroTxt.Name = "nroTxt";
            this.nroTxt.Size = new System.Drawing.Size(46, 23);
            this.nroTxt.TabIndex = 10;
            this.nroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username";
            // 
            // calleTxt
            // 
            this.calleTxt.Location = new System.Drawing.Point(66, 30);
            this.calleTxt.Margin = new System.Windows.Forms.Padding(2);
            this.calleTxt.Name = "calleTxt";
            this.calleTxt.Size = new System.Drawing.Size(216, 23);
            this.calleTxt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(97, 60);
            this.apellidotxt.Margin = new System.Windows.Forms.Padding(2);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(216, 23);
            this.apellidotxt.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 63);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Apellido";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(97, 33);
            this.nombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(216, 23);
            this.nombreTxt.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 36);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nombre";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(56, 438);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 22);
            this.volverBtn.TabIndex = 7;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // creatBtn
            // 
            this.creatBtn.Location = new System.Drawing.Point(240, 437);
            this.creatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(83, 23);
            this.creatBtn.TabIndex = 8;
            this.creatBtn.Text = "Crear";
            this.creatBtn.UseVisualStyleBackColor = true;
            this.creatBtn.Click += new System.EventHandler(this.creatBtn_Click);
            // 
            // AltaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 480);
            this.Controls.Add(this.creatBtn);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.gbDatosUsuario);
            this.Name = "AltaClienteForm";
            this.Text = "AltaClienteForm";
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox calleTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pisoTxt;
        private System.Windows.Forms.TextBox dptotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox localidadTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox codigoPostaltxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker fechaNacPicker1;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.TextBox nroTxt;
    }
}