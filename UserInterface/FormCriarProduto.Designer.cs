namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{
    partial class FormCriarProduto
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
            label1 = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            txtId = new TextBox();
            btnNovo = new Button();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "Criar Novo Produto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(20, 68);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 26;
            lblCategoria.Text = "Categorias";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(20, 95);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 28);
            cmbCategoria.TabIndex = 25;
            // 
            // txtId
            // 
            txtId.Location = new Point(173, 21);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 27);
            txtId.TabIndex = 24;
            txtId.Visible = false;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(806, 497);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(86, 31);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(245, 194);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(165, 20);
            lblQuantidade.TabIndex = 22;
            lblQuantidade.Text = "Quantidade no estoque";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(245, 281);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(77, 20);
            lblPreco.TabIndex = 21;
            lblPreco.Text = "Preço (R$)";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(245, 112);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 20;
            lblDescricao.Text = "Descrição";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(245, 221);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(310, 27);
            txtQuantidade.TabIndex = 19;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(245, 305);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(142, 27);
            txtPreco.TabIndex = 18;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(245, 139);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(487, 27);
            txtDescricao.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(245, 61);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(487, 27);
            txtNome.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 34);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 15;
            label2.Text = "Nome do Produto";
            // 
            // btnLimpar
            // 
            btnLimpar.AccessibleName = "btnLimpar";
            btnLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpar.Location = new Point(700, 497);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 31);
            btnLimpar.TabIndex = 27;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // FormCriarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLimpar);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(txtId);
            Controls.Add(btnNovo);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(lblDescricao);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCriarProduto";
            Text = "Criar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private TextBox txtId;
        private Button btnNovo;
        private Label lblQuantidade;
        private Label lblPreco;
        private Label lblDescricao;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Label label2;
        private Button btnLimpar;
    }
}