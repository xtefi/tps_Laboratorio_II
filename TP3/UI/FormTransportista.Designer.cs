
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
            this.btnNuevoTransporte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoTransporte
            // 
            this.btnNuevoTransporte.Location = new System.Drawing.Point(12, 280);
            this.btnNuevoTransporte.Name = "btnNuevoTransporte";
            this.btnNuevoTransporte.Size = new System.Drawing.Size(115, 45);
            this.btnNuevoTransporte.TabIndex = 1;
            this.btnNuevoTransporte.Text = "Ingresar transporte";
            this.btnNuevoTransporte.UseVisualStyleBackColor = true;
            this.btnNuevoTransporte.Click += new System.EventHandler(this.btnNuevoTransporte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(742, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevoTransporte);
            this.Name = "FormTransportista";
            this.Text = "FormTransportista";
            this.Load += new System.EventHandler(this.FormTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoTransporte;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}