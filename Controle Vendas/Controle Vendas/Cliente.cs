using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_Vendas
{
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public DateTime DataNasc;
        public string Telefone;
        public string Email;
        public List<Venda> Compras;

        public static List<Cliente> Clientes = new List<Cliente>();

        public static bool CadastrarCliente(Cliente c)
        {
            if (c != null)
            {
                Clientes.Add(c);
                return true;
            }
            else
                return false;
        }
        public static Cliente Pesquisar(string nome)
        {
            int cod;
            if (int.TryParse(nome, out cod))
            {
                foreach (Cliente c in Clientes)
                {
                    if (c.Codigo == cod)
                    {
                        return c;
                    }
                }
            }
            return null;
        }
    }
}
