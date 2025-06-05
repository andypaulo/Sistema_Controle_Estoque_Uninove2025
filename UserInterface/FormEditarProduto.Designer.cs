namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{
    partial class FormEditarProduto
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
            btnLimpar = new Button();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            txtId = new TextBox();
            btnSalvar = new Button();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.AccessibleName = "btnLimpar";
            btnLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpar.Location = new Point(699, 508);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 31);
            btnLimpar.TabIndex = 41;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(14, 87);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 40;
            lblCategoria.Text = "Categorias";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(14, 120);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(138, 28);
            cmbCategoria.TabIndex = 39;
            // 
            // txtId
            // 
            txtId.Location = new Point(135, 29);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 27);
            txtId.TabIndex = 38;
            txtId.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(798, 508);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 31);
            btnSalvar.TabIndex = 37;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(220, 220);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(165, 20);
            lblQuantidade.TabIndex = 36;
            lblQuantidade.Text = "Quantidade no Estoque";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(220, 309);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(77, 20);
            lblPreco.TabIndex = 35;
            lblPreco.Text = "Preço (R$)";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(220, 128);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 34;
            lblDescricao.Text = "Descrição";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(220, 244);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(214, 27);
            txtQuantidade.TabIndex = 33;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(220, 333);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(114, 27);
            txtPreco.TabIndex = 32;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(220, 152);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(565, 27);
            txtDescricao.TabIndex = 31;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 70);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(540, 27);
            txtNome.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 46);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 29;
            label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 28;
            label1.Text = "Editar Produto";
            // 
            // FormEditarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLimpar);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(txtId);
            Controls.Add(btnSalvar);
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
            Name = "FormEditarProduto";
            Text = "Form1";
            Load += FormEditarProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private TextBox txtId;
        private Button btnSalvar;
        private Label lblQuantidade;
        private Label lblPreco;
        private Label lblDescricao;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
    }
}