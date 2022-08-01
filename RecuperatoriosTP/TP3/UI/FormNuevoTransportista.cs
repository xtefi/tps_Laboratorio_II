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
                    txtPatente.TextLength != -1 && txtPatente.TextLength < 9 &&
                    cmbTipoCereal.SelectedIndex != -1)
                {
                    Transportista tr = new Transportista(txtCuit.Text, txtNombre.Text, txtPatente.Text, Convert.ToInt64(numToneladas.Value), TipoGrano(), DateTime.Now, DateTime.MaxValue);
                    transportistas.Add(tr);
                    Serializadora<List<Transportista>>.GuardarXml(transportistas, "transportistas.xml");
                    GestorDB.Alta(tr);
                    MessageBox.Show($"Se ha agregado el transporte con éxito.");
                    this.Close();
                }
                else
                    MessageBox.Show("Por favor revise los datos ingresados.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
            }

        }
        /// <summary>
        /// Carga datos en el cmbTipoCereal
        /// </summary>
        private void CargarCMB()
        {
            cmbTipoCereal.Items.Add("Trigo");
            cmbTipoCereal.Items.Add("Maíz");
            cmbTipoCereal.Items.Add("Soja");
            cmbTipoCereal.Items.Add("Girasol");
        }
        /// <summary>
        /// Carga la lista existente en archivo
        /// </summary>
        private void CargarLista()
        {
            try
            {                
                transportistas = Serializadora<List<Transportista>>.LeerXml("transportistas.xml");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
                
            }
           
        }
        /// <summary>
        /// Devuelve el tipo de grano seleccionado en el cmbTipoCereal
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Valida que se ingresen solo letras en el nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida que solo se ingresen números en el cuit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida que solo se ingresen letras y números en la patente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
