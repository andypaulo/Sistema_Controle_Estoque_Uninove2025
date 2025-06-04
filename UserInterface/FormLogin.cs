// FormLogin.cs
using System;
using System.Windows.Forms;

namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            // Validação básica de campos vazios
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, informe o nome de usuário.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, informe a senha.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            // Lógica de autenticação (exemplo simples com credenciais fixas)
            // Em um cenário real, isso seria validado contra um banco de dados ou serviço de autenticação.
            if (usuario.Equals("admin", StringComparison.OrdinalIgnoreCase) && senha.Equals("admin"))
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Esconde o formulário de login
                this.Hide(); 

                // Cria e exibe o formulário principal (Form2)
                Form2 formPrincipal = new Form2();
                formPrincipal.FormClosed += (s, args) => this.Close(); // Fecha a aplicação quando o form principal for fechado
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpa o campo de senha e foca nele
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}

