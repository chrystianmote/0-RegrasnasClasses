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
    public partial class ListaProduto : Form
    {
        public ListaProduto()
        {
            InitializeComponent();
            foreach (Produto p in Produto.Produtos)
            {
                string[] Dados = new string[5];
                Dados[0] = p.Codigo.ToString();
                Dados[1] = p.Nome;
                Dados[2] = "R$ " + p.Precocusto.ToString();
                Dados[3] = "R$ " + p.Precovenda.ToString();
                Dados[4] = p.Estoque.ToString();
                dgvListarProd.Rows.Add(Dados);
            }
        }

        private void dgvListarProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
