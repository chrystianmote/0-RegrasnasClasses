using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vendas.Classes;

namespace VendasWindowsForms
{
    public class CadastroListagem
    {
        public static List<Pessoa> pessoas = new List<Pessoa>();
        public static bool Cadastrar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            if (pessoas.Count > 0)
                return true;
            else
                return false;
        }

        public static List<Pessoa> ListarCliente()
        {
            return pessoas;
        }
    }
}
