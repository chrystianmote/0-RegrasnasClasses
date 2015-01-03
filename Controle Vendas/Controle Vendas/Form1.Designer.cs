namespace Controle_Vendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(36, 38);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(202, 46);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(36, 90);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(202, 46);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Location = new System.Drawing.Point(36, 142);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(202, 46);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 264);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnCliente);
            this.Name = "Form1";
            this.Text = "Controle de Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnVenda;
    }
}

