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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente fc = new FormularioCliente();
            fc.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormularioProduto fp = new FormularioProduto();
            fp.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormularioVenda fv = new FormularioVenda();
            if ((Cliente.Clientes.Count != 0) && (Produto.Produtos.Count != 0))
            {
                fv.ShowDialog();
            }
            else
            {
                MessageBox.Show("É Necessário que se cadastre Clientes e Produtos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
