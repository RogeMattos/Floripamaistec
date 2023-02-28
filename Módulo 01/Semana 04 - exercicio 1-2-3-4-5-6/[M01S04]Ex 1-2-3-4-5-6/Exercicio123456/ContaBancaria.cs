using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M01S04_Ex_1_2_3_4_5_6.Exercicio123456
{
    public class ContaBancaria
    {
        //exercício 2, resolução
        public int Numero { get; private set; }
        public int Agencia { get; private set; }

        public Cliente Cliente { get; private set; }

        public decimal Saldo = 0;

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
        }
        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            Saldo = Saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }

            Console.WriteLine($"Valor de R$ {valor} depositado com sucesso!");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
            }

            Console.WriteLine($"Saque no valor de R$ {valor} realizado com sucesso!");
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {Saldo}");
        }
    }
}
