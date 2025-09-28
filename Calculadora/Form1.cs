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
    public partial class Calculadora : Form
    {
        private double valor = 0;
        private string operacao = "";
        private bool operacaoPress = false;
        private bool novoCalculo = true;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            valor = 0;
            operacao = "";
            operacaoPress = false;
            novoCalculo = true;
        }

        private void buttonClick(object sender, EventArgs e)
        {

            Button botao = (Button)sender;

            if (textDisplay.Text == "0" || operacaoPress || novoCalculo)
            {
                textDisplay.Text = "";
                operacaoPress = false;
                novoCalculo = false;
            }

            if (botao.Text == ",")
            {
                if (!textDisplay.Text.Contains(","))
                {
                    textDisplay.Text += botao.Text;
                }
            }
            else
            {
                textDisplay.Text += botao.Text;
            }
        }

        private void buttonOperacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (!operacaoPress)
            {
                if (double.TryParse(textDisplay.Text, out double valorAtual))
                {
                    valor = valorAtual;
                }
                else
                {
                    textDisplay.Text = "Erro";
                    return;
                }
            }

            operacao = botao.Text;
            operacaoPress = true;
            novoCalculo = false;
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textDisplay.Text, out double valorAtual))
            {
                if (valorAtual >= 0)
                {
                    double resultado = Math.Sqrt(valorAtual);
                    textDisplay.Text = resultado.ToString();
                }
                else
                {
                    textDisplay.Text = "Erro";
                }
            }
            novoCalculo = true;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "") return;

            if (double.TryParse(textDisplay.Text, out double valor1))
            {
                double resultado = 0;
                switch (operacao)
                {
                    case "+":
                        resultado = valor + valor1;
                        break;
                    case "-":
                        resultado = valor - valor1;
                        break;
                    case "*":
                        resultado = valor * valor1;
                        break;
                    case "/":
                        if (valor1 != 0)
                        {
                            resultado = valor / valor1;
                        }
                        else
                        {
                            textDisplay.Text = "Div/0!";
                            valor = 0;
                            operacao = "";
                            novoCalculo = true;
                            return;
                        }
                        break;
                    case "^":
                        resultado = Math.Pow(valor, valor1);
                        break;
                }

                textDisplay.Text = resultado.ToString();
                valor = resultado;
                operacao = "";
                novoCalculo = true;
            }
            else
            {
                textDisplay.Text = "Erro";
            }

        }

        private void buttonNegPos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textDisplay.Text, out double valorAtual))
            {
                double resultado = valorAtual * -1;
                textDisplay.Text = resultado.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var dlg = new AboutForm())
            {
                dlg.ShowDialog(this);
            }
        }
    }
}