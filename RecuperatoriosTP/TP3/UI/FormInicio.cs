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

namespace UI
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAcopio_Click_1(object sender, EventArgs e)
        {            
            FormAcopio frmAcopio = new FormAcopio();
            this.Visible = false;
            frmAcopio.ShowDialog();
            this.Visible = true;
        }

        private void btnMolino_Click(object sender, EventArgs e)
        {
            FormTransportista frmTransp = new FormTransportista();
            this.Visible = false;
            frmTransp.ShowDialog();
            this.Visible = true;
        }
    }
}
