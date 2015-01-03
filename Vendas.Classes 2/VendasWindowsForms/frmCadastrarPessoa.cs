using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vendas.Classes;

namespace VendasWindowsForms
{
    public partial class frmCadastrarPessoa : Form
    {
        public frmCadastrarPessoa()
        {
            InitializeComponent();
            Random rnd = new Random();
            txtCodigo.Text = rnd.Next(99, 9999).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nome = txtNome.Text;
            obj.Datanasc = Convert.ToDateTime(txtDataNasc.Text);
            obj.Peso = Convert.ToDouble(txtPeso.Text);
            if (rbMasc.Checked == true)
                obj.Sexo = 'M';
            if (rbSex2.Checked == true)
                obj.Sexo = 'F';
            if (CadastroListagem.Cadastrar(obj) == true)
                MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);
            this.Close();
        }

        private void lklNovoCodigo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rnd = new Random();
            txtCodigo.Text = rnd.Next(99, 9999).ToString();
        }
    }
}
