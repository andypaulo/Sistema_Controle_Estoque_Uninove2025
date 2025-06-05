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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AccessibleName = "dataGridViewProdutos";
            dataGridViewProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(29, 132);
            dataGridViewProdutos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.Size = new Size(1141, 526);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(29, 78);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(255, 78);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(189, 27);
            txtDescricao.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(465, 77);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(114, 27);
            txtPreco.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(596, 78);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(114, 27);
            txtQuantidade.TabIndex = 6;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(255, 51);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(465, 51);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 8;
            lblPreco.Text = "Preço";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(596, 55);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(87, 20);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtId
            // 
            txtId.Location = new Point(689, 48);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 27);
            txtId.TabIndex = 12;
            txtId.Visible = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(725, 78);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(138, 28);
            cmbCategoria.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(725, 51);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categorias";
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Location = new Point(977, 77);
            btnNovoProduto.Margin = new Padding(3, 4, 3, 4);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(101, 31);
            btnNovoProduto.TabIndex = 15;
            btnNovoProduto.Text = "Criar novo Produto";
            btnNovoProduto.UseVisualStyleBackColor = true;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(1084, 78);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(86, 31);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.Location = new Point(885, 77);
            btnNovaCategoria.Margin = new Padding(3, 4, 3, 4);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(86, 31);
            btnNovaCategoria.TabIndex = 17;
            btnNovaCategoria.Text = "Categoria";
            btnNovaCategoria.UseVisualStyleBackColor = true;
            btnNovaCategoria.Click += btnNovaCategoria_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 9);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 18;
            label2.Text = "Controle de Estoque";
            label2.Click += label2_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 692);
            Controls.Add(label2);
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
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form2";
            Text = "Gerenciamento de Estoque";
            TransparencyKey = Color.Black;
            Load += Form2_Load;
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
        private Label label2;
    }
}