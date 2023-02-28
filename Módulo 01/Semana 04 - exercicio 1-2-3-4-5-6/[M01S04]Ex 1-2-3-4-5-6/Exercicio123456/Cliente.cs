using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M01S04_Ex_1_2_3_4_5_6.Exercicio123456
{
    public class Cliente

    {   //exercício 01, resolução
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }

        public TipoPessoaEnum TipoPessoa { get; private set;}

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.Profissao = profissao;
            this.EstadoCivil = estadoCivil;
            this.TipoPessoa = tipoPessoa;
        }
    }
}
