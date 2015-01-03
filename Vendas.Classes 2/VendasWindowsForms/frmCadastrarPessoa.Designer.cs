namespace VendasWindowsForms
{
    partial class frmCadastrarPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lklNovoCodigo = new System.Windows.Forms.LinkLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbSex2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // lklNovoCodigo
            // 
            this.lklNovoCodigo.AutoSize = true;
            this.lklNovoCodigo.Location = new System.Drawing.Point(87, 9);
            this.lklNovoCodigo.Name = "lklNovoCodigo";
            this.lklNovoCodigo.Size = new System.Drawing.Size(44, 13);
            this.lklNovoCodigo.TabIndex = 0;
            this.lklNovoCodigo.TabStop = true;
            this.lklNovoCodigo.Text = "[NOVO]";
            this.lklNovoCodigo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklNovoCodigo_LinkClicked);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(146, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(149, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(12, 62);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 4;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(15, 78);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(119, 20);
            this.txtDataNasc.TabIndex = 3;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(146, 62);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(149, 78);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(86, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(238, 62);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo:";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(241, 78);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 5;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(322, 125);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbSex2
            // 
            this.rbSex2.AutoSize = true;
            this.rbSex2.Location = new System.Drawing.Point(312, 78);
            this.rbSex2.Name = "rbSex2";
            this.rbSex2.Size = new System.Drawing.Size(67, 17);
            this.rbSex2.TabIndex = 6;
            this.rbSex2.TabStop = true;
            this.rbSex2.Text = "Feminino";
            this.rbSex2.UseVisualStyleBackColor = true;
            // 
            // frmCadastrarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 161);
            this.Controls.Add(this.rbSex2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lklNovoCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCadastrarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklNovoCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rbSex2;
    }
}