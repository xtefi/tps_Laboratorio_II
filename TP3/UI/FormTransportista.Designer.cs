
namespace UI
{
    partial class FormTransportista
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
            this.dgTransportistas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTransportistas
            // 
            this.dgTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransportistas.Location = new System.Drawing.Point(12, 12);
            this.dgTransportistas.Name = "dgTransportistas";
            this.dgTransportistas.RowTemplate.Height = 25;
            this.dgTransportistas.Size = new System.Drawing.Size(747, 246);
            this.dgTransportistas.TabIndex = 0;
            this.dgTransportistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransportistas_CellContentClick);
            // 
            // FormTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 351);
            this.Controls.Add(this.dgTransportistas);
            this.Name = "FormTransportista";
            this.Text = "FormTransportista";
            this.Load += new System.EventHandler(this.FormTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransportistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTransportistas;
    }
}