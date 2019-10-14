namespace FrbaOfertas.CrearOferta
{
    partial class AbmOfertasForm
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
            this.crearOfertaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crearOfertaBtn
            // 
            this.crearOfertaBtn.Location = new System.Drawing.Point(135, 12);
            this.crearOfertaBtn.Name = "crearOfertaBtn";
            this.crearOfertaBtn.Size = new System.Drawing.Size(137, 40);
            this.crearOfertaBtn.TabIndex = 0;
            this.crearOfertaBtn.Text = "Crear oferta";
            this.crearOfertaBtn.UseVisualStyleBackColor = true;
            this.crearOfertaBtn.Click += new System.EventHandler(this.crearOfertaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 342);
            this.Controls.Add(this.crearOfertaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button crearOfertaBtn;
    }
}