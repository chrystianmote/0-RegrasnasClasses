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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            prod.Codigo = Convert.ToInt32(txtCodigo.Text);
            prod.Nome = txtNomeProduto.Text;
            prod.Precocusto = Convert.ToDecimal(txtPrecoCusto.Text);
            prod.Precovenda = Convert.ToDecimal(txtPrecoVenda.Text);
            prod.Estoque = Convert.ToInt32(txtEstoque.Text);
            prod.Itens = new List<ItemVenda>();
            if (prod.Precocusto > prod.Precovenda)
            {
                MessageBox.Show("Erro ao cadastrar o Produto. Preço de venda menor que preço do custo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            else
            {
                if (Produto.CadastrarProduto(prod))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o Produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

    }
}
