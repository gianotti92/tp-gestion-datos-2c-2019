using System.ComponentModel;

namespace FrbaOfertas.CrearOferta
{
    partial class AltaOfertaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.PrecioListaTxt = new System.Windows.Forms.TextBox();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.ProovedorCmb = new System.Windows.Forms.ComboBox();
            this.proovedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CrearBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxPorClienteTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.fechaVencPicker = new System.Windows.Forms.DateTimePicker();
            this.fechaPublicPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proovedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion de la oferta";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Vencimiento";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(40, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Oferta";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(40, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de Lista";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(40, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Proovedor";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(40, 207);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(308, 20);
            this.DescripcionTxt.TabIndex = 7;
            // 
            // PrecioListaTxt
            // 
            this.PrecioListaTxt.Location = new System.Drawing.Point(146, 87);
            this.PrecioListaTxt.Name = "PrecioListaTxt";
            this.PrecioListaTxt.Size = new System.Drawing.Size(204, 20);
            this.PrecioListaTxt.TabIndex = 9;
            this.PrecioListaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTxt_KeyPress);
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(146, 61);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(204, 20);
            this.PrecioTxt.TabIndex = 10;
            this.PrecioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTxt_KeyPress);
            // 
            // ProovedorCmb
            // 
            this.ProovedorCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proovedorBindingSource, "razonSocial", true));
            this.ProovedorCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proovedorBindingSource, "id", true));
            this.ProovedorCmb.DataSource = this.proovedorBindingSource;
            this.ProovedorCmb.DisplayMember = "razonSocial";
            this.ProovedorCmb.FormattingEnabled = true;
            this.ProovedorCmb.Location = new System.Drawing.Point(146, 112);
            this.ProovedorCmb.Name = "ProovedorCmb";
            this.ProovedorCmb.Size = new System.Drawing.Size(204, 21);
            this.ProovedorCmb.TabIndex = 14;
            this.ProovedorCmb.ValueMember = "id";
            // 
            // proovedorBindingSource
            // 
            this.proovedorBindingSource.DataSource = typeof(FrbaOfertas.Entities.Proovedor);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(40, 242);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(122, 30);
            this.CancelarBtn.TabIndex = 15;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // CrearBtn
            // 
            this.CrearBtn.Location = new System.Drawing.Point(254, 242);
            this.CrearBtn.Name = "CrearBtn";
            this.CrearBtn.Size = new System.Drawing.Size(122, 30);
            this.CrearBtn.TabIndex = 16;
            this.CrearBtn.Text = "Publicar";
            this.CrearBtn.UseVisualStyleBackColor = true;
            this.CrearBtn.Click += new System.EventHandler(this.CrearBtn_Click_1);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(40, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Max por cliente";
            // 
            // MaxPorClienteTxt
            // 
            this.MaxPorClienteTxt.Location = new System.Drawing.Point(146, 137);
            this.MaxPorClienteTxt.Name = "MaxPorClienteTxt";
            this.MaxPorClienteTxt.Size = new System.Drawing.Size(204, 20);
            this.MaxPorClienteTxt.TabIndex = 18;
            this.MaxPorClienteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioListaTxt_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(40, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Stock Disponible";
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(146, 164);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(204, 20);
            this.stockTxt.TabIndex = 20;
            this.stockTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioListaTxt_KeyPress);
            // 
            // fechaVencPicker
            // 
            this.fechaVencPicker.CustomFormat = "dd/MM/yyyy";
            this.fechaVencPicker.Location = new System.Drawing.Point(147, 35);
            this.fechaVencPicker.Name = "fechaVencPicker";
            this.fechaVencPicker.Size = new System.Drawing.Size(201, 20);
            this.fechaVencPicker.TabIndex = 21;
            // 
            // fechaPublicPicker
            // 
            this.fechaPublicPicker.CustomFormat = "dd/MM/yyyy";
            this.fechaPublicPicker.Location = new System.Drawing.Point(147, 9);
            this.fechaPublicPicker.Name = "fechaPublicPicker";
            this.fechaPublicPicker.Size = new System.Drawing.Size(201, 20);
            this.fechaPublicPicker.TabIndex = 23;
            this.fechaPublicPicker.ValueChanged += new System.EventHandler(this.fechaPublicPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha Publicación";
            // 
            // AltaOfertaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 296);
            this.Controls.Add(this.fechaPublicPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaVencPicker);
            this.Controls.Add(this.stockTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MaxPorClienteTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CrearBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ProovedorCmb);
            this.Controls.Add(this.PrecioTxt);
            this.Controls.Add(this.PrecioListaTxt);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AltaOfertaForm";
            this.Text = "AltaOfertaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaOfertaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.proovedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CrearBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.ComboBox ProovedorCmb;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.TextBox PrecioListaTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox MaxPorClienteTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechaVencPicker;
        private System.Windows.Forms.BindingSource proovedorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaPublicPicker;
    }
}