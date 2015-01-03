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
    public partial class FormularioVenda : Form
    {
        public FormularioVenda()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroVenda formcadastrovenda = new CadastroVenda();
            formcadastrovenda.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListaVenda formlistavenda = new ListaVenda();
            formlistavenda.ShowDialog();
        }
    }
}
