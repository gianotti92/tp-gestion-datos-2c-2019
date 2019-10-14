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
            this.VolverBtn = new System.Windows.Forms.Button();
            this.OfertaDataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize) (this.OfertaDataGridView)).BeginInit();
            this.SuspendLayout();
            this.crearOfertaBtn.Location = new System.Drawing.Point(135, 12);
            this.crearOfertaBtn.Name = "crearOfertaBtn";
            this.crearOfertaBtn.Size = new System.Drawing.Size(136, 40);
            this.crearOfertaBtn.TabIndex = 0;
            this.crearOfertaBtn.Text = "Crear oferta";
            this.crearOfertaBtn.UseVisualStyleBackColor = true;
            this.crearOfertaBtn.Click += new System.EventHandler(this.crearOfertaBtn_Click);
            this.VolverBtn.Location = new System.Drawing.Point(12, 290);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(136, 40);
            this.VolverBtn.TabIndex = 1;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            this.OfertaDataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfertaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Eliminar, this.Editar});
            this.OfertaDataGridView.Location = new System.Drawing.Point(22, 70);
            this.OfertaDataGridView.Name = "OfertaDataGridView";
            this.OfertaDataGridView.Size = new System.Drawing.Size(369, 180);
            this.OfertaDataGridView.TabIndex = 2;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 342);
            this.Controls.Add(this.OfertaDataGridView);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.crearOfertaBtn);
            this.Name = "AbmOfertasForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.OfertaDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button crearOfertaBtn;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.DataGridView OfertaDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}