namespace Controle_Vendas
{
    partial class CadastrarItens
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvListarItens = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarItens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(12, 32);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(81, 20);
            this.txtItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Produto";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(218, 26);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(103, 31);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Adicionar Produto";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvListarItens
            // 
            this.dgvListarItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Preco,
            this.Quant});
            this.dgvListarItens.Location = new System.Drawing.Point(12, 83);
            this.dgvListarItens.Name = "dgvListarItens";
            this.dgvListarItens.Size = new System.Drawing.Size(444, 226);
            this.dgvListarItens.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quantidade";
            this.Quant.Name = "Quant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(103, 32);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(59, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // CadastrarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dgvListarItens);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItem);
            this.Name = "CadastrarItens";
            this.Text = "Adicionar Itens";
            this.Load += new System.EventHandler(this.CadastrarItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvListarItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}