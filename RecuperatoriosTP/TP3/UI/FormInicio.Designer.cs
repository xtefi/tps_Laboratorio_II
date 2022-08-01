
namespace UI
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnAcopio = new System.Windows.Forms.Button();
            this.btnMolino = new System.Windows.Forms.Button();
            this.lblImagePpal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcopio
            // 
            this.btnAcopio.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcopio.Image = ((System.Drawing.Image)(resources.GetObject("btnAcopio.Image")));
            this.btnAcopio.Location = new System.Drawing.Point(5, 135);
            this.btnAcopio.Name = "btnAcopio";
            this.btnAcopio.Size = new System.Drawing.Size(258, 163);
            this.btnAcopio.TabIndex = 0;
            this.btnAcopio.Text = "ACOPIO";
            this.btnAcopio.UseVisualStyleBackColor = true;
            this.btnAcopio.Click += new System.EventHandler(this.btnAcopio_Click_1);
            // 
            // btnMolino
            // 
            this.btnMolino.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMolino.Image = ((System.Drawing.Image)(resources.GetObject("btnMolino.Image")));
            this.btnMolino.Location = new System.Drawing.Point(5, 304);
            this.btnMolino.Name = "btnMolino";
            this.btnMolino.Size = new System.Drawing.Size(258, 163);
            this.btnMolino.TabIndex = 1;
            this.btnMolino.Text = "PERSONAS";
            this.btnMolino.UseVisualStyleBackColor = true;
            this.btnMolino.Click += new System.EventHandler(this.btnMolino_Click);
            // 
            // lblImagePpal
            // 
            this.lblImagePpal.Image = ((System.Drawing.Image)(resources.GetObject("lblImagePpal.Image")));
            this.lblImagePpal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblImagePpal.Location = new System.Drawing.Point(5, 9);
            this.lblImagePpal.Name = "lblImagePpal";
            this.lblImagePpal.Size = new System.Drawing.Size(258, 123);
            this.lblImagePpal.TabIndex = 2;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(267, 472);
            this.Controls.Add(this.lblImagePpal);
            this.Controls.Add(this.btnMolino);
            this.Controls.Add(this.btnAcopio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estefania Gomez Peverini - 2C";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcopio;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Label lblImagePpal;
    }
}

