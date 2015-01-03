namespace Controle_Vendas
{
    partial class CadastroCliente
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmai = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmai
            // 
            this.lblEmai.AutoSize = true;
            this.lblEmai.Location = new System.Drawing.Point(12, 73);
            this.lblEmai.Name = "lblEmai";
            this.lblEmai.Size = new System.Drawing.Size(38, 13);
            this.lblEmai.TabIndex = 20;
            this.lblEmai.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(333, 32);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(330, 16);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 19;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(332, 89);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(117, 20);
            this.txtDataNasc.TabIndex = 5;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(329, 73);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 17;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(89, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(56, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(205, 155);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(103, 34);
            this.btnCadastrarCliente.TabIndex = 6;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(355, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 209);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmai);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "CadastroCliente";
            this.Text = " Cadastro do Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmai;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}