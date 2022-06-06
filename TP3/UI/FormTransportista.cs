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
        public FormTransportista()
        {
            InitializeComponent();
        }

        private void FormTransportista_Load(object sender, EventArgs e)
        {

            Transportista tr1 = new Transportista("233232", "Juan", "AAA123");
            tr.Add(tr1);


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
            dgTransportistas.DataSource = tr;

        }

        private void dgTransportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
