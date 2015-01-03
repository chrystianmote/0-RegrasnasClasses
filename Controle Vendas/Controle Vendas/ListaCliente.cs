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
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
            foreach (Cliente c in Cliente.Clientes)
            {
                string[] dados = new string[5];
                dados[0] = c.Codigo.ToString();
                dados[1] = c.Nome;
                dados[2] = c.Telefone.ToString();
                dados[3] = c.DataNasc.ToString("dd/MM/yyyy");
                dados[4] = c.Email.ToString();
                dgvListaCli.Rows.Add(dados);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
