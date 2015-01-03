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
    public partial class CadastrarItens : Form
    {
        public CadastrarItens()
        {
            InitializeComponent();
            foreach (Produto p in Produto.Produtos)
            {
                string[] Dados = new string[4];
                Dados[0] = p.Codigo.ToString();
                Dados[1] = p.Nome;
                Dados[2] = "R$ " + p.Precovenda.ToString();
                Dados[3] = p.Estoque.ToString();
                dgvListarItens.Rows.Add(Dados);
            }
        }

        private void CadastrarItens_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemVenda iv = new ItemVenda();
            iv.Produto = Produto.Pesquisar(txtItem.Text);
            int estoque = 0;
            if (iv.Produto != null)
            {
                iv.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                if (iv.Quantidade > iv.Produto.Estoque)
                {
                    MessageBox.Show("Quantidade maior que Estoque! Venda Cancelada.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    estoque = iv.Produto.Estoque - iv.Quantidade;
                    iv.Produto.Estoque = estoque;
                    iv.Venda = Venda.Vendas[Venda.Vendas.Count - 1];
                    iv.Venda.ValorTotal = iv.Quantidade * iv.Produto.Precovenda;
                    Venda.Vendas[Venda.Vendas.Count - 1].Itens.Add(iv);
                    Venda.Vendas.RemoveAt(Venda.Vendas.Count - 1);
                    Venda.Vendas.Add(iv.Venda);
                    this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Cliente Não encontrado! Venda Cancelada.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Venda.Vendas.RemoveAt(Venda.Vendas.Count - 1);
                this.Close();
            }
        }
    }
}
