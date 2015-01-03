namespace Controle_Vendas
{
    partial class ListaVenda
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
            this.dgvListaVendas = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVendas
            // 
            this.dgvListaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.cli,
            this.Data,
            this.Column1});
            this.dgvListaVendas.Location = new System.Drawing.Point(0, 0);
            this.dgvListaVendas.Name = "dgvListaVendas";
            this.dgvListaVendas.Size = new System.Drawing.Size(623, 267);
            this.dgvListaVendas.TabIndex = 0;
            // 
            // cod
            // 
            this.cod.HeaderText = "Código";
            this.cod.Name = "cod";
            this.cod.Width = 80;
            // 
            // cli
            // 
            this.cli.HeaderText = "Cliente";
            this.cli.Name = "cli";
            this.cli.Width = 300;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data Venda";
            this.Data.Name = "Data";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Venda";
            this.Column1.Name = "Column1";
            // 
            // ListaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 266);
            this.Controls.Add(this.dgvListaVendas);
            this.Name = "ListaVenda";
            this.Text = "ListaVenda";
            this.Load += new System.EventHandler(this.ListaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}