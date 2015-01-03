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
    public partial class ListaVenda : Form
    {
        public ListaVenda()
        {
            InitializeComponent();
            foreach (Venda venda in Venda.Vendas)
            {
                string[] Dados = new string[5];
                Dados[0] = venda.Codigo.ToString();
                Dados[1] = venda.Comprador.Nome;
                Dados[2] = venda.Data.ToString("dd/MM/yyyy");
                Dados[3] = venda.ValorTotal.ToString();
                dgvListaVendas.Rows.Add(Dados);

            }
        }

        private void ListaVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
