using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;

namespace Foodtruck.Grafico
{
    public partial class ManterLanche : Form
    {
        public Lanche LancheSelecionado { get; set; }

        public ManterLanche ()
        {
            InitializeComponent();
        }
        private void btSalvarLanche_Click(object sender, EventArgs e)
        {
            Lanche lanche = new Lanche();

            lanche.Id = long.Parse(tbIdLanche.Text);
            lanche.Nome = tbNomeLanche.Text;
            lanche.Valor = decimal.Parse(tbValorLanche.Text);

            Validacao validacao;
            if (LancheSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastrarLanche(lanche);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarLanche(lanche);

            }



            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Lanche salvo com sucesso");
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterLanche_Shown(object sender, EventArgs e)
        {
            if (LancheSelecionado != null)
            {
               
                this.tbNomeLanche.Text = LancheSelecionado.Nome;
                this.tbValorLanche.Text = LancheSelecionado.Valor.ToString();
            }
        }

        private void tbNomeLanche_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaAdicionaLanche_Load(object sender, EventArgs e)
        {

        }

        private void TelaAdicionaLanche_Shown(object sender, EventArgs e)
        {
            if (LancheSelecionado != null)
            {
                this.tbIdLanche.Text = LancheSelecionado.Id.ToString();
                this.tbNomeLanche.Text = LancheSelecionado.Nome.ToString();
                this.tbValorLanche.Text = LancheSelecionado.Valor.ToString();
            }
        }

        private void textbox11_num(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Decimal && e.KeyChar != (char)Keys.Oemcomma && e.KeyChar != (char)Keys.OemPeriod)
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
        }
    }
}
