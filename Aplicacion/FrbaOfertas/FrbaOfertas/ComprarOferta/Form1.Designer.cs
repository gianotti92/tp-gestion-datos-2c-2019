namespace FrbaOfertas.ComprarOferta
{
    partial class ComprarOfertaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtroBuscarBtn = new System.Windows.Forms.Button();
            this.FiltroLimpiarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroProvCombo = new System.Windows.Forms.ComboBox();
            this.filtroDescTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.ComprarBtn = new System.Windows.Forms.Button();
            this.compraOfertaDgw = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.compraOfertaDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filtroBuscarBtn);
            this.groupBox1.Controls.Add(this.FiltroLimpiarBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filtroProvCombo);
            this.groupBox1.Controls.Add(this.filtroDescTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // filtroBuscarBtn
            // 
            this.filtroBuscarBtn.Location = new System.Drawing.Point(220, 133);
            this.filtroBuscarBtn.Name = "filtroBuscarBtn";
            this.filtroBuscarBtn.Size = new System.Drawing.Size(107, 27);
            this.filtroBuscarBtn.TabIndex = 5;
            this.filtroBuscarBtn.Text = "Buscar";
            this.filtroBuscarBtn.UseVisualStyleBackColor = true;
            this.filtroBuscarBtn.Click += new System.EventHandler(this.filtroBuscarBtn_Click);
            // 
            // FiltroLimpiarBtn
            // 
            this.FiltroLimpiarBtn.Location = new System.Drawing.Point(16, 133);
            this.FiltroLimpiarBtn.Name = "FiltroLimpiarBtn";
            this.FiltroLimpiarBtn.Size = new System.Drawing.Size(107, 27);
            this.FiltroLimpiarBtn.TabIndex = 4;
            this.FiltroLimpiarBtn.Text = "Limpiar";
            this.FiltroLimpiarBtn.UseVisualStyleBackColor = true;
            this.FiltroLimpiarBtn.Click += new System.EventHandler(this.FiltroLimpiarBtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // filtroProvCombo
            // 
            this.filtroProvCombo.FormattingEnabled = true;
            this.filtroProvCombo.Location = new System.Drawing.Point(100, 83);
            this.filtroProvCombo.Name = "filtroProvCombo";
            this.filtroProvCombo.Size = new System.Drawing.Size(217, 23);
            this.filtroProvCombo.TabIndex = 2;
            // 
            // filtroDescTxt
            // 
            this.filtroDescTxt.Location = new System.Drawing.Point(101, 37);
            this.filtroDescTxt.Name = "filtroDescTxt";
            this.filtroDescTxt.Size = new System.Drawing.Size(216, 23);
            this.filtroDescTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(28, 451);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(128, 38);
            this.volverBtn.TabIndex = 3;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // ComprarBtn
            // 
            this.ComprarBtn.Location = new System.Drawing.Point(202, 451);
            this.ComprarBtn.Name = "ComprarBtn";
            this.ComprarBtn.Size = new System.Drawing.Size(128, 38);
            this.ComprarBtn.TabIndex = 4;
            this.ComprarBtn.Text = "Comprar";
            this.ComprarBtn.UseVisualStyleBackColor = true;
            this.ComprarBtn.Click += new System.EventHandler(this.ComprarBtn_Click);
            // 
            // compraOfertaDgw
            // 
            this.compraOfertaDgw.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraOfertaDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Eliminar, this.Editar});
            this.compraOfertaDgw.Location = new System.Drawing.Point(12, 245);
            this.compraOfertaDgw.Name = "compraOfertaDgw";
            this.compraOfertaDgw.Size = new System.Drawing.Size(342, 180);
            this.compraOfertaDgw.TabIndex = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // ComprarOfertaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 513);
            this.Controls.Add(this.compraOfertaDgw);
            this.Controls.Add(this.ComprarBtn);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComprarOfertaForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.compraOfertaDgw)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtroDescTxt;
        private System.Windows.Forms.ComboBox filtroProvCombo;
        private System.Windows.Forms.Button FiltroLimpiarBtn;
        private System.Windows.Forms.Button filtroBuscarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button ComprarBtn;
        private System.Windows.Forms.DataGridView compraOfertaDgw;
    }
}