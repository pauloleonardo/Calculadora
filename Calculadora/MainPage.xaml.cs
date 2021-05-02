using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        string operacao = null;

        double memoriaCalcPreOperacao = 0.0;
        double memoriaCalcPosOperacao = 0.0;

        string mostrarNoVisor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void removeSinalVisor()
        {
            if(mostrarNoVisor == "+" || mostrarNoVisor == "-" || mostrarNoVisor == "*" || mostrarNoVisor == "/")
            {
                mostrarNoVisor = "";
            }
        }

        private void btnIgual(object sender, EventArgs e)
        {
            try
            {
                memoriaCalcPosOperacao = Convert.ToDouble(visor.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoriaCalcPreOperacao + memoriaCalcPosOperacao;
                        break;
                    case "-":
                        resultado = memoriaCalcPreOperacao - memoriaCalcPosOperacao;
                        break;
                    case "*":
                        resultado = memoriaCalcPreOperacao * memoriaCalcPosOperacao;
                        break;
                    case "/":
                        resultado = memoriaCalcPreOperacao / memoriaCalcPosOperacao;
                        break;
                }
                visor.Text = resultado.ToString();
            }
            catch(Exception ex) {
                visor.Text = ex.Message;
            }
        }

        private void btnSoma(object sender, EventArgs e)
        {
            memoriaCalcPreOperacao = Convert.ToDouble(visor.Text);

            mostrarNoVisor = "+";
            operacao = "+";
            visor.Text = mostrarNoVisor;
        }
        private void btnSub(object sender, EventArgs e)
        {
            memoriaCalcPreOperacao = Convert.ToDouble(visor.Text);

            mostrarNoVisor = "-";
            operacao = "-";
            visor.Text = mostrarNoVisor;
        }

        private void btnMult(object sender, EventArgs e)
        {
            memoriaCalcPreOperacao = Convert.ToDouble(visor.Text);

            mostrarNoVisor = "*";
            operacao = "*";
            visor.Text = mostrarNoVisor;
        }
        private void btnDiv(object sender, EventArgs e)
        {
            memoriaCalcPreOperacao = Convert.ToDouble(visor.Text);

            mostrarNoVisor = "/";
            operacao = "/";
            visor.Text = mostrarNoVisor;
        }

        private void btn0(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num0.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn1(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num1.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn2(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num2.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn3(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num3.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn4(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num4.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn5(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num5.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn6(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num6.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn7(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num7.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn8(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num8.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btn9(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += num9.Text;
            visor.Text = mostrarNoVisor;
        }
        private void btnPonto(object sender, EventArgs e)
        {
            removeSinalVisor();

            mostrarNoVisor += ponto.Text;
            visor.Text = mostrarNoVisor;
        }

        private void btnZerar(object sender, EventArgs e)
        {
            visor.Text = "0";
            mostrarNoVisor = "";
            memoriaCalcPosOperacao = 0.0;
            memoriaCalcPreOperacao = 0.0;
            operacao = null;
        }
        private void btnPorcento(object sender, EventArgs e)
        {
            double valorVisor = Convert.ToDouble(visor.Text);

            valorVisor = valorVisor / 100;
            visor.Text = valorVisor.ToString();
        }
        private void btnMaisMenos(object sender, EventArgs e)
        {
            double valorVisor = Convert.ToDouble(visor.Text);

            valorVisor = valorVisor * -1;
            visor.Text = valorVisor.ToString();
        }

    }
}
