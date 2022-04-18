using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BoxOperadores();
            Limpiar();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = true;
            this.btnConvertirABinario.Enabled = false;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = (Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text)).ToString();
            this.btnConvertirABinario.Enabled = true;
            lstOperaciones.Items.Add($"{this.txtNumero1.Text} {this.cmbOperador.Text} {this.txtNumero2.Text} = {this.lblResultado.Text}");
        }
        /// <summary>
        /// Limpia los datos de la pantalla
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = " ";
            this.btnConvertirADecimal.Enabled = true;
            this.btnConvertirABinario.Enabled = true;
            this.cmbOperador.Text = " ";
        }
        /// <summary>
        /// Realiza cálculo según operador escogido y números ingresados
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            if(!string.IsNullOrEmpty(numero1) && !string.IsNullOrEmpty(numero2) && !string.IsNullOrEmpty(operador))
            {
                Operando operador1 = new Operando(numero1);
                Operando operador2 = new Operando(numero2);
                return Calculadora.Operar(operador1, operador2,char.Parse(operador));
            }
            return 0;            
        }
        /// <summary>
        /// Carga los elementos del cmbOperador
        /// </summary>
        private void BoxOperadores()
        {
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
        }
        /// <summary>
        /// Controla que se ingresen solo números y una sola coma en el cuadro de texto 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Controla que se ingresen solo números y una sola coma en el cuadro de texto 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Cerrando la calculadora", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
