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
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente formcliente = new CadastroCliente();
            formcliente.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListaCliente formlistacli = new ListaCliente();
            formlistacli.ShowDialog();
        }
    }
}
