using Oracle.ManagedDataAccess.Client;
using Sistema_de_Estoque_de_Produtos___UNINOVE.Models;
using Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Estoque_de_Produtos___UNINOVE
{
    public partial class Form2 : Form
    {
        private string modo = "inserir";
        public Form2()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarregarProdutos();
            CarregarCategorias();
            ConfigurarEventos();
            TestarConexao();

        }

        private void TestarConexao()
        {
            string connStr = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;
            using (var conn = new OracleConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conexão bem-sucedida!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão: " + ex.Message);
                }
            }
        }
        private void ConfigurarGrid()
        {
            dataGridViewProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutos.MultiSelect = false;
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarEventos()
        {
            dataGridViewProdutos.CellClick += DataGridViewProdutos_CellClick;
        }

        private void RemoverColunasAcoes()
        {
            if (dataGridViewProdutos.Columns["Editar"] != null)
                dataGridViewProdutos.Columns.Remove("Editar");

            if (dataGridViewProdutos.Columns["Excluir"] != null)
                dataGridViewProdutos.Columns.Remove("Excluir");
        }

        private void CarregarProdutos()
        {
            try
            {
                string nome = txtNome.Text.Trim();
                string desc = txtDescricao.Text.Trim();
                string preco = txtPreco.Text.Trim();
                string quantidade = txtQuantidade.Text.Trim();
                int? idCategoria = cmbCategoria.SelectedIndex >= 0 ? (int?)Convert.ToInt32(cmbCategoria.SelectedValue) : null;

                DataTable dt = ProdutoDAO.ListarProdutos(nome, desc, preco, quantidade, idCategoria);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridViewProdutos.DataSource = dt;
                    dataGridViewProdutos.Columns["id_categoria"].Visible = false;
                    RemoverColunasAcoes();
                    AdicionarColunaAcoes();
                    dataGridViewProdutos.Refresh();
                }
                else
                {
                    dataGridViewProdutos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }
        private void AdicionarColunaAcoes()
        {
            if (dataGridViewProdutos.Columns["Editar"] == null)
            {
                DataGridViewButtonColumn editarButton = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Ações",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewProdutos.Columns.Add(editarButton);
            }

            if (dataGridViewProdutos.Columns["Excluir"] == null)
            {
                DataGridViewButtonColumn excluirButton = new DataGridViewButtonColumn
                {
                    Name = "Excluir",
                    HeaderText = "",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewProdutos.Columns.Add(excluirButton);
            }
        }
        private void DataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string coluna = dataGridViewProdutos.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dataGridViewProdutos.Rows[e.RowIndex].Cells["id_produto"].Value);

                if (coluna == "Editar")
                {
                    FormEditarProduto editarForm = new FormEditarProduto(id);
                    CarregarProdutos();
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        CarregarProdutos();
                    }
                }
                else if (coluna == "Excluir")
                {
                    var resultado = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        ProdutoDAO.ExcluirProduto(id);
                        CarregarProdutos();
                    }
                }
            }
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um produto para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    ProdutoDAO.ExcluirProduto(id);
                    CarregarProdutos();
                    LimparCampos();
                    MessageBox.Show("Produto excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            cmbCategoria.SelectedIndex = -1;
            modo = "inserir";
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
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            FormCriarProduto novoForm = new FormCriarProduto();
            if (novoForm.ShowDialog() == DialogResult.OK)
            {
                CarregarProdutos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            FormCriarCategoria novoForm = new FormCriarCategoria();
            if (novoForm.ShowDialog() == DialogResult.OK)
            {
                CarregarCategorias();
            }
        }
    }
}