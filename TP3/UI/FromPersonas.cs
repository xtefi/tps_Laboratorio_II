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
    public partial class FromPersonas : Form
    {
        Serializador<Productor> serializaProductor;
        Serializador<Transportista> serializaTransporte;
        public List<Transportista> tr = new List<Transportista>();

        public FromPersonas()
        {
            InitializeComponent();
            serializaProductor = new Serializador<Productor>(IArchivos<Productor>.ETipoArchivo.JSON);
            serializaTransporte = new Serializador<Transportista>(IArchivos<Transportista>.ETipoArchivo.JSON);
        }

        private void FromPersonas_Load(object sender, EventArgs e)
        {
            ComboMeses();
            Productor p1 = new Productor("Estancia San Juan", "66514795");
            lstProductores.Items.Add(p1.MostrarDatos());
            Transportista t1 = new Transportista("20-60505050-7", "Transportes PICHU SRL", "AA-551-AA");
            p1.Transportistas.Add(t1);
            
            
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarTransportes_Click(object sender, EventArgs e)
        {
            dgCamiones.DataSource = lstProductores.SelectedItem as Productor;
        }
        private void RefreshInfo()
        {

        }
        private void ComboMeses()
        {
            cmbMes.Items.Add("enero");
            cmbMes.Items.Add("febrero");
            cmbMes.Items.Add("marzo");
            cmbMes.Items.Add("abril");
            cmbMes.Items.Add("mayo");
            cmbMes.Items.Add("junio");
            cmbMes.Items.Add("julio");
            cmbMes.Items.Add("agosto");
            cmbMes.Items.Add("septiembre");
            cmbMes.Items.Add("octubre");
            cmbMes.Items.Add("noviembre");
            cmbMes.Items.Add("diciembre");
        }
    }
}
