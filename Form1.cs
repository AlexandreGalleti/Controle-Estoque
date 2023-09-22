using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace controle_estoque
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> estoque = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionarProdutoButton_Click(object sender, EventArgs e)
        {
            string nomeProduto = NomeProdutoTextBox.Text;
            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("Por favor, insira o nome do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantidadeEstoque;
            if (!int.TryParse(QuantidadeTextBox.Text, out quantidadeEstoque) || quantidadeEstoque < 0)
            {
                MessageBox.Show("Quantidade inválida. Insira um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (estoque.ContainsKey(nomeProduto))
            {
                estoque[nomeProduto] += quantidadeEstoque;
            }
            else
            {
                estoque[nomeProduto] = quantidadeEstoque;
            }

            AtualizarListaEstoque();

            LimparCampos();
        }

        private void AtualizarQuantidadeButton_Click(object sender, EventArgs e)
        {
            string nomeProduto = NomeProdutoTextBox.Text;
            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("Por favor, insira o nome do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (estoque.ContainsKey(nomeProduto))
            {
                int novaQuantidade;
                if (!int.TryParse(QuantidadeTextBox.Text, out novaQuantidade) || novaQuantidade < 0)
                {
                    MessageBox.Show("Quantidade inválida. Insira um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                estoque[nomeProduto] = novaQuantidade;
                AtualizarListaEstoque();

                LimparCampos();
            }
            else
            {
                MessageBox.Show($"Produto '{nomeProduto}' não encontrado no estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarEstoqueButton_Click(object sender, EventArgs e)
        {
            if (estoque.Count == 0)
            {
                MessageBox.Show("O estoque está vazio.", "Estoque Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mensagem = "Estoque Atual:\n\n";
                foreach (var item in estoque)
                {
                    mensagem += $"{item.Key}: {item.Value} unidades\n";
                }
                MessageBox.Show(mensagem, "Estoque Atual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NomeProdutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeProdutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuantidadeLabel_Click(object sender, EventArgs e)
        {

        }


        private void QuantidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstoqueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstoqueListBox1.Items.Clear();
            foreach (var item in estoque)
            {
                EstoqueListBox1.Items.Add($"{item.Key}: {item.Value} unidades");

            }

        }
        private void LimparCampos()
        {
            NomeProdutoTextBox.Clear();
            QuantidadeTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AtualizarListaEstoque()
        {

            EstoqueListBox1.Items.Clear();


            foreach (var item in estoque)
            {
                EstoqueListBox1.Items.Add($"{item.Key}: {item.Value} unidades");
            }
        }
    }
}