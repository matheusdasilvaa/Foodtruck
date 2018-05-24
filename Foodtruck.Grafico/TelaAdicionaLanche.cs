﻿using System;
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
    public partial class TelaAdicionaLanche : Form
    {
        public Lanche LancheSelecionado { get; set; }

        public TelaAdicionaLanche ()
        {
            InitializeComponent();
        }
        private void btSalvarLanche_Click(object sender, EventArgs e)
        {
            Lanche lanche = new Lanche();
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

        private void ManterLanches_Shown(object sender, EventArgs e)
        {
            if (LancheSelecionado != null)
            {
                //this.tbIdLanche.Text = LancheSelecionado.Id.ToString();
                this.tbNomeLanche.Text = LancheSelecionado.Nome;
                this.tbValorLanche.Text = LancheSelecionado.Valor.ToString();
            }
        }

        private void tbNomeLanche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
