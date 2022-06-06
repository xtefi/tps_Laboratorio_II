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
        public List<Transportista> tr = new List<Transportista>();
        Serializador<Transportista> serializador;

        public FormTransportista()
        {
            InitializeComponent();
            serializador = new Serializador<Transportista>(IArchivos<Transportista>.ETipoArchivo.JSON);
        }

        private void FormTransportista_Load(object sender, EventArgs e)
        {

            Transportista tr1 = new Transportista("233232", "Juan", "AAA123");
            tr.Add(tr1);

            /*
            Transportista tr2 = new Transportista("378821134", "Mordecai", "BBB123", 18,Granos.Grano.Maíz,87);
            Transportista tr3 = new Transportista("342232", "Pedro", "CCC123", 18, Granos.Grano.Soja, 87);
            Transportista tr4 = new Transportista("23232323", "Roberto", "DDD123", 15, Granos.Grano.Trigo, 50);
            Transportista tr5 = new Transportista("8768678", "Primo", "FFF463", 16, Granos.Grano.Girasol, 873);
            Transportista tr6 = new Transportista("5454645", "Luis", "EEE987", 21, Granos.Grano.Maíz, 873);
            tr.Add(tr2);
            tr.Add(tr3);
            tr.Add(tr4);
            tr.Add(tr5);
            tr.Add(tr6);
            serializador.Escribir(tr1, "transportistas.json");
            serializador.Escribir(tr2, "transportistas.json");
            serializador.Escribir(tr3, "transportistas.json");
            serializador.Escribir(tr4, "transportistas.json");
            serializador.Escribir(tr5, "transportistas.json");
            serializador.Escribir(tr6, "transportistas.json");*/
            try
            {
                tr.Add(serializador.Leer("transportistas.json"));
                dataGridView1.DataSource = tr;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No hay información sobre los transportistas. Se cargaran todos como vacíos. Error: {ex.Message}");
            }

        }

        private void dgTransportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoTransporte_Click(object sender, EventArgs e)
        {
            FormNuevoTransportista frmNuevo = new FormNuevoTransportista();
            this.Visible = false;
            frmNuevo.ShowDialog();
            this.Visible = true;
        }
    }
}
