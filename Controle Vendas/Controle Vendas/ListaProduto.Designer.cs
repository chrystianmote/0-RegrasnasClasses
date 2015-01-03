namespace Controle_Vendas
{
    partial class ListaProduto
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
            this.dgvListarProd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precocusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precovenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarProd
            // 
            this.dgvListarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Precocusto,
            this.Precovenda,
            this.Estoque});
            this.dgvListarProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarProd.Location = new System.Drawing.Point(0, 0);
            this.dgvListarProd.Name = "dgvListarProd";
            this.dgvListarProd.Size = new System.Drawing.Size(544, 254);
            this.dgvListarProd.TabIndex = 0;
            this.dgvListarProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarProd_CellContentClick);
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
            // Precocusto
            // 
            this.Precocusto.HeaderText = "Preço Custo";
            this.Precocusto.Name = "Precocusto";
            // 
            // Precovenda
            // 
            this.Precovenda.HeaderText = "Preço Venda";
            this.Precovenda.Name = "Precovenda";
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            // 
            // ListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 254);
            this.Controls.Add(this.dgvListarProd);
            this.Name = "ListaProduto";
            this.Text = "ListaProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precocusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precovenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
    }
}