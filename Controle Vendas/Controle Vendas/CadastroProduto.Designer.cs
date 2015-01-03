namespace Controle_Vendas
{
    partial class CadastroProduto
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
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(11, 147);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(62, 20);
            this.txtEstoque.TabIndex = 5;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(8, 131);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 22;
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(171, 88);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(140, 20);
            this.txtPrecoVenda.TabIndex = 4;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(168, 72);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoVenda.TabIndex = 21;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(10, 88);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(140, 20);
            this.txtPrecoCusto.TabIndex = 3;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(7, 72);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(83, 13);
            this.lblPrecoCusto.TabIndex = 20;
            this.lblPrecoCusto.Text = "Preço de Custo:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(89, 32);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(223, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(86, 16);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(93, 13);
            this.lblNomeProduto.TabIndex = 18;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código:";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(111, 131);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(90, 36);
            this.btnCadastrarProduto.TabIndex = 6;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 194);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnCancelar;
    }
}