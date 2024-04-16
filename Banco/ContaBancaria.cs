using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaBancaria
    {
		// Construtor
        public ContaBancaria()
        {
			this.Nome = "";
			this.Saldo = 0;
        }

        // Propriedades
        private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private double conta;

		public double Conta
		{
			get { return conta; }
			set { conta = value; }
		}

		private double saldo;

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		// Métodos
		public void Deposito()
		{
			Deposito:
			Console.Write("Digite o valor para depósito: ");
			double valor = double.Parse (Console.ReadLine());

			if (valor > 0)
			{
				this.Saldo += valor;
				Console.WriteLine($"Nome: {this.Nome}");
				Console.WriteLine($"Conta: {this.Conta}");
				Console.WriteLine($"Depósito de R${valor} realizado com sucesso");
				Console.WriteLine($"Novo saldo: R${this.Saldo}");
			}
            else
            {
				Console.WriteLine("Valor inválido. Tente novamente");
				Console.WriteLine("Tecle ENTER");
				Console.ReadLine();
				goto Deposito;
            }

        }

		public void Saque()
		{
			Saque:
			Console.Write("Digite o valor de saque: ");
			double valorSaque = double.Parse (Console.ReadLine());

			if(valorSaque > 0 && valorSaque < this.Saldo)
			{
				this.Saldo -= valorSaque;
                Console.WriteLine($"Nome: {this.Nome}");
                Console.WriteLine($"Conta: {this.Conta}");
                Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso");
                Console.WriteLine($"Novo saldo: R${this.Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido. Tente novamente");
                Console.WriteLine("Tecle ENTER");
                Console.ReadLine();
				goto Saque;
            }
        }

	}
}
