using System.ComponentModel;

namespace FrbaOfertas.ConsumoOferta
{
    partial class ConsumoOferta
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idCompraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OfertaDataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volverBtn1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.OfertaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.idCompraTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idCompraTextBox
            // 
            this.idCompraTextBox.Location = new System.Drawing.Point(117, 42);
            this.idCompraTextBox.Name = "idCompraTextBox";
            this.idCompraTextBox.Size = new System.Drawing.Size(238, 23);
            this.idCompraTextBox.TabIndex = 1;
            this.idCompraTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero compra";
            // 
            // OfertaDataGridView
            // 
            this.OfertaDataGridView.AutoGenerateColumns = false;
            this.OfertaDataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfertaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.Eliminar, this.idDataGridViewTextBoxColumn, this.idOfertaDataGridViewTextBoxColumn,
                this.idClienteDataGridViewTextBoxColumn, this.fechaDataGridViewTextBoxColumn,
                this.fechaConsumoDataGridViewTextBoxColumn, this.idFacturaDataGridViewTextBoxColumn,
                this.cantidadDataGridViewTextBoxColumn
            });
            this.OfertaDataGridView.DataSource = this.compraBindingSource;
            this.OfertaDataGridView.Location = new System.Drawing.Point(16, 228);
            this.OfertaDataGridView.Name = "OfertaDataGridView";
            this.OfertaDataGridView.Size = new System.Drawing.Size(386, 180);
            this.OfertaDataGridView.TabIndex = 3;
            this.OfertaDataGridView.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.OfertaDataGridView_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Consumir";
            this.Eliminar.Name = "Eliminar";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idOfertaDataGridViewTextBoxColumn
            // 
            this.idOfertaDataGridViewTextBoxColumn.DataPropertyName = "idOferta";
            this.idOfertaDataGridViewTextBoxColumn.HeaderText = "idOferta";
            this.idOfertaDataGridViewTextBoxColumn.Name = "idOfertaDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // fechaConsumoDataGridViewTextBoxColumn
            // 
            this.fechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "fechaConsumo";
            this.fechaConsumoDataGridViewTextBoxColumn.HeaderText = "fechaConsumo";
            this.fechaConsumoDataGridViewTextBoxColumn.Name = "fechaConsumoDataGridViewTextBoxColumn";
            // 
            // idFacturaDataGridViewTextBoxColumn
            // 
            this.idFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura";
            this.idFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura";
            this.idFacturaDataGridViewTextBoxColumn.Name = "idFacturaDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(FrbaOfertas.Entities.Compra);
            // 
            // volverBtn1
            // 
            this.volverBtn1.Location = new System.Drawing.Point(29, 432);
            this.volverBtn1.Name = "volverBtn1";
            this.volverBtn1.Size = new System.Drawing.Size(119, 33);
            this.volverBtn1.TabIndex = 4;
            this.volverBtn1.Text = "Volver";
            this.volverBtn1.UseVisualStyleBackColor = true;
            this.volverBtn1.Click += new System.EventHandler(this.volverBtn1_Click);
            // 
            // ConsumoOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 475);
            this.Controls.Add(this.volverBtn1);
            this.Controls.Add(this.OfertaDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsumoOferta";
            this.Text = "ConsumoOferta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.OfertaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.compraBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button volverBtn1;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridView OfertaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCompraTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraBindingSource;
    }
}