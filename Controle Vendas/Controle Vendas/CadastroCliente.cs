using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_Vendas
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Compras = new List<Venda>();
            if (Cliente.CadastrarCliente(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
