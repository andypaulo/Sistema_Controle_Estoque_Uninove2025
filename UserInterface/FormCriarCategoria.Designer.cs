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
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(110, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome da Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(27, 48);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(110, 23);
            txtCategoria.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(26, 87);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(27, 105);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(100, 23);
            txtDesc.TabIndex = 3;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(26, 149);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 4;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(167, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(26, 23);
            txtId.TabIndex = 25;
            txtId.Visible = false;
            // 
            // FormCriarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(btnCriar);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Controls.Add(txtCategoria);
            Controls.Add(lblNome);
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
    }
}