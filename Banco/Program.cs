using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb = new ContaBancaria();

            Console.WriteLine("-----------");
            Console.WriteLine("   BANCO   ");
            Console.WriteLine("-----------");
            Console.WriteLine("Tecle Enter");
            Console.ReadLine();
            Console.Clear();

        
            Console.Write("Digite o seu nome: ");
            cb.Nome = Console.ReadLine();
            Console.Write("Digite o número da sua conta (apenas números): ");
            cb.Conta = double.Parse(Console.ReadLine());
            Console.Clear();

            Opcao:
            Console.WriteLine("Escolha as opções abaixo");
            Console.WriteLine("Opção 1: Depósito");
            Console.WriteLine("Opção 2: Saque");
            Console.WriteLine("Qual opção deseja? (1/2)");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    cb.Deposito();
                    break;
                case 2:
                    cb.Saque();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente");
                    Console.WriteLine("Tecle Enter");
                    Console.ReadLine();
                    goto Opcao;
                    

            }

            Console.WriteLine();

            Console.Write("Deseja outra ação? (Sim ou Não)");
            string op = Console.ReadLine();

            if (op == "Sim" || op == "sim")
            {
                goto Opcao;
            }

            Console.ReadKey();

        }
    }
}
