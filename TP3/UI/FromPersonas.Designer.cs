
namespace UI
{
    partial class FromPersonas
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
            this.lstProductores = new System.Windows.Forms.ListBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnNuevoTransportista = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoProductor = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMostrarTransportes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCamiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProductores
            // 
            this.lstProductores.FormattingEnabled = true;
            this.lstProductores.ItemHeight = 15;
            this.lstProductores.Location = new System.Drawing.Point(12, 33);
            this.lstProductores.Name = "lstProductores";
            this.lstProductores.Size = new System.Drawing.Size(205, 214);
            this.lstProductores.TabIndex = 0;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(582, 384);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(121, 38);
            this.btnFacturar.TabIndex = 1;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnNuevoTransportista
            // 
            this.btnNuevoTransportista.Location = new System.Drawing.Point(294, 364);
            this.btnNuevoTransportista.Name = "btnNuevoTransportista";
            this.btnNuevoTransportista.Size = new System.Drawing.Size(121, 39);
            this.btnNuevoTransportista.TabIndex = 2;
            this.btnNuevoTransportista.Text = "Ingresar camión";
            this.btnNuevoTransportista.UseVisualStyleBackColor = true;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(444, 392);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 23);
            this.cmbMes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de productores";
            // 
            // btnNuevoProductor
            // 
            this.btnNuevoProductor.Location = new System.Drawing.Point(12, 383);
            this.btnNuevoProductor.Name = "btnNuevoProductor";
            this.btnNuevoProductor.Size = new System.Drawing.Size(121, 39);
            this.btnNuevoProductor.TabIndex = 5;
            this.btnNuevoProductor.Text = "Nuevo productor";
            this.btnNuevoProductor.UseVisualStyleBackColor = true;
            this.btnNuevoProductor.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(561, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(142, 166);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btnMostrarTransportes
            // 
            this.btnMostrarTransportes.Location = new System.Drawing.Point(223, 110);
            this.btnMostrarTransportes.Name = "btnMostrarTransportes";
            this.btnMostrarTransportes.Size = new System.Drawing.Size(51, 43);
            this.btnMostrarTransportes.TabIndex = 8;
            this.btnMostrarTransportes.Text = ">>";
            this.btnMostrarTransportes.UseVisualStyleBackColor = true;
            this.btnMostrarTransportes.Click += new System.EventHandler(this.btnMostrarTransportes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Camiones del productor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mes a facturar:";
            // 
            // dgCamiones
            // 
            this.dgCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCamiones.Location = new System.Drawing.Point(280, 42);
            this.dgCamiones.Name = "dgCamiones";
            this.dgCamiones.RowTemplate.Height = 25;
            this.dgCamiones.Size = new System.Drawing.Size(423, 164);
            this.dgCamiones.TabIndex = 11;
            // 
            // FromPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 434);
            this.Controls.Add(this.dgCamiones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarTransportes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNuevoProductor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnNuevoTransportista);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lstProductores);
            this.Name = "FromPersonas";
            this.Text = "FromPersonas";
            this.Load += new System.EventHandler(this.FromPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductores;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnNuevoTransportista;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoProductor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMostrarTransportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgCamiones;
    }
}