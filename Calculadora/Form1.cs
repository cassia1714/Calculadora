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
    public partial class form1 : Form
    {
      public decimal Resultado { get; set; }
      public decimal valor { get; set; }
        private Operacao OperacaoSelecionada {  get; set; }
       private enum Operacao
        {
            adicao,
            subtração,
            Multiplicacao,
            Divisao
        }
        public form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.adicao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";

            

        }


        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.subtração;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada) 
            {
                case Operacao.adicao:
                Resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.subtração:
                    Resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                    case Operacao.Divisao:
                    Resultado = valor / Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    break;
            }
              txtResultado.Text = Convert.ToString(Resultado);
        
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

