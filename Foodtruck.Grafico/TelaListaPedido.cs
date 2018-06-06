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
    public partial class TelaListaPedido : Form
    {
        Pedido pedido = new Pedido();

        public TelaListaPedido()
        {
            InitializeComponent();
            CarregarPedidos();
        }

        private void AbreTelaInclusaoAlteracao(Pedido pedidoSelecionado)
        {
            AdicionaPedido tela = new AdicionaPedido();
            tela.MdiParent = this.MdiParent;
            tela.PedidoSelecionado = pedidoSelecionado;
            //tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            dgPedidos.DataSource = Program.Gerenciador.TodosOsPedidos();
        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            //CarregarPedidos();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            
            CarregarPedidos();
        }

        private bool VerificarSelecao()
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemover_Click_1(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPedido(pedidoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Pedido removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o cliente");
                    }
                    CarregarPedidos();
                }
            }
        
    }



        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;

                if (pedidoSelecionado.Encerrado.Equals(true))
                {
                    MessageBox.Show("Você não pode alterar um pedido finalizado");
                    return;
                }

                AbreTelaInclusaoAlteracao(pedidoSelecionado);
            }
        }

        private void TelaListaPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;

                if (pedidoSelecionado.Encerrado.Equals(true))
                {
                    MessageBox.Show("Esse pedido já foi finalizado");
                    return;
                }

                pedidoSelecionado.Encerrado = true;

                Validacao validacao = Program.Gerenciador.AlterarPedido(pedidoSelecionado, false);

                if (!validacao.Valido)
                {
                    String mensagemValidacao = "";
                    foreach (var msg in validacao.Mensagens)
                    {
                        mensagemValidacao += msg + Environment.NewLine;
                    }
                    MessageBox.Show(mensagemValidacao, "Erro");
                }
                else
                {
                    MessageBox.Show("Pedido finalizado com sucesso");
                }
            }
            CarregarPedidos();
        }

        
    }
}
