using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vendas.Classes
{
    public class Pessoa
    {
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set
            {
                if (value > 0)
                {
                    _codigo = value;
                }
                else
                    throw new Exception("O código deve ser maior que zero.");
            }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (value.Length >= 10)
                {
                    _nome = value;
                }
                else
                    throw new Exception("O nome deve possuir no mínimo 10 caracteres.");
            }
        }

        private DateTime _datanasc;

        public DateTime Datanasc
        {
            get { return _datanasc; }
            set 
            {
                if ((DateTime.Now - value).TotalDays / 365.25 < 120)
                {
                    _datanasc = value;
                }
                else
                    throw new Exception("O usuário deve ter menos de 120 anos.");
            }
        }

        private double _peso;

        public double Peso
        {
            get { return _peso; }
            set
            {
                if (value < 120)
                {
                    _peso = value;
                }
                else
                    throw new Exception("O usuário deve ter menos de 120 KG.");
            }
        }

        private char _sexo;

        public char Sexo
        {
            get { return _sexo; }
            set 
            {
                if (value == 'M' || value == 'F')
                {
                    _sexo = value;
                }
                else
                    throw new Exception("O sexo deve ser M ou F.");
            }
        }
    }
}
