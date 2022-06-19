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
    public partial class FormAcopio : Form
    {
        Acopio silo1;
        Acopio silo2;
        Acopio silo3;

        public FormAcopio()
        {
            InitializeComponent();
            silo1 = new Acopio();
            silo2 = new Acopio();
            silo3 = new Acopio();
        }
        private void FormAcopio_Load(object sender, EventArgs e)
        {
            LoadItemsInCBX();
            try
            {
                silo1 = Serializadora<Acopio>.LeerJSON("silo1.json");
                silo2 = Serializadora<Acopio>.LeerJSON("silo2.json");
                silo3 = Serializadora<Acopio>.LeerJSON("silo3.json");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"No hay información sobre los silos. Se cargaran todos como vacíos. Error: {ex.Message}");
            }
            RefreshInfo();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            int auxToneladas = Convert.ToInt32(numToneladas.Value);
            double auxHumedad = Convert.ToDouble(numHumedad.Value);
            try
            {
                switch (cbxSilos.SelectedIndex)
                {
                    case 0:
                        if (RecibirTipoGrano() == silo1.TipoGrano || silo1.TipoGrano == Granos.Grano.Vacio)
                        {
                            silo1.TipoGrano = RecibirTipoGrano();
                            silo1.LlenarSilo(auxToneladas, auxHumedad);
                        }
                        break;
                    case 1:
                        if (RecibirTipoGrano() == silo2.TipoGrano || silo2.TipoGrano == Granos.Grano.Vacio)
                        {
                            silo2.TipoGrano = RecibirTipoGrano();
                            silo2.LlenarSilo(auxToneladas, auxHumedad);
                        }
                        break;
                    case 2:
                        if (RecibirTipoGrano() == silo3.TipoGrano || silo3.TipoGrano == Granos.Grano.Vacio)
                        {
                            silo3.TipoGrano = RecibirTipoGrano();
                            silo3.LlenarSilo(auxToneladas, auxHumedad);
                        }
                        break;
                }
                RefreshInfo(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }        
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            int toneladas = Convert.ToInt32(numToneladas.Value);
            try
            {                
                switch (cbxSilos.SelectedIndex)
                {
                    case 0:
                        silo1.VaciarSilo(toneladas);
                        if (silo1.AlmacenamientoDisponible() == 1000)
                        {
                            silo1.TipoGrano = Granos.Grano.Vacio;
                            silo1.Humedad = 0;
                        }
                        break;

                    case 1:
                        silo2.VaciarSilo(toneladas);
                        if (silo2.AlmacenamientoDisponible() == 1000)
                        {
                            silo2.TipoGrano = Granos.Grano.Vacio;
                            silo2.Humedad = 0;
                        }
                        break;

                    case 2:
                        silo3.VaciarSilo(toneladas);
                        if (silo3.AlmacenamientoDisponible() == 1000)
                        {
                            silo3.TipoGrano = Granos.Grano.Vacio;
                            silo3.Humedad = 0;
                        }
                        break;
                }
                RefreshInfo();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
        private void LoadItemsInCBX()
        {
            cbxGranos.Items.Add("Soja");
            cbxGranos.Items.Add("Trigo");
            cbxGranos.Items.Add("Maiz");
            cbxGranos.Items.Add("Girasol");
            cbxSilos.Items.Add("Silo1");
            cbxSilos.Items.Add("Silo2");
            cbxSilos.Items.Add("Silo3");
        }

        private void RefreshInfo()
        {
            rtbSilo1.Text = silo1.InformacionSilo();
            rtbSilo2.Text = silo2.InformacionSilo();
            rtbSilo3.Text = silo3.InformacionSilo();          
        }
        private Granos.Grano RecibirTipoGrano()
        {
            if (cbxGranos.SelectedIndex == 0)
            {
                return Granos.Grano.Soja;
            }
            else if (cbxGranos.SelectedIndex == 1)
            {
                return Granos.Grano.Trigo;
            }
            else if (cbxGranos.SelectedIndex == 2)
            {
                return Granos.Grano.Maíz;
            }
            else return Granos.Grano.Girasol;
        }

        private void FormAcopio_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Serializadora<Acopio>.GuardarJSON(silo1, "silo1.json"); 
                Serializadora<Acopio>.GuardarJSON(silo1, "silo2.json");
                Serializadora<Acopio>.GuardarJSON(silo1, "silo3.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:{ ex.Message}");
            }
            finally
            {
                FormInicio frmInicio = new FormInicio();
                frmInicio.Show();
            }
        }

        private void rtbSilo1_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
