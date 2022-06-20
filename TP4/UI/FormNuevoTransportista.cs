using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Datos;
using Entidades.Enumerados;
using Entidades.Personas;

namespace UI
{
    public partial class FormNuevoTransportista : Form
    {
        private List<Transportista> transportistas;
        public FormNuevoTransportista()
        {
            InitializeComponent();
            CargarCMB();
            CargarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCuit.TextLength != 0 && 
                    txtNombre.TextLength != 0 && 
                    txtPatente.TextLength != -1 && 
                    cmbTipoCereal.SelectedIndex != -1)
                {
                    Transportista tr = new Transportista(txtCuit.Text, txtNombre.Text, txtPatente.Text, Convert.ToInt64(numToneladas.Value), TipoGrano());
                    transportistas.Add(tr);
                    Serializadora<List<Transportista>>.GuardarXml(transportistas, "transportistas.xml");
                    GestorDB.Alta(tr);
                    MessageBox.Show($"Se ha agregado el transporte con éxito.");
                    this.Close();
                }
                else
                    MessageBox.Show("Campos vacíos, por favor revise.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
            }

        }
        private void CargarCMB()
        {
            cmbTipoCereal.Items.Add("Trigo");
            cmbTipoCereal.Items.Add("Maíz");
            cmbTipoCereal.Items.Add("Soja");
            cmbTipoCereal.Items.Add("Girasol");
        }
        private void CargarLista()
        {
            try
            {                
                transportistas = Serializadora<List<Transportista>>.LeerXml("transportistas.xml");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
                
            }
           
        }
        
        private Granos.Grano TipoGrano()
        {
            Granos.Grano aux;
            if (cmbTipoCereal.SelectedIndex == 0)
            {
                aux = Granos.Grano.Trigo;
            }
            else if (cmbTipoCereal.SelectedIndex == 1)
            {
                aux = Granos.Grano.Maíz;
            }
            else if (cmbTipoCereal.SelectedIndex == 2)
            {
                aux = Granos.Grano.Soja;
            }
            else
            {
                aux = Granos.Grano.Girasol;
            }
            return aux;
        }
        
    }
}
