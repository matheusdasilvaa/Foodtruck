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

        private void TelaListaLanches_Load(object sender, EventArgs e)
        {
            CarregarLanches();
        }

        private void btAdicionarLanche_Click_1(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }
    }
}
