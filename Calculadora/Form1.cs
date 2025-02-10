using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text += "9";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtBoxRes.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtBoxRes.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtBoxRes.Text = Convert.ToString(valor1 *  valor2);
            }
            else if (operacao == "DIV")
            {
                txtBoxRes.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "PORC")
            {
                txtBoxRes.Text = Convert.ToString((valor1 / 100) * valor2);
            }
            else if (operacao == "MOD")
            {
                txtBoxRes.Text = Convert.ToString(valor1 % valor2);
            }
            else if (operacao == "EXP"){
                double resultado = Math.Pow((double)valor1, (double)valor2);
                txtBoxRes.Text = resultado.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma!");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "SUB";
                labelOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "MULT";
                labelOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "DIV";
                labelOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!");
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "PORC";
                labelOperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a porcentagem!");
            }
        }
        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "MOD";
                labelOperacao.Text = "mod";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o modúlo!");
            }
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                if (valor1 >= 0)
                {
                    double resultado = Math.Sqrt((double)valor1);
                    txtBoxRes.Text = resultado.ToString();
                    labelOperacao.Text = "√";
                }
                else
                {
                    MessageBox.Show("Não é possível calcular a raiz quadrada de um número negativo!");
                }
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a raíz quadrada!");
            }
        }

        private void btnExponenciacao_Click(object sender, EventArgs e)
        {
            if (txtBoxRes.Text != "")
            {
                valor1 = decimal.Parse(txtBoxRes.Text, CultureInfo.InvariantCulture);
                txtBoxRes.Text = "";
                operacao = "EXP";
                labelOperacao.Text = "^";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a exponenciação!");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text = "";
            labelOperacao.Text = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtBoxRes.Text.Contains("."))
            {
                txtBoxRes.Text += ".";
            }
            
        }
    }
}
