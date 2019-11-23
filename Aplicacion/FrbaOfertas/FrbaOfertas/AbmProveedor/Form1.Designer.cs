namespace FrbaOfertas.AbmProveedor
{
    partial class Form1
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
            this.ProvGrid = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailFiltroTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.razonSocialFiltroTxt = new System.Windows.Forms.TextBox();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.CuitFiltroTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.ProvGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProvGrid
            // 
            this.ProvGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Eliminar, this.Editar});
            this.ProvGrid.Location = new System.Drawing.Point(12, 187);
            this.ProvGrid.Name = "ProvGrid";
            this.ProvGrid.Size = new System.Drawing.Size(437, 260);
            this.ProvGrid.TabIndex = 7;
            this.ProvGrid.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteGrid_CellContentClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailFiltroTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.razonSocialFiltroTxt);
            this.groupBox1.Controls.Add(this.filtrarBtn);
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.CuitFiltroTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // mailFiltroTxt
            // 
            this.mailFiltroTxt.Location = new System.Drawing.Point(262, 36);
            this.mailFiltroTxt.Name = "mailFiltroTxt";
            this.mailFiltroTxt.Size = new System.Drawing.Size(154, 23);
            this.mailFiltroTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(219, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            // 
            // razonSocialFiltroTxt
            // 
            this.razonSocialFiltroTxt.Location = new System.Drawing.Point(98, 36);
            this.razonSocialFiltroTxt.Name = "razonSocialFiltroTxt";
            this.razonSocialFiltroTxt.Size = new System.Drawing.Size(100, 23);
            this.razonSocialFiltroTxt.TabIndex = 6;
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Location = new System.Drawing.Point(297, 108);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(118, 30);
            this.filtrarBtn.TabIndex = 5;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(14, 108);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(118, 30);
            this.limpiarBtn.TabIndex = 4;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // CuitFiltroTxt
            // 
            this.CuitFiltroTxt.Location = new System.Drawing.Point(98, 65);
            this.CuitFiltroTxt.Name = "CuitFiltroTxt";
            this.CuitFiltroTxt.Size = new System.Drawing.Size(100, 23);
            this.CuitFiltroTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUIT";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 507);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProvGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.ProvGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailFiltroTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox razonSocialFiltroTxt;
        private System.Windows.Forms.TextBox CuitFiltroTxt;
        private System.Windows.Forms.DataGridView ProvGrid;
        private System.Windows.Forms.Button button2;
    }
}