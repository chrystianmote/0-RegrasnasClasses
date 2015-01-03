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
    public partial class CadastroVenda : Form
    {
        
        public CadastroVenda()
        {
            InitializeComponent();
            
        }

        private void CadastroVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.Codigo = Convert.ToInt32(txtCodigo.Text);
            v.ICMS = Convert.ToDouble(txtICMS.Text);
            v.Data = DateTime.Now;
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
            v.Comprador = Cliente.Pesquisar(txtCodCli.Text);
            v.Itens = new List<ItemVenda>();
            Venda.CadastrarVenda(v);
            if (v.Comprador != null)
                txtNomeCliente.Text = v.Comprador.Nome;
            else
            {
                MessageBox.Show("Cliente Não encontrado! Venda Cancelada.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            CadastrarItens formCadastrarItens = new CadastrarItens();
            formCadastrarItens.ShowDialog();
            string[] dados = new string[3];
            dados[0] = Venda.Vendas[Venda.Vendas.Count - 1].Itens[Venda.Vendas[Venda.Vendas.Count - 1].Itens.Count - 1].Produto.Nome;
            dados[1] = Venda.Vendas[Venda.Vendas.Count - 1].Itens[Venda.Vendas[Venda.Vendas.Count - 1].Itens.Count - 1].Quantidade.ToString();
            dados[2] = Venda.Vendas[Venda.Vendas.Count - 1].Itens[Venda.Vendas[Venda.Vendas.Count - 1].Itens.Count - 1].Produto.Precovenda.ToString();
            dgvInsirirItens.Rows.Add(dados);
            txtValorTotal.Text = Venda.Vendas[Venda.Vendas.Count - 1].Itens[Venda.Vendas[Venda.Vendas.Count - 1].Itens.Count - 1].Venda.ValorTotal.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Venda.Vendas.RemoveAt(Venda.Vendas.Count - 1);
        }

        private void btnCadastrarVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda cadastrada com sucesso!", "Aviso", MessageBoxButtons.OK);
            this.Close();
        }

    }
}
