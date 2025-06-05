using Oracle.ManagedDataAccess.Client;
using Sistema_de_Estoque_de_Produtos___UNINOVE.Models;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{

    public partial class FormEditarProduto : Form
    {
        private int idProduto;
        public FormEditarProduto(int id)
        {
            InitializeComponent();
            idProduto = id;
            CarregarCategorias();
            CarregarDadosProduto();
            ConfigurarEventos();
        }
        private void ConfigurarEventos()
        {
            btnSalvar.Click -= btnSalvar_Click;
            btnSalvar.Click += btnSalvar_Click;
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
        private void CarregarDadosProduto()
        {
            Produto produto = ProdutoDAO.BuscarPorId(idProduto);

            if (produto != null)
            {
                txtNome.Text = produto.Nome;
                txtDescricao.Text = produto.Descricao;
                txtPreco.Text = produto.Preco.ToString("F2");
                txtQuantidade.Text = produto.QuantidadeEstoque.ToString();
                cmbCategoria.SelectedValue = produto.IdCategoria;
                txtId.Text = produto.IdProduto.ToString();

            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
                this.Close();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto
                {
                    IdProduto = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                    Nome = txtNome.Text.Trim(),
                    Descricao = txtDescricao.Text.Trim(),
                    Preco = decimal.Parse(txtPreco.Text),
                    QuantidadeEstoque = int.Parse(txtQuantidade.Text),
                    IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
                };

                ProdutoDAO.AtualizarProduto(produto);

                MessageBox.Show("Produto atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void FormEditarProduto_Load(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
