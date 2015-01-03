using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisao_11._06
{
    public partial class formCadastroSalarios : Form
    {
        public formCadastroSalarios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.CPF = mtbCPF.Text;
            p.Nome = txtNome.Text;
            p.DataNasc = dtpDataNasc.Value;
            p.Salario = Convert.ToDecimal(txtSalario.Text);
            p.Comissao = Convert.ToByte(txtComissao.Text);
            p.Venda = Convert.ToDecimal(txtVendaTotal.Text);
            txtSalarioTotal.Text = p.SalarioTotal.ToString();
        
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
