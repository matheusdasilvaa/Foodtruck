using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class ManterBebida : Form
    {
        public Bebida BebidaSelecionada { get; set; }

        public ManterBebida()
        {
            InitializeComponent();
        }

        private void ManterBebida_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bebida bebida = new Bebida();

            bebida.Id = long.Parse(tbIdBebida.Text);
            bebida.Nome = tbNomeBebida.Text;
            bebida.Tamanho = float.Parse(tbTamanhoBebida.Text);
            bebida.Valor = decimal.Parse(tbValorBebida.Text);

            Validacao validacao;
            if (BebidaSelecionada == null)
            {
                validacao = Program.Gerenciador.CadastraBebida(bebida);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarBebida(bebida);
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
                MessageBox.Show("Bebida salva com sucesso");
            }

            this.Close();
        }

        private void ManterBebida_Shown(object sender, EventArgs e)
        {
            if (BebidaSelecionada != null)
            {
                this.tbIdBebida.Text = BebidaSelecionada.Id.ToString();
                this.tbNomeBebida.Text = BebidaSelecionada.Nome;
                this.tbTamanhoBebida.Text = BebidaSelecionada.Tamanho.ToString();
                this.tbValorBebida.Text = BebidaSelecionada.Valor.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
