
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransportista));
            this.btnNuevoTransporte = new System.Windows.Forms.Button();
            this.dgTransportista = new System.Windows.Forms.DataGridView();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnArchivosXml = new System.Windows.Forms.Button();
            this.btnExportarXml = new System.Windows.Forms.Button();
            this.btnCargaDB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransportista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoTransporte
            // 
            this.btnNuevoTransporte.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNuevoTransporte.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnNuevoTransporte.Location = new System.Drawing.Point(12, 292);
            this.btnNuevoTransporte.Name = "btnNuevoTransporte";
            this.btnNuevoTransporte.Size = new System.Drawing.Size(115, 45);
            this.btnNuevoTransporte.TabIndex = 1;
            this.btnNuevoTransporte.Text = "Ingresar transporte";
            this.btnNuevoTransporte.UseVisualStyleBackColor = false;
            this.btnNuevoTransporte.Click += new System.EventHandler(this.btnNuevoTransporte_Click);
            // 
            // dgTransportista
            // 
            this.dgTransportista.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dgTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransportista.GridColor = System.Drawing.Color.LightSalmon;
            this.dgTransportista.Location = new System.Drawing.Point(10, 10);
            this.dgTransportista.Name = "dgTransportista";
            this.dgTransportista.RowHeadersWidth = 51;
            this.dgTransportista.RowTemplate.Height = 25;
            this.dgTransportista.Size = new System.Drawing.Size(819, 276);
            this.dgTransportista.TabIndex = 2;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDescargar.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnDescargar.Location = new System.Drawing.Point(133, 292);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(115, 45);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.Text = "Descargar camión";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnArchivosXml
            // 
            this.btnArchivosXml.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnArchivosXml.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnArchivosXml.Location = new System.Drawing.Point(253, 292);
            this.btnArchivosXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchivosXml.Name = "btnArchivosXml";
            this.btnArchivosXml.Size = new System.Drawing.Size(115, 45);
            this.btnArchivosXml.TabIndex = 4;
            this.btnArchivosXml.Text = "Cargar desde archivo";
            this.btnArchivosXml.UseVisualStyleBackColor = false;
            this.btnArchivosXml.Click += new System.EventHandler(this.btnArchivosXml_Click);
            // 
            // btnExportarXml
            // 
            this.btnExportarXml.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnExportarXml.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnExportarXml.Location = new System.Drawing.Point(373, 291);
            this.btnExportarXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportarXml.Name = "btnExportarXml";
            this.btnExportarXml.Size = new System.Drawing.Size(115, 46);
            this.btnExportarXml.TabIndex = 5;
            this.btnExportarXml.Text = "Exportar a formato xml";
            this.btnExportarXml.UseVisualStyleBackColor = false;
            this.btnExportarXml.Click += new System.EventHandler(this.btnExportarXml_Click);
            // 
            // btnCargaDB
            // 
            this.btnCargaDB.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCargaDB.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnCargaDB.Location = new System.Drawing.Point(493, 291);
            this.btnCargaDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargaDB.Name = "btnCargaDB";
            this.btnCargaDB.Size = new System.Drawing.Size(115, 46);
            this.btnCargaDB.TabIndex = 6;
            this.btnCargaDB.Text = "Cargar desde base de datos";
            this.btnCargaDB.UseVisualStyleBackColor = false;
            this.btnCargaDB.Click += new System.EventHandler(this.btnCargaDB_Click);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblHora.Location = new System.Drawing.Point(644, 292);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(186, 45);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = " ";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 343);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnCargaDB);
            this.Controls.Add(this.btnExportarXml);
            this.Controls.Add(this.btnArchivosXml);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.dgTransportista);
            this.Controls.Add(this.btnNuevoTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTransportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de transportistas";
            this.Load += new System.EventHandler(this.FormTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransportista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoTransporte;
        private System.Windows.Forms.DataGridView dgTransportista;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnArchivosXml;
        private System.Windows.Forms.Button btnExportarXml;
        private System.Windows.Forms.Button btnCargaDB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblHora;
    }
}