using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_Vendas
{
    public class Venda
    {
        public int Codigo;
        public DateTime Data;
        public double ICMS;
        public decimal ValorTotal;
        public Cliente Comprador;
        public List<ItemVenda> Itens;

        public static List<Venda> Vendas = new List<Venda>();

        public static void CadastrarVenda(Venda v)
        {
            Vendas.Add(v);
        }
    }
}
