
namespace UI
{
    partial class FormAcopio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcopio));
            this.rtbSilo1 = new System.Windows.Forms.RichTextBox();
            this.rtbSilo2 = new System.Windows.Forms.RichTextBox();
            this.rtbSilo3 = new System.Windows.Forms.RichTextBox();
            this.lblSilo1 = new System.Windows.Forms.Label();
            this.lblSilo2 = new System.Windows.Forms.Label();
            this.lblSilo3 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.cbxSilos = new System.Windows.Forms.ComboBox();
            this.cbxGranos = new System.Windows.Forms.ComboBox();
            this.numHumedad = new System.Windows.Forms.NumericUpDown();
            this.numToneladas = new System.Windows.Forms.NumericUpDown();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lblGranos = new System.Windows.Forms.Label();
            this.lblSilo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToneladas)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbSilo1
            // 
            this.rtbSilo1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbSilo1.Location = new System.Drawing.Point(15, 44);
            this.rtbSilo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbSilo1.Name = "rtbSilo1";
            this.rtbSilo1.Size = new System.Drawing.Size(207, 198);
            this.rtbSilo1.TabIndex = 0;
            this.rtbSilo1.Text = "";
            // 
            // rtbSilo2
            // 
            this.rtbSilo2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbSilo2.Location = new System.Drawing.Point(231, 44);
            this.rtbSilo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbSilo2.Name = "rtbSilo2";
            this.rtbSilo2.Size = new System.Drawing.Size(207, 198);
            this.rtbSilo2.TabIndex = 1;
            this.rtbSilo2.Text = "";
            // 
            // rtbSilo3
            // 
            this.rtbSilo3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbSilo3.Location = new System.Drawing.Point(447, 44);
            this.rtbSilo3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbSilo3.Name = "rtbSilo3";
            this.rtbSilo3.Size = new System.Drawing.Size(207, 198);
            this.rtbSilo3.TabIndex = 2;
            this.rtbSilo3.Text = "";
            // 
            // lblSilo1
            // 
            this.lblSilo1.AutoSize = true;
            this.lblSilo1.Location = new System.Drawing.Point(15, 11);
            this.lblSilo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilo1.Name = "lblSilo1";
            this.lblSilo1.Size = new System.Drawing.Size(46, 19);
            this.lblSilo1.TabIndex = 3;
            this.lblSilo1.Text = "Silo 1";
            // 
            // lblSilo2
            // 
            this.lblSilo2.AutoSize = true;
            this.lblSilo2.Location = new System.Drawing.Point(231, 11);
            this.lblSilo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilo2.Name = "lblSilo2";
            this.lblSilo2.Size = new System.Drawing.Size(46, 19);
            this.lblSilo2.TabIndex = 4;
            this.lblSilo2.Text = "Silo 2";
            // 
            // lblSilo3
            // 
            this.lblSilo3.AutoSize = true;
            this.lblSilo3.Location = new System.Drawing.Point(447, 11);
            this.lblSilo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilo3.Name = "lblSilo3";
            this.lblSilo3.Size = new System.Drawing.Size(46, 19);
            this.lblSilo3.TabIndex = 5;
            this.lblSilo3.Text = "Silo 3";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnIngreso.Location = new System.Drawing.Point(447, 275);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(185, 53);
            this.btnIngreso.TabIndex = 8;
            this.btnIngreso.Text = "Ingresar cereal";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExtraer.Location = new System.Drawing.Point(447, 347);
            this.btnExtraer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(185, 53);
            this.btnExtraer.TabIndex = 9;
            this.btnExtraer.Text = "Extraer cereal";
            this.btnExtraer.UseVisualStyleBackColor = false;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // cbxSilos
            // 
            this.cbxSilos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxSilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSilos.FormattingEnabled = true;
            this.cbxSilos.Location = new System.Drawing.Point(231, 289);
            this.cbxSilos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSilos.Name = "cbxSilos";
            this.cbxSilos.Size = new System.Drawing.Size(154, 27);
            this.cbxSilos.TabIndex = 10;
            // 
            // cbxGranos
            // 
            this.cbxGranos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxGranos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGranos.FormattingEnabled = true;
            this.cbxGranos.Location = new System.Drawing.Point(15, 289);
            this.cbxGranos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxGranos.Name = "cbxGranos";
            this.cbxGranos.Size = new System.Drawing.Size(154, 27);
            this.cbxGranos.TabIndex = 11;
            // 
            // numHumedad
            // 
            this.numHumedad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numHumedad.ForeColor = System.Drawing.Color.LightSalmon;
            this.numHumedad.Location = new System.Drawing.Point(15, 362);
            this.numHumedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numHumedad.Name = "numHumedad";
            this.numHumedad.Size = new System.Drawing.Size(174, 27);
            this.numHumedad.TabIndex = 12;
            // 
            // numToneladas
            // 
            this.numToneladas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numToneladas.ForeColor = System.Drawing.Color.LightSalmon;
            this.numToneladas.Location = new System.Drawing.Point(231, 362);
            this.numToneladas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numToneladas.Name = "numToneladas";
            this.numToneladas.Size = new System.Drawing.Size(154, 27);
            this.numToneladas.TabIndex = 13;
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.Location = new System.Drawing.Point(15, 339);
            this.lblHumedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(174, 19);
            this.lblHumedad.TabIndex = 14;
            this.lblHumedad.Text = "Humedad (solo ingreso)";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(231, 339);
            this.lblToneladas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(79, 19);
            this.lblToneladas.TabIndex = 15;
            this.lblToneladas.Text = "Toneladas";
            // 
            // lblGranos
            // 
            this.lblGranos.AutoSize = true;
            this.lblGranos.Location = new System.Drawing.Point(15, 266);
            this.lblGranos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGranos.Name = "lblGranos";
            this.lblGranos.Size = new System.Drawing.Size(59, 19);
            this.lblGranos.TabIndex = 16;
            this.lblGranos.Text = "Granos";
            // 
            // lblSilo
            // 
            this.lblSilo.AutoSize = true;
            this.lblSilo.Location = new System.Drawing.Point(231, 266);
            this.lblSilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilo.Name = "lblSilo";
            this.lblSilo.Size = new System.Drawing.Size(35, 19);
            this.lblSilo.TabIndex = 17;
            this.lblSilo.Text = "Silo";
            // 
            // FormAcopio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(672, 422);
            this.Controls.Add(this.lblSilo);
            this.Controls.Add(this.lblGranos);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblHumedad);
            this.Controls.Add(this.numToneladas);
            this.Controls.Add(this.numHumedad);
            this.Controls.Add(this.cbxGranos);
            this.Controls.Add(this.cbxSilos);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.lblSilo3);
            this.Controls.Add(this.lblSilo2);
            this.Controls.Add(this.lblSilo1);
            this.Controls.Add(this.rtbSilo3);
            this.Controls.Add(this.rtbSilo2);
            this.Controls.Add(this.rtbSilo1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormAcopio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acopio de cereales y oleaginosas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAcopio_FormClosing);
            this.Load += new System.EventHandler(this.FormAcopio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToneladas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSilo1;
        private System.Windows.Forms.RichTextBox rtbSilo2;
        private System.Windows.Forms.RichTextBox rtbSilo3;
        private System.Windows.Forms.Label lblSilo1;
        private System.Windows.Forms.Label lblSilo2;
        private System.Windows.Forms.Label lblSilo3;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.ComboBox cbxSilos;
        private System.Windows.Forms.ComboBox cbxGranos;
        private System.Windows.Forms.NumericUpDown numHumedad;
        private System.Windows.Forms.NumericUpDown numToneladas;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.Label lblGranos;
        private System.Windows.Forms.Label lblSilo;
    }
}