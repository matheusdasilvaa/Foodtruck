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

        private void AbreTelaInclusaoAlteracao(Bebida BebidaSelecionada)
        {
            ManterBebida tela = new ManterBebida();
            tela.MdiParent = this.MdiParent;
            tela.BebidaSelecionada = BebidaSelecionada;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarBebidas();
        }

        private void CarregarBebidas()
        {
            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBebidas.MultiSelect = false;
            dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBebidas.AutoGenerateColumns = false;
            List<Bebida> bebidas = Program.Gerenciador.TodasAsBebidas();
            dgBebidas.DataSource = bebidas;
        }

        private void TelaListaBebidas_Load(object sender, EventArgs e)
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
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
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

        private void btAlterarBebida_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Bebida BebidaSelecionada = (Bebida)dgBebidas.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(BebidaSelecionada);
            }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
