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
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Habilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClienteGrid
            // 
            this.ClienteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar,
            this.Habilitar});
            this.ClienteGrid.Location = new System.Drawing.Point(10, 162);
            this.ClienteGrid.Name = "ClienteGrid";
            this.ClienteGrid.Size = new System.Drawing.Size(375, 225);
            this.ClienteGrid.TabIndex = 5;
            this.ClienteGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteGrid_CellContentClick);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(181, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dni";
            // 
            // DniFilroTxt
            // 
            this.DniFilroTxt.Location = new System.Drawing.Point(214, 56);
            this.DniFilroTxt.Name = "DniFilroTxt";
            this.DniFilroTxt.Size = new System.Drawing.Size(86, 20);
            this.DniFilroTxt.TabIndex = 9;
            this.DniFilroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTxt_KeyPress);
            // 
            // mailFiltroTxt
            // 
            this.mailFiltroTxt.Location = new System.Drawing.Point(214, 31);
            this.mailFiltroTxt.Name = "mailFiltroTxt";
            this.mailFiltroTxt.Size = new System.Drawing.Size(86, 20);
            this.mailFiltroTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(181, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            // 
            // nombreFiltroTxt
            // 
            this.nombreFiltroTxt.Location = new System.Drawing.Point(84, 31);
            this.nombreFiltroTxt.Name = "nombreFiltroTxt";
            this.nombreFiltroTxt.Size = new System.Drawing.Size(86, 20);
            this.nombreFiltroTxt.TabIndex = 6;
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Location = new System.Drawing.Point(199, 94);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(101, 26);
            this.filtrarBtn.TabIndex = 5;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(12, 94);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(101, 26);
            this.limpiarBtn.TabIndex = 4;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // ApellidoFiltroTxt
            // 
            this.ApellidoFiltroTxt.Location = new System.Drawing.Point(84, 56);
            this.ApellidoFiltroTxt.Name = "ApellidoFiltroTxt";
            this.ApellidoFiltroTxt.Size = new System.Drawing.Size(86, 20);
            this.ApellidoFiltroTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Habilitar
            // 
            this.Habilitar.HeaderText = "HabilitarColumn";
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Habilitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClienteGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClienteGrid)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn Habilitar;
    }
}