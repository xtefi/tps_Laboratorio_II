using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Enumerados;

namespace UI
{
    public partial class FormTransportista : Form
    {
        public List<Transportista> transportistas;
        
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

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                Transportista selected = dgTransportista.SelectedRows[0].DataBoundItem as Transportista;
                selected.FechaDescarga = DateTime.Now;
                selected.Toneladas = 0;
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
            Serializadora<List<Transportista>>.GuardarXml(transportistas, "transportistas.xml");
        }

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
    }
}
