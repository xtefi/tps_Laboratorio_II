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
                if (txtToneladas.TextLength != 0 && txtPrecio.TextLength != 0 && cmbTipoCereal.SelectedIndex != -1)
                {
                    Transportista tr = new Transportista(txtCuit.ToString(), txtNombre.ToString(), txtPatente.ToString(), Convert.ToInt64(txtToneladas), TipoGrano(), Convert.ToInt64(txtPrecio));
                    serializador.Escribir(tr, "transportistas.json");
                    this.Close();
                }
                else if(txtNombre.TextLength != 0 && txtPatente.TextLength != 0 && txtCuit.TextLength !=0)
                {
                    Transportista tr = new Transportista(txtCuit.ToString(), txtNombre.ToString(), txtPatente.ToString());
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
                aux = Granos.Grano.Trigo;
            else if (cmbTipoCereal.SelectedIndex == 1)
                aux =Granos.Grano.Maíz;
            else if (cmbTipoCereal.SelectedIndex == 1)
                aux = Granos.Grano.Soja;
            else if(cmbTipoCereal.SelectedIndex == 1)
                aux = Granos.Grano.Girasol;
            else 
                aux = Granos.Grano.Vacio;

            return aux;
        }

        private void FormNuevoTransportista_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Camión agregado!");
        }
    }
}
