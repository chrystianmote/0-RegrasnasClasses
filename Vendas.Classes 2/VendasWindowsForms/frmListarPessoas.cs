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
    public partial class frmListarPessoas : Form
    {
        public frmListarPessoas()
        {
            InitializeComponent();
            PreencheDGV();
        }

        private void PreencheDGV()
        {
            foreach (Pessoa c in CadastroListagem.ListarCliente())
            {
                string[] dados = new string[2];
                dados[0] = c.Codigo.ToString();
                dados[1] = c.Nome;
                dgvListagem.Rows.Add(dados);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarPessoa CadastroPessoa = new frmCadastrarPessoa();
            CadastroPessoa.ShowDialog();
            dgvListagem.AutoGenerateColumns = false;
            dgvListagem.DataSource = new BindingSource(CadastroListagem.pessoas, null);
        }
    }
}
