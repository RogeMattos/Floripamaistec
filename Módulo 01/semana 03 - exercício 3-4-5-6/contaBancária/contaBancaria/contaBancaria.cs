﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancária.contaBancaria
{
    public class ContaBancaria
    {
        // Resposta Exercício 04
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        // Resposta Exercício 03
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            // atribui os valores do construtor
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        // Resposta Exercício 05
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            // Instancia uma classe Random para gerar número aleatórios
            Random random = new Random();

            // gera um número aleatório entre 0000 e 9999
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            // atribui os valores do construtor
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        // Resposta Exercício 06
        public void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > _saldo)
            {
                Console.WriteLine("Saldo indisponível");
            }

            _saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }


        
        
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }


        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");

            }
            else
            {
                _saldo = _saldo - valor;
            }
        }


        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}
 