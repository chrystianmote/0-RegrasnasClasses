using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VendasWindowsForms;
using Vendas.Classes;

namespace VendasWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGV();
        }

        private void AtualizaGV()
        {
            gvDados.DataSource = CadastroListagem.ListarCliente().ToList();
            gvDados.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nome = txtNome.Text;
            obj.Datanasc = Convert.ToDateTime(txtDataNasc.Text);
            obj.Peso = Convert.ToDouble(txtPeso.Text);
            obj.Sexo = Convert.ToChar(rblSexo.SelectedValue);
            if (CadastroListagem.Cadastrar(obj) == true)
            {
                Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
            }
            AtualizaGV();
        }
    }
}