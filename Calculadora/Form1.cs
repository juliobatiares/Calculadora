using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor, verifique se os números foram digitados.");
            }
            else if (txtNumero2.Text == "0")
            {
                MessageBox.Show("Não é possível realizar uma divisão por 0.");
            }
            else
            {
                int intNum1;
                int intNum2;
                int intDivisao;

                intNum1 = Convert.ToInt16(txtNumero1.Text);
                intNum2 = Convert.ToInt16(txtNumero2.Text);
                intDivisao = intNum1 / intNum2;

                txtExpressao.Text = intNum1 + " / " + intNum2 + " =";
                txtResultado.Text = Convert.ToString(intDivisao);
            }
        }

        private void bntAdicao_Click(object sender, EventArgs e)
        {

            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor, verifique se os números foram digitados.");
            }
            else
            {
                int intNum1;
                int intNum2;
                int intSoma;

                intNum1 = Convert.ToInt16(txtNumero1.Text);
                intNum2 = Convert.ToInt16(txtNumero2.Text);
                intSoma = intNum1 + intNum2;

                txtExpressao.Text = intNum1 + " + " + intNum2 + " =";
                txtResultado.Text = Convert.ToString(intSoma);
            }
        }

        private void Subtracao(object sender, EventArgs e)
        {
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor, verifique se os números foram digitados.");
            }
            else
            {
                int intNum1;
                int intNum2;
                int intSubtracao;

                intNum1 = Convert.ToInt16(txtNumero1.Text);
                intNum2 = Convert.ToInt16(txtNumero2.Text);
                intSubtracao = intNum1 - intNum2;

                txtExpressao.Text = intNum1 + " - " + intNum2 + " =";
                txtResultado.Text = Convert.ToString(intSubtracao);
            }
        }

        private void Multiplicacao(object sender, EventArgs e)
        {
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor, verifique se os números foram digitados.");
            }
            else
            {
                int intNum1;
                int intNum2;
                int intMultiplicacao;

                intNum1 = Convert.ToInt16(txtNumero1.Text);
                intNum2 = Convert.ToInt16(txtNumero2.Text);
                intMultiplicacao = intNum1 * intNum2;

                txtExpressao.Text = intNum1 + " * " + intNum2 + " =";
                txtResultado.Text = Convert.ToString(intMultiplicacao);
            }
        }

        private void btnFechar(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpar(object sender, EventArgs e)
        {
            txtNumero1.Text     = "";
            txtNumero2.Text     = "";
            txtExpressao.Text   = "";
            txtResultado.Text   = "";
        }
    }
}
