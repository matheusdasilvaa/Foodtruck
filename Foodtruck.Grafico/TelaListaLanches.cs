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
    public partial class TelaListaLanches : Form

        {
        public Lanche LancheSelecionado { get; set; }

        public TelaListaLanches()
        {
            InitializeComponent();
            CarregarLanches();
        }

        private void AbreTelaInclusaoAlteracao(Lanche LancheaSelecionado)
        {
            TelaAdicionaLanche telaLanche = new TelaAdicionaLanche();
            telaLanche.MdiParent = this.MdiParent;
            telaLanche.LancheSelecionado = LancheSelecionado;
            telaLanche.FormClosed += Tela_FormClosed;
            telaLanche.Show();
        }

        
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarLanches();
        }

        private void CarregarLanches()
        {
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.MultiSelect = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.AutoGenerateColumns = false;
            List<Lanche> lanches = Program.Gerenciador.TodosOsLanches();
            dgLanches.DataSource = lanches;
        }

        private bool VerificarSelecao()
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void TelaListaLanches_Load(object sender, EventArgs e)
        {
            CarregarLanches();
        }

        private void btAdicionarLanche_Click_1(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void btRemoverLanche_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverLanche(lancheSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Lanche removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o Lanche");
                    }
                    CarregarLanches();
                }
            }
        }
    }
}
