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
    public partial class FormularioProduto : Form
    {
        public FormularioProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProduto formProduto = new CadastroProduto();
            formProduto.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListaProduto formListaprod = new ListaProduto();
            formListaprod.ShowDialog();
        }
    }
}
