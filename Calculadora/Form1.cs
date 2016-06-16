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
        int num1 = new int();
        int num2 = new int();
        string operacao = "";
        int resultado = new int();
       

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Num1()
        {
            num1 = Convert.ToInt32(Resultado.Text);
            Resultado.Text = "";
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            Resultado.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(Resultado.Text);
            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Resultado.Text = Convert.ToString(num1, "+" + num2, "= \n" + resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Resultado.Text = Convert.ToString(num1, "+" + num2, "= \n" + resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Resultado.Text = Convert.ToString(num1, "+" + num2, "= \n" + resultado);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Resultado.Text = Convert.ToString(num1, "+" + num2, "= \n" + resultado);
                    }
                    else
                    {
                        Resultado.Text = ("Não é possível realizar esta divisão!");
                    }
                    break;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resultado.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Resultado.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Resultado.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Resultado.Text = "/";
        }

    }
}
