using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class FrmLoja : Form
    {
        public FrmLoja()
        {
            InitializeComponent();
        }
     
       

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textBoxCliente.Clear();
            textBoxQuantidade.Clear();
            textBoxValorcompra.Clear();
            textBoxValordesc.Clear();
            textBoxValorpagar.Clear();
            textBoxMensagem.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            
            int num = int.Parse(textBoxQuantidade.Text);
            string nome = textBoxCliente.Text;

            double valorDesconto = 0;
            
            double valorCompra = num * 20;
            textBoxValorcompra.Text = valorCompra.ToString();



            if (num < 20)
            {
                valorDesconto = 0;               
            }
            else if (num <=25)
            {
                valorDesconto = valorCompra * 0.05;             
            }
            else if (num >=25)
            {
                valorDesconto = valorCompra * 0.12;
            }
            textBoxValordesc.Text = valorDesconto.ToString();

            double valorPagar = valorCompra - valorDesconto;

            textBoxValorpagar.Text = valorPagar.ToString();

            textBoxMensagem.Text = "Parabéns! " + nome + " Você economizou R$ " + valorDesconto;
        }

        private void TextBoxCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxValorcompra_TextChanged(object sender, EventArgs e)
        {
         }

        private void TextBoxValordesc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxValorpagar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxMensagem_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
