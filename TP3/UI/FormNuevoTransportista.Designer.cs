
namespace UI
{
    partial class FormNuevoTransportista
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblCereal = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.cmbTipoCereal = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numToneladas = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numToneladas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(252, 111);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(93, 15);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio del grano";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(12, 9);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 15);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(12, 208);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 15);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblCereal
            // 
            this.lblCereal.AutoSize = true;
            this.lblCereal.Location = new System.Drawing.Point(252, 208);
            this.lblCereal.Name = "lblCereal";
            this.lblCereal.Size = new System.Drawing.Size(80, 15);
            this.lblCereal.TabIndex = 4;
            this.lblCereal.Text = "Tipo de cereal";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(252, 9);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(59, 15);
            this.lblToneladas.TabIndex = 5;
            this.lblToneladas.Text = "Toneladas";
            // 
            // cmbTipoCereal
            // 
            this.cmbTipoCereal.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoCereal.FormattingEnabled = true;
            this.cmbTipoCereal.Location = new System.Drawing.Point(252, 226);
            this.cmbTipoCereal.Name = "cmbTipoCereal";
            this.cmbTipoCereal.Size = new System.Drawing.Size(168, 47);
            this.cmbTipoCereal.TabIndex = 6;
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPatente.Location = new System.Drawing.Point(12, 27);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(168, 47);
            this.txtPatente.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(12, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 47);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCuit
            // 
            this.txtCuit.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCuit.Location = new System.Drawing.Point(12, 226);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(168, 47);
            this.txtCuit.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(168, 316);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar transporte";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numToneladas
            // 
            this.numToneladas.Location = new System.Drawing.Point(261, 27);
            this.numToneladas.Name = "numToneladas";
            this.numToneladas.Size = new System.Drawing.Size(120, 23);
            this.numToneladas.TabIndex = 13;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(261, 129);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 23);
            this.numPrecio.TabIndex = 14;
            // 
            // FormNuevoTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 351);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.numToneladas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cmbTipoCereal);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCereal);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNuevoTransportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoTransportista";
            ((System.ComponentModel.ISupportInitialize)(this.numToneladas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblCereal;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.ComboBox cmbTipoCereal;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numToneladas;
        private System.Windows.Forms.NumericUpDown numPrecio;
    }
}