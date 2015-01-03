using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_Vendas
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public decimal Precocusto;
        public decimal Precovenda;
        public int Estoque;
        public List<ItemVenda> Itens;

        public static List<Produto> Produtos = new List<Produto>();

        public static bool CadastrarProduto(Produto p)
        {
            if (p != null)
            {
                Produtos.Add(p);
                return true;
            }
            else
                return false;
        }

        public static Produto Pesquisar(string nome)
        {
            int cod;
            if (int.TryParse(nome, out cod))
            {
                foreach (Produto p in Produtos)
                {
                    if (p.Codigo == cod)
                    {
                        return p;
                    }
                }
            }
            return null;
        }
    }
}
