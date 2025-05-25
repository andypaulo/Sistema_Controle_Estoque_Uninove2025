using Oracle.ManagedDataAccess.Client;
using Sistema_de_Estoque_de_Produtos___UNINOVE.Models;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{
    public partial class FormCriarProduto: Form
    {
        private string modo = "inserir";
        public FormCriarProduto()
        {
            InitializeComponent();
            CarregarCategorias();
            ConfigurarEventos();
        }
        private void ConfigurarEventos()
        {
            btnNovo.Click += button1_Click;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo = "inserir";
            txtNome.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto");
                return false;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido");
                return false;
            }

            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 0)
            {
                MessageBox.Show("Quantidade inválida");
                return false;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma categoria");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma categoria válida");
                return;
            }

            try
            {
                var produto = new Produto
                {
                    IdProduto = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                    Nome = txtNome.Text.Trim(),
                    Descricao = txtDescricao.Text.Trim(),
                    Preco = decimal.Parse(txtPreco.Text),
                    QuantidadeEstoque = int.Parse(txtQuantidade.Text),
                    IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
                };

                if (modo == "inserir")
                {
                    ProdutoDAO.InserirProduto(produto);
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ProdutoDAO.AtualizarProduto(produto);
                    MessageBox.Show("Produto atualizado com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique os valores informados");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
        private void CarregarCategorias()
        {
            try
            {
                string sql = "SELECT id_categoria, nome FROM categorias ORDER BY nome";
                using (var conn = OracleDbConnection.GetConnection())
                {
                    if (conn == null) return;

                    var da = new OracleDataAdapter(sql, conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    cmbCategoria.DataSource = dt;
                    cmbCategoria.DisplayMember = "nome";
                    cmbCategoria.ValueMember = "id_categoria";
                    cmbCategoria.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}");
            }
        }

    }
}
