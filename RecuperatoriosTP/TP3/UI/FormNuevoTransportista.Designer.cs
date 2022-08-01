
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoTransportista));
            this.lblNombre = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numToneladas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(12, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(12, 9);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(64, 19);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCUIT.ForeColor = System.Drawing.Color.Black;
            this.lblCUIT.Location = new System.Drawing.Point(12, 166);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(42, 19);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblCereal
            // 
            this.lblCereal.AutoSize = true;
            this.lblCereal.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCereal.ForeColor = System.Drawing.Color.Black;
            this.lblCereal.Location = new System.Drawing.Point(252, 89);
            this.lblCereal.Name = "lblCereal";
            this.lblCereal.Size = new System.Drawing.Size(104, 19);
            this.lblCereal.TabIndex = 4;
            this.lblCereal.Text = "Tipo de cereal";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToneladas.ForeColor = System.Drawing.Color.Black;
            this.lblToneladas.Location = new System.Drawing.Point(252, 9);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(79, 19);
            this.lblToneladas.TabIndex = 5;
            this.lblToneladas.Text = "Toneladas";
            // 
            // cmbTipoCereal
            // 
            this.cmbTipoCereal.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmbTipoCereal.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoCereal.ForeColor = System.Drawing.Color.LightSalmon;
            this.cmbTipoCereal.FormattingEnabled = true;
            this.cmbTipoCereal.Location = new System.Drawing.Point(252, 107);
            this.cmbTipoCereal.Name = "cmbTipoCereal";
            this.cmbTipoCereal.Size = new System.Drawing.Size(168, 47);
            this.cmbTipoCereal.TabIndex = 5;
            // 
            // txtPatente
            // 
            this.txtPatente.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPatente.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPatente.ForeColor = System.Drawing.Color.LightSalmon;
            this.txtPatente.Location = new System.Drawing.Point(12, 27);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(206, 47);
            this.txtPatente.TabIndex = 1;
            this.txtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatente_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.LightSalmon;
            this.txtNombre.Location = new System.Drawing.Point(12, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 47);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCuit
            // 
            this.txtCuit.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCuit.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCuit.ForeColor = System.Drawing.Color.LightSalmon;
            this.txtCuit.Location = new System.Drawing.Point(12, 189);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(206, 47);
            this.txtCuit.TabIndex = 3;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(252, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar transporte";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numToneladas
            // 
            this.numToneladas.BackColor = System.Drawing.SystemColors.InfoText;
            this.numToneladas.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numToneladas.ForeColor = System.Drawing.Color.LightSalmon;
            this.numToneladas.Location = new System.Drawing.Point(261, 27);
            this.numToneladas.Name = "numToneladas";
            this.numToneladas.Size = new System.Drawing.Size(158, 47);
            this.numToneladas.TabIndex = 4;
            // 
            // FormNuevoTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 249);
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
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNuevoTransportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso nuevo transportista";
            ((System.ComponentModel.ISupportInitialize)(this.numToneladas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
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
    }
}