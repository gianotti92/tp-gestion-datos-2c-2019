namespace FrbaOfertas.AbmCliente
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
            this.ClienteGrid = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DniFilroTxt = new System.Windows.Forms.TextBox();
            this.mailFiltroTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreFiltroTxt = new System.Windows.Forms.TextBox();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.ApellidoFiltroTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.ClienteGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.ClienteGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteGrid.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[] {this.Eliminar, this.Editar});
            this.ClienteGrid.Location = new System.Drawing.Point(12, 187);
            this.ClienteGrid.Name = "ClienteGrid";
            this.ClienteGrid.Size = new System.Drawing.Size(437, 260);
            this.ClienteGrid.TabIndex = 5;
            this.ClienteGrid.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteGrid_CellContentClick);
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DniFilroTxt);
            this.groupBox1.Controls.Add(this.mailFiltroTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nombreFiltroTxt);
            this.groupBox1.Controls.Add(this.filtrarBtn);
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.ApellidoFiltroTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            this.label4.Location = new System.Drawing.Point(211, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dni";
            this.DniFilroTxt.Location = new System.Drawing.Point(250, 65);
            this.DniFilroTxt.Name = "DniFilroTxt";
            this.DniFilroTxt.Size = new System.Drawing.Size(100, 23);
            this.DniFilroTxt.TabIndex = 9;
            this.DniFilroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTxt_KeyPress);
            this.mailFiltroTxt.Location = new System.Drawing.Point(250, 36);
            this.mailFiltroTxt.Name = "mailFiltroTxt";
            this.mailFiltroTxt.Size = new System.Drawing.Size(100, 23);
            this.mailFiltroTxt.TabIndex = 8;
            this.label3.Location = new System.Drawing.Point(211, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            this.nombreFiltroTxt.Location = new System.Drawing.Point(98, 36);
            this.nombreFiltroTxt.Name = "nombreFiltroTxt";
            this.nombreFiltroTxt.Size = new System.Drawing.Size(100, 23);
            this.nombreFiltroTxt.TabIndex = 6;
            this.filtrarBtn.Location = new System.Drawing.Point(232, 108);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(118, 30);
            this.filtrarBtn.TabIndex = 5;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            this.limpiarBtn.Location = new System.Drawing.Point(14, 108);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(118, 30);
            this.limpiarBtn.TabIndex = 4;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            this.ApellidoFiltroTxt.Location = new System.Drawing.Point(98, 65);
            this.ApellidoFiltroTxt.Name = "ApellidoFiltroTxt";
            this.ApellidoFiltroTxt.Size = new System.Drawing.Size(100, 23);
            this.ApellidoFiltroTxt.TabIndex = 3;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.button1.Location = new System.Drawing.Point(10, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Location = new System.Drawing.Point(334, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClienteGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.ClienteGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreFiltroTxt;
        private System.Windows.Forms.TextBox mailFiltroTxt;
        private System.Windows.Forms.TextBox DniFilroTxt;
        private System.Windows.Forms.TextBox ApellidoFiltroTxt;
        private System.Windows.Forms.DataGridView ClienteGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}