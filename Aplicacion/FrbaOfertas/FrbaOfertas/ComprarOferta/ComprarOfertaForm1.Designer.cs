using System.ComponentModel;

namespace FrbaOfertas.ComprarOferta
{
    partial class ComprarOfertaForm1
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
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.filtroDescTxt = new System.Windows.Forms.TextBox();
            this.filtroProvCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compraOfertaDgw = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.compraOfertaDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filtrarBtn);
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.filtroDescTxt);
            this.groupBox1.Controls.Add(this.filtroProvCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Location = new System.Drawing.Point(232, 119);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(118, 30);
            this.filtrarBtn.TabIndex = 5;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(23, 119);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(118, 30);
            this.limpiarBtn.TabIndex = 4;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // filtroDescTxt
            // 
            this.filtroDescTxt.Location = new System.Drawing.Point(129, 72);
            this.filtroDescTxt.Name = "filtroDescTxt";
            this.filtroDescTxt.Size = new System.Drawing.Size(196, 23);
            this.filtroDescTxt.TabIndex = 3;
            // 
            // filtroProvCombo
            // 
            this.filtroProvCombo.FormattingEnabled = true;
            this.filtroProvCombo.Location = new System.Drawing.Point(127, 33);
            this.filtroProvCombo.Name = "filtroProvCombo";
            this.filtroProvCombo.Size = new System.Drawing.Size(200, 23);
            this.filtroProvCombo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // compraOfertaDgw
            // 
            this.compraOfertaDgw.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraOfertaDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Eliminar});
            this.compraOfertaDgw.Location = new System.Drawing.Point(16, 218);
            this.compraOfertaDgw.Name = "compraOfertaDgw";
            this.compraOfertaDgw.Size = new System.Drawing.Size(395, 180);
            this.compraOfertaDgw.TabIndex = 3;
            this.compraOfertaDgw.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.compraOfertaDgw_CellContentClick);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(38, 433);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(118, 30);
            this.volverBtn.TabIndex = 6;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click_1);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Comprar";
            this.Eliminar.Name = "Eliminar";
            // 
            // ComprarOfertaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 466);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.compraOfertaDgw);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComprarOfertaForm1";
            this.Text = "ComprarOfertaForm1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.compraOfertaDgw)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.ComboBox filtroProvCombo;
        private System.Windows.Forms.DataGridView compraOfertaDgw;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.TextBox filtroDescTxt;
    }
}