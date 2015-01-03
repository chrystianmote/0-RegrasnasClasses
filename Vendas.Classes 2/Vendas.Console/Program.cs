using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vendas.Classes;

namespace Vendas.Console
{
    class Program
    {
        public static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                System.Console.Clear();
                System.Console.Title = "--- CADASTRO ---";
                System.Console.WriteLine("--- CADASTRO ---\n");
                System.Console.WriteLine("1 - Cadastrar");
                System.Console.WriteLine("2 - Listar");
                System.Console.WriteLine("3 - Sair");
                System.Console.WriteLine("\n----------------\n");
                System.Console.Write("Digite a sua opção: ");
                op = Convert.ToInt32(System.Console.ReadLine());
                //System.Console.Clear();
                switch (op)
                {
                    case 1:
                        try
                        {
                            Pessoa p = new Pessoa();
                            System.Console.Write("Digite o código: ");
                            p.Codigo = Convert.ToInt32(System.Console.ReadLine());
                            
                            System.Console.Write("Digite o nome: ");
                            p.Nome = System.Console.ReadLine();
                            
                            System.Console.Write("Digite a data de nascimento: ");
                            p.Datanasc = Convert.ToDateTime(System.Console.ReadLine());
                            
                            System.Console.Write("Digite o peso: ");
                            p.Peso = Convert.ToDouble(System.Console.ReadLine());
                            
                            System.Console.Write("Digite o sexo (M ou F): ");
                            p.Sexo = char.Parse(System.Console.ReadLine());
                            
                            pessoas.Add(p);
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine("Ocorreu um erro, detalhes: "
                                + ex.Message);
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("Código Nome");
                        foreach (Pessoa p in pessoas)
                        {
                            System.Console.WriteLine(p.Codigo.ToString("d6") + " - " +
                                p.Nome.PadRight(20));
                        }
                        break;
                    case 3:
                        System.Console.WriteLine("Tchau!");
                        System.Console.ReadKey();
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida!");
                        System.Console.ReadKey();
                        System.Console.Clear();
                        break;
                }
            } while (op != 3);
        }
    }
}
