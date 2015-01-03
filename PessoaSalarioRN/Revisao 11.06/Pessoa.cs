using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisao_11._06
{
    public class Pessoa
    {
        private string cPF;

        public string CPF
        {
            get { return cPF; }
            set
            {
                bool validar = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        const string v = "1234567890";
                        if (!v.Contains(value[i]))
                            break;
                        else
                            validar = true;
                    }
                }
                else
                {
                    throw new Exception("CPF Inválido!");
                }

                if (validar)
                {
                    cPF = value;
                }
                else
                {
                    throw new Exception("CPF Inválido!");
                }
            }
        }
        private DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set
            {
                DateTime hoje = DateTime.Now;
                if (value.Year > 1930)
                {
                    dataNasc = value;
                }
                else
                {
                    throw new Exception("A pessoa deve ter nascido a partir de 1930!");
                }
            }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                char[] n = value.ToCharArray();
                if (n.Length > 5)
                {
                    if (n.Contains(' '))
                    {
                        nome = value;
                    }
                    else
                    {
                        throw new Exception("A pessoa deve ter sobrenome");
                    }
                }
                else
                {
                    throw new Exception("A pessoa deve ter nome com mais de 5 caracteres");
                }
            }
        }
        private decimal salario;

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value > 622)
                {
                    salario = value;
                }
                else
                {
                    throw new Exception("O salário deve ser maior que R$ 622,00");
                }
            }
        }
        private decimal salarioTotal;

        public decimal SalarioTotal
        {
            get 
            {
                salarioTotal = venda * (comissao / 100);
                salarioTotal = salarioTotal + salario;
                return salarioTotal;
            }
        }
        private byte comissao;

        public byte Comissao
        {
            get { return comissao; }
            set
            {
                if ((value >= 10) && (value <= 40))
                {
                    comissao = value;
                }
                else
                {
                    throw new Exception("Comissão Incondizente");
                }
            }
        }
        private decimal venda;

        public decimal Venda
        {
            get { return venda; }
            set { venda = value; }
        }

    }
}
