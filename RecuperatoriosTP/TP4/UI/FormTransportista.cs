using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Datos;
using Entidades.Enumerados;
using Entidades.Personas;

namespace UI
{
    public partial class FormTransportista : Form
    {
        private List<Transportista> transportistas;
        delegate void MiDelegado(int i);
        public FormTransportista()
        {
            InitializeComponent();
            transportistas = new List<Transportista>();

        }

        private void FormTransportista_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoTransporte_Click(object sender, EventArgs e)
        {
            FormNuevoTransportista frmNuevo = new FormNuevoTransportista();
            this.Visible = false;
            frmNuevo.ShowDialog();
            this.Visible = true;
        }
        /// <summary>
        /// Se pone en "0" las toneladas del camion y se registra fecha+hora actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                Transportista selected = dgTransportista.SelectedRows[0].DataBoundItem as Transportista;
                if(selected.FechaDescarga == DateTime.MinValue)
                {
                    selected.FechaDescarga = DateTime.Now;
                    selected.Toneladas = 0;
                    GestorDB.ActualizarDatosDescarga(selected, selected.Id);
                    Task.Run(MostrarMensajeDescarga);
                }
                else
                {
                    MessageBox.Show($"El camion seleccionado se encuentra descargado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
            }
        }
        private void btnArchivosXml_Click(object sender, EventArgs e)
        {
            try{
                List<Transportista> lista = Serializadora<List<Transportista>>.LeerXml("transportistas.xml");
                dgTransportista.DataSource = lista;
            }
            catch(Exception ex){
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
            }
        }

        private void btnExportarXml_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<List<Transportista>>.GuardarXml(transportistas, "transportistas.xml");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
            }
        }
        private void btnCargaDB_Click(object sender, EventArgs e)
        {
            CargarDesdeDB();
        }
        /// <summary>
        /// Se cargan datos desde una base de datos
        /// </summary>
        private void CargarDesdeDB()
        {
            try
            {
                List<Transportista> lista = GestorDB.LeerDatos();
                dgTransportista.DataSource = lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MensajeDescarga(int i)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    MiDelegado llamador = new MiDelegado(MensajeDescarga);
                    object[] args = { i };
                    this.BeginInvoke(llamador, args);
                }
                else
                {
                    this.lblHora.Text = $"Descargando camion en {i}";
                    if(i<1)
                    {
                        this.lblHora.Text = "Camion descargado.";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }              
        }
        private void MostrarMensajeDescarga()
        {
            for(int i=3; i>-1; i--)
            {
                MensajeDescarga(i);
                Thread.Sleep(1000);
            }
        }
    }
}
