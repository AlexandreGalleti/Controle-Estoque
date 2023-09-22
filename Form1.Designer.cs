namespace controle_estoque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListBox EstoqueListBox1;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NomeProdutoLabel = new Label();
            QuantidadeLabel = new Label();
            NomeProdutoTextBox = new TextBox();
            QuantidadeTextBox = new TextBox();
            EstoqueListBox1 = new ListBox();
            AdicionarProdutoButton = new Button();
            AtualizarQuantidadeButton = new Button();
            VerificarEstoqueButton = new Button();
            SuspendLayout();
            // 
            // NomeProdutoLabel
            // 
            NomeProdutoLabel.AutoSize = true;
            NomeProdutoLabel.ForeColor = SystemColors.ControlLightLight;
            NomeProdutoLabel.Location = new Point(61, 41);
            NomeProdutoLabel.Name = "NomeProdutoLabel";
            NomeProdutoLabel.Size = new Size(103, 15);
            NomeProdutoLabel.TabIndex = 0;
            NomeProdutoLabel.Text = "Nome do produto";
            NomeProdutoLabel.Click += NomeProdutoLabel_Click;
            // 
            // QuantidadeLabel
            // 
            QuantidadeLabel.AutoSize = true;
            QuantidadeLabel.ForeColor = SystemColors.ControlLightLight;
            QuantidadeLabel.Location = new Point(299, 41);
            QuantidadeLabel.Name = "QuantidadeLabel";
            QuantidadeLabel.Size = new Size(69, 15);
            QuantidadeLabel.TabIndex = 1;
            QuantidadeLabel.Text = "Quantidade";
            QuantidadeLabel.Click += QuantidadeLabel_Click;
            // 
            // NomeProdutoTextBox
            // 
            NomeProdutoTextBox.Location = new Point(61, 59);
            NomeProdutoTextBox.Name = "NomeProdutoTextBox";
            NomeProdutoTextBox.Size = new Size(100, 23);
            NomeProdutoTextBox.TabIndex = 2;
            NomeProdutoTextBox.TextChanged += NomeProdutoTextBox_TextChanged;
            // 
            // QuantidadeTextBox
            // 
            QuantidadeTextBox.Location = new Point(300, 59);
            QuantidadeTextBox.Name = "QuantidadeTextBox";
            QuantidadeTextBox.Size = new Size(100, 23);
            QuantidadeTextBox.TabIndex = 3;
            QuantidadeTextBox.TextChanged += QuantidadeTextBox_TextChanged;
            // 
            // EstoqueListBox1
            // 
            EstoqueListBox1.FormattingEnabled = true;
            EstoqueListBox1.ItemHeight = 15;
            EstoqueListBox1.Location = new Point(61, 88);
            EstoqueListBox1.Name = "EstoqueListBox1";
            EstoqueListBox1.Size = new Size(339, 109);
            EstoqueListBox1.TabIndex = 8;
            EstoqueListBox1.SelectedIndexChanged += EstoqueListBox_SelectedIndexChanged;
            // 
            // AdicionarProdutoButton
            // 
            AdicionarProdutoButton.Location = new Point(61, 203);
            AdicionarProdutoButton.Name = "AdicionarProdutoButton";
            AdicionarProdutoButton.Size = new Size(100, 23);
            AdicionarProdutoButton.TabIndex = 5;
            AdicionarProdutoButton.Text = "Adicionar Prod";
            AdicionarProdutoButton.UseVisualStyleBackColor = true;
            AdicionarProdutoButton.Click += AdicionarProdutoButton_Click;
            // 
            // AtualizarQuantidadeButton
            // 
            AtualizarQuantidadeButton.Location = new Point(310, 203);
            AtualizarQuantidadeButton.Name = "AtualizarQuantidadeButton";
            AtualizarQuantidadeButton.Size = new Size(90, 23);
            AtualizarQuantidadeButton.TabIndex = 6;
            AtualizarQuantidadeButton.Text = "Atuializar QTD";
            AtualizarQuantidadeButton.UseVisualStyleBackColor = true;
            AtualizarQuantidadeButton.Click += AtualizarQuantidadeButton_Click;
            // 
            // VerificarEstoqueButton
            // 
            VerificarEstoqueButton.Location = new Point(186, 203);
            VerificarEstoqueButton.Name = "VerificarEstoqueButton";
            VerificarEstoqueButton.Size = new Size(100, 23);
            VerificarEstoqueButton.TabIndex = 7;
            VerificarEstoqueButton.Text = "Verificar ";
            VerificarEstoqueButton.UseVisualStyleBackColor = true;
            VerificarEstoqueButton.Click += VerificarEstoqueButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(477, 292);
            Controls.Add(VerificarEstoqueButton);
            Controls.Add(AtualizarQuantidadeButton);
            Controls.Add(AdicionarProdutoButton);
            Controls.Add(EstoqueListBox1);
            Controls.Add(QuantidadeTextBox);
            Controls.Add(NomeProdutoTextBox);
            Controls.Add(QuantidadeLabel);
            Controls.Add(NomeProdutoLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Controle de Estoque";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeProdutoLabel;
        private Label QuantidadeLabel;
        private TextBox NomeProdutoTextBox;
        private TextBox QuantidadeTextBox;
        private ListBox EstoqueListBox;
        private Button AdicionarProdutoButton;
        private Button AtualizarQuantidadeButton;
        private Button VerificarEstoqueButton;
    }
}