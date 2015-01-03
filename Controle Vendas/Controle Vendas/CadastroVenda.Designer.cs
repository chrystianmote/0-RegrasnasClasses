namespace Controle_Vendas
{
    partial class CadastroVenda
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
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.lblICMS = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvInsirirItens = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarVenda = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItensVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsirirItens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtICMS
            // 
            this.txtICMS.Location = new System.Drawing.Point(106, 34);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(79, 20);
            this.txtICMS.TabIndex = 9;
            this.txtICMS.Text = " ";
            // 
            // lblICMS
            // 
            this.lblICMS.AutoSize = true;
            this.lblICMS.Location = new System.Drawing.Point(103, 18);
            this.lblICMS.Name = "lblICMS";
            this.lblICMS.Size = new System.Drawing.Size(36, 13);
            this.lblICMS.TabIndex = 8;
            this.lblICMS.Text = "ICMS:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(12, 18);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(77, 13);
            this.lblCodigoVenda.TabIndex = 5;
            this.lblCodigoVenda.Text = "Código Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código Cliente";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(238, 34);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(72, 20);
            this.txtCodCli.TabIndex = 11;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(15, 94);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(409, 20);
            this.txtNomeCliente.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(336, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 22);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvInsirirItens
            // 
            this.dgvInsirirItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsirirItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItensVenda,
            this.Quantidade,
            this.preco});
            this.dgvInsirirItens.Location = new System.Drawing.Point(12, 197);
            this.dgvInsirirItens.Name = "dgvInsirirItens";
            this.dgvInsirirItens.Size = new System.Drawing.Size(412, 204);
            this.dgvInsirirItens.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 31);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarVenda
            // 
            this.btnCadastrarVenda.Location = new System.Drawing.Point(304, 422);
            this.btnCadastrarVenda.Name = "btnCadastrarVenda";
            this.btnCadastrarVenda.Size = new System.Drawing.Size(120, 31);
            this.btnCadastrarVenda.TabIndex = 19;
            this.btnCadastrarVenda.Text = "Fechar Venda";
            this.btnCadastrarVenda.UseVisualStyleBackColor = true;
            this.btnCadastrarVenda.Click += new System.EventHandler(this.btnCadastrarVenda_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(12, 422);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(95, 31);
            this.btnAddProduto.TabIndex = 21;
            this.btnAddProduto.Text = "Add Produto ...";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Location = new System.Drawing.Point(15, 154);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.ReadOnly = true;
            this.txtDataVenda.Size = new System.Drawing.Size(79, 20);
            this.txtDataVenda.TabIndex = 23;
            this.txtDataVenda.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data da Venda:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(345, 154);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(79, 20);
            this.txtValorTotal.TabIndex = 25;
            this.txtValorTotal.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Valor Total";
            // 
            // ItensVenda
            // 
            this.ItensVenda.HeaderText = "Itens Venda";
            this.ItensVenda.Name = "ItensVenda";
            this.ItensVenda.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 70;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.Width = 99;
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 473);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.btnCadastrarVenda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvInsirirItens);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtICMS);
            this.Controls.Add(this.lblICMS);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoVenda);
            this.Name = "CadastroVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.CadastroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsirirItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.Label lblICMS;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvInsirirItens;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarVenda;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}