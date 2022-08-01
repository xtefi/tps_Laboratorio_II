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
        public List<Transportista> tr;
        private Serializadora<List<Transportista>> sr = new Serializadora<List<Transportista>>();  
        public FormTransportista()
        {
            InitializeComponent();
            tr = new List<Transportista>(); 
        }

        private void FormTransportista_Load(object sender, EventArgs e)
        {
            //HardCodeInfo();
            CargarXml();

            //CargarJSON();


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

        private void HardCodeInfo()
        {

            Transportista tr2 = new Transportista("378821134", "Mordecai", "BBB123", 18, Granos.Grano.Maíz, 87);
            Transportista tr3 = new Transportista("342232", "Pedro", "CCC123", 18, Granos.Grano.Soja, 87);
            Transportista tr4 = new Transportista("23232323", "Roberto", "DDD123", 15, Granos.Grano.Trigo, 50);
            Transportista tr5 = new Transportista("8768678", "Primo", "FFF463", 16, Granos.Grano.Girasol, 873);
            Transportista tr6 = new Transportista("5454645", "Luis", "EEE987", 21, Granos.Grano.Maíz, 873);
            tr.Add(tr2);
            tr.Add(tr3);
            tr.Add(tr4);
            tr.Add(tr5);
            tr.Add(tr6);
            Serializadora<List<Transportista>>.GuardarXml(tr, "transportistas.xml");
            
            //sr.GuardarJSON(tr, "transportistas.json");
            dgTransportista.DataSource = tr;
        }
        private void CargarXml()
        {
            List<Transportista> lista = Serializadora<List<Transportista>>.LeerXml("transportistas.xml");
            dgTransportista.DataSource = lista;
        }
        private void CargarJSON()
        {
            tr = sr.LeerJSON("transportistas.json");
            dgTransportista.DataSource = tr;
        }
    }
}
