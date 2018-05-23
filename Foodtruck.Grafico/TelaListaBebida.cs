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
    public partial class TelaListaBebida : Form
    {
        public TelaListaBebida()
        {
            InitializeComponent();
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            ManterBebida cadastraBebida = new ManterBebida();
            //cadastraBebida.MdiParent = this;
            cadastraBebida.Show();
        }

        private void TelaListaBebida_Load(object sender, EventArgs e)
        {
            CarregarBebidas();
        }

        private bool VerificarSelecao()
        {
            if (dgBebidas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemoverBebida_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Você deseja realmente excluir esta bebida?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Bebida bebidaSelecionada = (Bebida)dgBebidas.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverBebida(bebidaSelecionada);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Bebida removida com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover a bebida");
                    }
                    CarregarBebidas();
                }
            }
        }
    }
}
