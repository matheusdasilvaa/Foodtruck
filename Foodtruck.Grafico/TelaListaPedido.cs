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
        
        public TelaListaPedido()
        {
            InitializeComponent();
            CarregarPedidos();
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

        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Pedido> pedidos = Program.Gerenciador.TodosOsPedidos();
            //List<Cliente> clientes = Program.Gerenciador.TodosOsClientes();
            dgPedidos.DataSource = pedidos;
            //dgPedidos.DataSource = clientes;
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

        private void btRemover_Click(object sender, EventArgs e)
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
}
}
