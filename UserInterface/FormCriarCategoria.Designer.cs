namespace Sistema_de_Estoque_de_Produtos___UNINOVE.UserInterface
{
    partial class FormCriarCategoria
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
            lblNome = new Label();
            txtCategoria = new TextBox();
            lblDesc = new Label();
            txtDesc = new TextBox();
            btnCriar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(31, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(109, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Criar Categoria";
            lblNome.Click += lblNome_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(27, 132);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(172, 27);
            txtCategoria.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(31, 209);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(74, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(31, 233);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(172, 27);
            txtDesc.TabIndex = 3;
            txtDesc.TextChanged += txtDesc_TextChanged;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(703, 519);
            btnCriar.Margin = new Padding(3, 4, 3, 4);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(86, 31);
            btnCriar.TabIndex = 4;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(209, 132);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 27);
            txtId.TabIndex = 25;
            txtId.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 108);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 26;
            label1.Text = "Nome";
            // 
            // FormCriarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnCriar);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Controls.Add(txtCategoria);
            Controls.Add(lblNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCriarCategoria";
            Text = "F";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtCategoria;
        private Label lblDesc;
        private TextBox txtDesc;
        private Button btnCriar;
        private TextBox txtId;
        private Label label1;
    }
}