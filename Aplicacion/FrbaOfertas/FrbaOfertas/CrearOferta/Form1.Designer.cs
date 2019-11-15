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
            ((System.ComponentModel.ISupportInitialize)(this.OfertaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crearOfertaBtn
            // 
            this.crearOfertaBtn.Location = new System.Drawing.Point(546, 251);
            this.crearOfertaBtn.Name = "crearOfertaBtn";
            this.crearOfertaBtn.Size = new System.Drawing.Size(117, 35);
            this.crearOfertaBtn.TabIndex = 0;
            this.crearOfertaBtn.Text = "Crear oferta";
            this.crearOfertaBtn.UseVisualStyleBackColor = true;
            this.crearOfertaBtn.Click += new System.EventHandler(this.crearOfertaBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(406, 251);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(117, 35);
            this.VolverBtn.TabIndex = 1;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // OfertaDataGridView
            // 
            this.OfertaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfertaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.OfertaDataGridView.Location = new System.Drawing.Point(2, 12);
            this.OfertaDataGridView.Name = "OfertaDataGridView";
            this.OfertaDataGridView.Size = new System.Drawing.Size(661, 233);
            this.OfertaDataGridView.TabIndex = 2;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 49;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // AbmOfertasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 308);
            this.Controls.Add(this.OfertaDataGridView);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.crearOfertaBtn);
            this.Name = "AbmOfertasForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OfertaDataGridView)).EndInit();
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