using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M01S04_Ex_1_2_3_4_5_6.Exercicio123456
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca (int numero, int agencia, Cliente cliente) : base (numero, agencia, cliente)
        {
            // Aqui lançei uma exceção para validar o Tipo da pessoa física.
            // Vamos aprender mais sobre isso na próxima semana.
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // Resposta exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,10 por saque
            valor += 0.10M;
            base.Sacar(valor);
        }

        // Resposta exercício 06
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,05 por transferência
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
    
}
