using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
           
        }
        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;

        }
        public Pessoa(float altura)
        {
            
            this.altura = altura;

        }

        public Pessoa()
        {
        }
    }
}
