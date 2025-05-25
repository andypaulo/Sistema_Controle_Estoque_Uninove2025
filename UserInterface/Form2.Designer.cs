namespace Sistema_de_Estoque_de_Produtos___UNINOVE
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProdutos = new DataGridView();
            label1 = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            lblDescricao = new Label();
            lblPreco = new Label();
            lblQuantidade = new Label();
            txtId = new TextBox();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            btnNovoProduto = new Button();
            btnPesquisar = new Button();
            btnNovaCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AccessibleName = "dataGridViewProdutos";
            dataGridViewProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(12, 74);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(909, 433);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(118, 35);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(224, 35);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(330, 35);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 6;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(118, 15);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(224, 15);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 8;
            lblPreco.Text = "Preço";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(330, 15);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtId
            // 
            txtId.Location = new Point(405, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(26, 23);
            txtId.TabIndex = 12;
            txtId.Visible = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(436, 35);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(436, 15);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(63, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categorias";
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Location = new Point(846, 35);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(75, 23);
            btnNovoProduto.TabIndex = 15;
            btnNovoProduto.Text = "Criar novo Produto";
            btnNovoProduto.UseVisualStyleBackColor = true;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(765, 35);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.Location = new Point(846, 11);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(75, 23);
            btnNovaCategoria.TabIndex = 17;
            btnNovaCategoria.Text = "Categoria";
            btnNovaCategoria.UseVisualStyleBackColor = true;
            btnNovaCategoria.Click += btnNovaCategoria_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnNovaCategoria);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovoProduto);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(txtId);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(lblDescricao);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(dataGridViewProdutos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Gerenciamento de Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Label lblDescricao;
        private Label lblPreco;
        private Label lblQuantidade;
        private TextBox txtId;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Button btnNovoProduto;
        private Button btnPesquisar;
        private Button btnNovaCategoria;
    }
}