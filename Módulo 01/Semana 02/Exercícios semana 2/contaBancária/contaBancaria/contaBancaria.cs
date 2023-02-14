using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancária.contaBancaria
{
    //Exercício 3
    public class contaBancaria
    {
        public int numeroConta;
        public int agencia;
        public string Titular;
        public decimal saldo = 0;
        public tipoContaEnum tipoConta;

        //exercício 4
        public void depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                saldo = saldo + valor;
            }
        }
        //exercicio 5
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else if (valor > saldo)
            {

                Console.WriteLine(" O Saldo é insuficiente");
            }
            else
            {
                saldo = saldo - valor;
            }

        }

        //Exercício 6
        public void ExibirSaldo()
        { 
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
      
       

    }
     
}
      
    

    

 




