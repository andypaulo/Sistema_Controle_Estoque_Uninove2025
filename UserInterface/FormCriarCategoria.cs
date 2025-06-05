using Oracle.ManagedDataAccess.Client;
using Sistema_de_Estoque_de_Produtos___UNINOVE.Models;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Sistema_de_Estoque_de_Produtos___UNINOVE.DAL;

namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{
    public partial class FormCriarCategoria : Form
    {
        public FormCriarCategoria()
        {
            InitializeComponent();
        }

        private string modo = "inserir";
        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categoria
                {
                    IdCategoria = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                    Nome = txtCategoria.Text.Trim(),
                    Descricao = txtDesc.Text.Trim(),
                };

                if (modo == "inserir")
                {
                    CategoriaDAO.InserirCategoria(categoria);
                    MessageBox.Show("Categoria cadastrada com sucesso!");
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

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
