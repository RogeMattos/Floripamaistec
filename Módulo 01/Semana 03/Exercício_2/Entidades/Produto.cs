﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Exercício_2;

    public class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;

        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produto()
        {
        }

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void alteraAtributosPrivados(double peso2, double preco)
        { 
         peso = peso2;
         Console.WriteLine("Variável peso de escopo da classe: " + peso);

        }

    protected internal void teste() 
    {
        Console.WriteLine("Acessado");
    }
    }

