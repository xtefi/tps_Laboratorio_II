
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
            this.btnNuevoTransporte.Location = new System.Drawing.Point(14, 389);
            this.btnNuevoTransporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoTransporte.Name = "btnNuevoTransporte";
            this.btnNuevoTransporte.Size = new System.Drawing.Size(131, 60);
            this.btnNuevoTransporte.TabIndex = 1;
            this.btnNuevoTransporte.Text = "Ingresar transporte";
            this.btnNuevoTransporte.UseVisualStyleBackColor = true;
            this.btnNuevoTransporte.Click += new System.EventHandler(this.btnNuevoTransporte_Click);
            // 
            // dgTransportista
            // 
            this.dgTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransportista.Location = new System.Drawing.Point(12, 13);
            this.dgTransportista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgTransportista.Name = "dgTransportista";
            this.dgTransportista.RowHeadersWidth = 51;
            this.dgTransportista.RowTemplate.Height = 25;
            this.dgTransportista.Size = new System.Drawing.Size(936, 368);
            this.dgTransportista.TabIndex = 2;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(152, 389);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(131, 60);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.Text = "Descargar camión";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnArchivosXml
            // 
            this.btnArchivosXml.Location = new System.Drawing.Point(289, 389);
            this.btnArchivosXml.Name = "btnArchivosXml";
            this.btnArchivosXml.Size = new System.Drawing.Size(131, 60);
            this.btnArchivosXml.TabIndex = 4;
            this.btnArchivosXml.Text = "Cargar desde archivo";
            this.btnArchivosXml.UseVisualStyleBackColor = true;
            this.btnArchivosXml.Click += new System.EventHandler(this.btnArchivosXml_Click);
            // 
            // btnExportarXml
            // 
            this.btnExportarXml.Location = new System.Drawing.Point(426, 388);
            this.btnExportarXml.Name = "btnExportarXml";
            this.btnExportarXml.Size = new System.Drawing.Size(131, 61);
            this.btnExportarXml.TabIndex = 5;
            this.btnExportarXml.Text = "Exportar a formato xml";
            this.btnExportarXml.UseVisualStyleBackColor = true;
            this.btnExportarXml.Click += new System.EventHandler(this.btnExportarXml_Click);
            // 
            // btnCargaDB
            // 
            this.btnCargaDB.Location = new System.Drawing.Point(563, 388);
            this.btnCargaDB.Name = "btnCargaDB";
            this.btnCargaDB.Size = new System.Drawing.Size(131, 61);
            this.btnCargaDB.TabIndex = 6;
            this.btnCargaDB.Text = "Cargar desde base de datos";
            this.btnCargaDB.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(736, 389);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(212, 60);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = " ";
            // 
            // FormTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 457);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnCargaDB);
            this.Controls.Add(this.btnExportarXml);
            this.Controls.Add(this.btnArchivosXml);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.dgTransportista);
            this.Controls.Add(this.btnNuevoTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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