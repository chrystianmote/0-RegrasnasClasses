namespace Controle_Vendas
{
    partial class ListaCliente
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
            this.dgvListaCli = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCli
            // 
            this.dgvListaCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Telefone,
            this.Datanasc,
            this.Email});
            this.dgvListaCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaCli.Location = new System.Drawing.Point(0, 0);
            this.dgvListaCli.Name = "dgvListaCli";
            this.dgvListaCli.Size = new System.Drawing.Size(692, 266);
            this.dgvListaCli.TabIndex = 0;
            this.dgvListaCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Datanasc
            // 
            this.Datanasc.HeaderText = "Data de Nascimento";
            this.Datanasc.Name = "Datanasc";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 266);
            this.Controls.Add(this.dgvListaCli);
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}