using System.ComponentModel;

namespace FrbaOfertas.ListadoEstadistico
{
    partial class TopCincoRecaudacionForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipoListadoCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.listadoGrid)).BeginInit();
            this.SuspendLayout();
            this.button3.Location = new System.Drawing.Point(12, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 27);
            this.button3.TabIndex = 10;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.groupBox2.Controls.Add(this.tipoListadoCBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de Búsqueda";
            this.tipoListadoCBox.FormattingEnabled = true;
            this.tipoListadoCBox.Location = new System.Drawing.Point(87, 117);
            this.tipoListadoCBox.Name = "tipoListadoCBox";
            this.tipoListadoCBox.Size = new System.Drawing.Size(282, 23);
            this.tipoListadoCBox.TabIndex = 8;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listado";
            this.button2.Location = new System.Drawing.Point(254, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button1.Location = new System.Drawing.Point(9, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 23);
            this.comboBox2.TabIndex = 3;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 23);
            this.comboBox1.TabIndex = 1;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semestre";
            this.listadoGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoGrid.Location = new System.Drawing.Point(12, 255);
            this.listadoGrid.Name = "listadoGrid";
            this.listadoGrid.Size = new System.Drawing.Size(397, 194);
            this.listadoGrid.TabIndex = 11;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 518);
            this.Controls.Add(this.listadoGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Name = "TopCincoRecaudacionForm";
            this.Text = "TopCincoRecaudacionForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.listadoGrid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox tipoListadoCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listadoGrid;
    }
}