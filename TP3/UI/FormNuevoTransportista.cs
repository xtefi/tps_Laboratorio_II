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
    public partial class FormNuevoTransportista : Form
    {
        Serializador<Transportista> serializador;
        public FormNuevoTransportista()
        {
            InitializeComponent();
            CargarCMB();
            serializador = new Serializador<Transportista>(IArchivos<Transportista>.ETipoArchivo.JSON);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCuit.TextLength != 0 && txtNombre.TextLength != 0 && txtPatente.TextLength != -1 && cmbTipoCereal.SelectedIndex != -1)
                {
                    Transportista tr = new Transportista(txtCuit.Text, txtNombre.Text, txtPatente.Text, Convert.ToInt64(numToneladas.Value), TipoGrano(), Convert.ToInt64(numPrecio.Value));
                    serializador.Escribir(tr, "transportistas.json");
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
